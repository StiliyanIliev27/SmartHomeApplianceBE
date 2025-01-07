using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SmartHomeAppliance.API.Controllers;
using SmartHomeAppliance.Core.Contracts;
using SmartHomeAppliance.Core.Extensions;
using SmartHomeAppliance.Core.Models.DTOs.Payment;
using SmartHomeAppliance.Infrastructure.Common;
using SmartHomeAppliance.Infrastructure.Data.Enums;
using SmartHomeAppliance.Infrastructure.Data.Models;
using Stripe;
using Stripe.Checkout;
using static SmartHomeAppliance.Common.GlobalConstants.ActivityMessages;

[Route("api/[controller]")]
[ApiController]
[Authorize]
public class OrderController : BaseController
{
    private readonly IOrderService orderService;
    private readonly IPaymentService paymentService;
    private readonly ICartService cartService;
    private readonly IProfileService profileService;
    private readonly IEmailService emailService;
    private readonly IRepository repository;
    private readonly string webhookSecret;

    public OrderController(
        IRepository repository,
        IOrderService orderService,
        IPaymentService paymentService,
        ICartService cartService,
        IProfileService profileService,
        IConfiguration configuration,
        IEmailService emailService)
    {
        this.orderService = orderService;
        this.paymentService = paymentService;
        this.cartService = cartService;
        this.emailService = emailService;
        this.profileService = profileService;
        this.repository = repository;
        webhookSecret = configuration["Stripe:WebhookSecret"]!;
    }

    [HttpGet]
    public async Task<IActionResult> GetMyOrders()
    {
        var response = await orderService.GetMyOrdersAsync(UserId);

        return Ok(response);
    }

    [HttpPost("create-checkout-session")]
    public async Task<IActionResult> CreateCheckoutSession([FromQuery] DiscountCouponDto discountCoupon)
    {
        try
        {
            var cart = await cartService.GetCartAsync(UserId);
            if (cart == null || !(await cartService.GetCartProductsAsync(cart.Id)).Any())
            {
                return BadRequest(new { error = new { message = "Your cart is empty." } });
            }

            var cartProducts = await cartService.GetCartProductsAsync(cart.Id);
            var lineItems = new List<SessionLineItemOptions>();
            decimal subtotal = 0;

            foreach (var item in cartProducts.Where(x => x?.Product != null && x.Price > 0 && x.Quantity > 0))
            {
                subtotal += item.Price * item.Quantity;
                lineItems.Add(new SessionLineItemOptions
                {
                    PriceData = new SessionLineItemPriceDataOptions
                    {
                        UnitAmount = (long)Math.Round(item.Price * 100),
                        Currency = "usd",
                        ProductData = new SessionLineItemPriceDataProductDataOptions
                        {
                            Name = item.Product.Name ?? "Unknown Product",
                            Description = $"Category: {item.Product.GetCategoryNormalized() ?? "Uncategorized"}",
                            Images = new List<string>
                        {
                            !string.IsNullOrEmpty(item.Product.ImageUrl)
                                ? item.Product.ImageUrl
                                : "https://your-default-image-url.com/placeholder.jpg"
                        }
                        }
                    },
                    Quantity = item.Quantity
                });
            }

            if (!lineItems.Any())
            {
                return BadRequest(new { error = new { message = "No valid items in cart." } });
            }

            var orderResponse = await orderService.CreateOrderFromCartAsync(UserId, discountCoupon.DiscountPercentage);
            if (!orderResponse.IsSuccess)
            {
                return BadRequest(new { error = new { message = string.Join(", ", orderResponse.ErrorMessages) } });
            }

            var order = orderResponse.Result as Order;

            var options = new SessionCreateOptions
            {
                PaymentMethodTypes = new List<string> { "card" },
                LineItems = lineItems,
                Mode = "payment",
                SuccessUrl = $"http://localhost:5173/payment/success?session_id={{CHECKOUT_SESSION_ID}}",
                CancelUrl = $"http://localhost:5173/payment/cancel?order_id={order!.OrderId}",
                CustomerEmail = User.Identity?.Name,
                Metadata = new Dictionary<string, string>
            {
                { "order_id", order.OrderId.ToString() },
                { "original_amount", subtotal.ToString("F2") },
                { "discount_percentage", discountCoupon.DiscountPercentage.ToString("F2") }
            },
                ShippingAddressCollection = new SessionShippingAddressCollectionOptions
                {
                    AllowedCountries = new List<string> { "US", "CA", "GB", "BG" }
                }
            };

            if (discountCoupon.DiscountPercentage > 0)
            {
                try
                {
                    var coupon = await new CouponService().CreateAsync(new CouponCreateOptions
                    {
                        PercentOff = (long)Math.Round(discountCoupon.DiscountPercentage),
                        Duration = "once",
                        Name = $"DISCOUNT_{discountCoupon.DiscountPercentage}OFF_{discountCoupon.DiscountCode}"
                    });

                    options.Discounts = new List<SessionDiscountOptions>
                {
                    new SessionDiscountOptions { Coupon = coupon.Id }
                };
                }
                catch (StripeException ex)
                {
                    Console.WriteLine($"Error creating coupon: {ex.Message}");
                }
            }

            var session = await new SessionService().CreateAsync(options);
            await cartService.RemoveCartAsync(UserId);

            return Ok(new { url = session.Url });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { error = new { message = ex.Message } });
        }
    }

    [HttpPost("webhook")]
    [AllowAnonymous]
    public async Task<IActionResult> StripeWebhook()
    {
        var json = await new StreamReader(HttpContext.Request.Body).ReadToEndAsync();

        try
        {
            var stripeEvent = EventUtility.ConstructEvent(
                json,
                Request.Headers["Stripe-Signature"],
                webhookSecret,
                throwOnApiVersionMismatch: false
            );

            var session = stripeEvent.Data.Object as Session;
            if (session?.Metadata == null || !session.Metadata.TryGetValue("order_id", out string orderId))
            {
                return BadRequest("Invalid session data");
            }

            var order = await orderService.GetOrderByIdAsync(orderId);
            if (order == null)
            {
                return BadRequest("Order not found");
            }

            switch (stripeEvent.Type)
            {
                case "checkout.session.completed":
                    await HandleCheckoutSessionCompleted(session, order);
                    break;

                case "checkout.session.expired":
                    await HandleCheckoutSessionExpired(order);
                    break;

                case "checkout.session.async_payment_failed":
                    await HandleCheckoutSessionPaymentFailed(order);
                    break;

                case "checkout.session.async_payment_succeeded":
                    await HandleCheckoutSessionPaymentSucceeded(order);
                    break;

                default:
                    Console.WriteLine($"Unhandled event type: {stripeEvent.Type}");
                    break;
            }

            return Ok();
        }
        catch (StripeException e)
        {
            Console.WriteLine($"Stripe Error: {e.Message}");
            return BadRequest($"Webhook Error: {e.Message}");
        }
        catch (Exception e)
        {
            Console.WriteLine($"General Error: {e.Message}");
            return StatusCode(500, $"Internal Error: {e.Message}");
        }
    }

    private async Task HandleCheckoutSessionCompleted(Session session, Order order)
    {
        // Запазваме PaymentIntentId
        order.StripePaymentIntentId = session.PaymentIntentId;
        await repository.UpdateAsync(order);
        await repository.SaveChangesAsync();

        await orderService.UpdateOrderStatusAsync(order.OrderId.ToString(), PaymentStatus.Completed);
        var userEmail = await profileService.GetUserEmailAsync(order.UserId);
        await emailService.SendSuccessfulOrderAsync(userEmail, "http://localhost:5173/orders");

        await CreateAndSaveOrderActivity(order, ActivityType.OrderUpdated, OrderUpdated);
    }

    private async Task HandleCheckoutSessionExpired(Order order)
    {
        await orderService.UpdateOrderStatusAsync(order.OrderId.ToString(), PaymentStatus.Cancelled);
        var userEmail = await profileService.GetUserEmailAsync(order.UserId);
        await emailService.SendOrderCancelledAsync(userEmail, order.OrderId.ToString());

        await CreateAndSaveOrderActivity(order, ActivityType.OrderUpdated, OrderUpdated);
    }

    private async Task HandleCheckoutSessionPaymentFailed(Order order)
    {
        await orderService.UpdateOrderStatusAsync(order.OrderId.ToString(), PaymentStatus.Failed);
        var userEmail = await profileService.GetUserEmailAsync(order.UserId);
        await emailService.SendPaymentFailedAsync(userEmail, order.OrderId.ToString());

        await CreateAndSaveOrderActivity(order, ActivityType.OrderUpdated, OrderUpdated);
    }

    private async Task HandleCheckoutSessionPaymentSucceeded(Order order)
    {
        await orderService.UpdateOrderStatusAsync(order.OrderId.ToString(), PaymentStatus.Completed);
        var userEmail = await profileService.GetUserEmailAsync(order.UserId);
        await emailService.SendSuccessfulOrderAsync(userEmail, "http://localhost:5173/orders");

        await CreateAndSaveOrderActivity(order, ActivityType.OrderUpdated, OrderUpdated);
    }

    private async Task CreateAndSaveOrderActivity(Order order, ActivityType type, string messageTemplate)
    {
        var activity = ActivityExtensions.CreateActivity(
            type: type,
            messageTemplate: messageTemplate,
            userId: order.UserId,
            entityId: order.OrderId.ToString(),
            entityType: EntityType.Order,
            parameters: new[] {
            ("orderId", order.OrderId.ToString()),
            ("status", order.PaymentStatus.ToString())
            }
        );

        await repository.AddAsync(activity);
        await repository.SaveChangesAsync();
    }

    [HttpPost("cancel")]
    public async Task<IActionResult> HandleCancelledPayment([FromQuery] string orderId)
    {
        try
        {
            if (string.IsNullOrEmpty(orderId))
            {
                return BadRequest(new { error = "Order ID is required" });
            }

            // Обновете статуса на поръчката
            await orderService.UpdateOrderStatusAsync(orderId, PaymentStatus.Cancelled);

            var order = await orderService.GetOrderByIdAsync(orderId);
            var userEmail = await profileService.GetUserEmailAsync(order.UserId);

            var activity = ActivityExtensions.CreateActivity(
                type: ActivityType.OrderCancelled,
                messageTemplate: OrderCancelled,
                userId: order.UserId,
                entityId: orderId,
                entityType: EntityType.Order,
                parameters: new[] {
                    ("orderId", orderId),
                    ("reason", "User has left the payment page!")
                }
            );

            await repository.AddAsync(activity);
            await repository.SaveChangesAsync();
    
            if (order != null)
            {
                await emailService.SendOrderCancelledAsync(userEmail, orderId);
            }

            return Ok(new { message = "Order cancelled successfully" });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { error = ex.Message });
        }
    }
}
