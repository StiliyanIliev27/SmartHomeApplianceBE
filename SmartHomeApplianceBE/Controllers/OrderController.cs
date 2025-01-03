using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using SmartHomeAppliance.API.Controllers;
using SmartHomeAppliance.Core.Contracts;
using SmartHomeAppliance.Core.Extensions;
using SmartHomeAppliance.Core.Models.DTOs.Order;
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
            if (cart == null)
            {
                return BadRequest(new { error = new { message = "Your cart is empty." } });
            }

            var cartProducts = await cartService.GetCartProductsAsync(cart.Id);
            if (!cartProducts.Any())
            {
                return BadRequest(new { error = new { message = "Your cart is empty." } });
            }

            var lineItems = new List<SessionLineItemOptions>();
            decimal subtotal = 0;

            // Добавяме продуктите
            foreach (var item in cartProducts)
            {
                if (item?.Product == null || item.Price <= 0 || item.Quantity <= 0)
                {
                    continue;
                }

                subtotal += item.Price * item.Quantity;

                var lineItem = new SessionLineItemOptions
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
                };

                lineItems.Add(lineItem);
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
                },
                PaymentIntentData = new SessionPaymentIntentDataOptions
                {
                    Description = $"Order #{order.OrderId}" +
                                (discountCoupon.DiscountPercentage > 0 ? $" (Including {discountCoupon.DiscountPercentage}% discount)" : ""),
                    Metadata = new Dictionary<string, string>
                {
                    { "order_id", order.OrderId.ToString() }
                }
                }
            };

            // Добавяме купон ако има промо код
            if (discountCoupon.DiscountPercentage > 0)
            {
                try
                {
                    var couponOptions = new CouponCreateOptions
                    {
                        PercentOff = (long)Math.Round(discountCoupon.DiscountPercentage),
                        Duration = "once",
                        Name = $"DISCOUNT_{discountCoupon.DiscountPercentage}OFF_{discountCoupon.DiscountCode}"
                    };

                    var couponService = new CouponService();
                    var coupon = await couponService.CreateAsync(couponOptions);

                    options.Discounts = new List<SessionDiscountOptions>
                {
                    new SessionDiscountOptions
                    {
                        Coupon = coupon.Id
                    }
                };
                }
                catch (StripeException ex)
                {
                    Console.WriteLine($"Error creating coupon: {ex.Message}");
                    // Продължаваме без отстъпка ако има грешка при създаването на купона
                }
            }

            var service = new SessionService();
            var session = await service.CreateAsync(options);

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

            switch (stripeEvent.Type)
            {
                case "checkout.session.completed":
                    var session = stripeEvent.Data.Object as Session;
                    if (session != null && session.Metadata != null && session.Metadata.TryGetValue("order_id", out string orderId))
                    {
                        await orderService.UpdateOrderStatusAsync(orderId, PaymentStatus.Completed);
                        
                        var order = await orderService.GetOrderByIdAsync(orderId);
                        var userEmail = await profileService.GetUserEmailAsync(order!.UserId);
                        await emailService.SendSuccessfulOrderAsync(userEmail, $"http://localhost:5173/orders");

                        var activity = ActivityExtensions.CreateActivity(
                           type: ActivityType.OrderUpdated,
                           messageTemplate: OrderUpdated,
                           userId: order.UserId,
                           entityId: orderId,
                           entityType: EntityType.Order,
                           parameters: new[] {
                                ("orderId", orderId),
                                ("status", order.PaymentStatus.ToString())
                           }
                        );

                        await repository.AddAsync(activity);
                        await repository.SaveChangesAsync();
                    }
                    break;

                case "checkout.session.expired":
                    var expiredSession = stripeEvent.Data.Object as Session;
                    if (expiredSession != null && expiredSession.Metadata != null && expiredSession.Metadata.TryGetValue("order_id", out string expiredOrderId))
                    {
                        await orderService.UpdateOrderStatusAsync(expiredOrderId, PaymentStatus.Cancelled);
                        
                        var order = await orderService.GetOrderByIdAsync(expiredOrderId);
                        var userEmail = await profileService.GetUserEmailAsync(order!.UserId);
                        
                        var activity = ActivityExtensions.CreateActivity(
                           type: ActivityType.OrderUpdated,
                           messageTemplate: OrderUpdated,
                           userId: order.UserId,
                           entityId: expiredOrderId,
                           entityType: EntityType.Order,
                           parameters: new[] {
                                ("orderId", expiredOrderId),
                                ("status", order.PaymentStatus.ToString())
                           }
                        );

                        await repository.AddAsync(activity);
                        await repository.SaveChangesAsync();
                        
                        // Изпращаме имейл за отказана поръчка
                        var expiredOrder = await orderService.GetOrderByIdAsync(expiredOrderId);
                        if (expiredOrder != null)
                        {
                            await emailService.SendOrderCancelledAsync(userEmail, expiredOrderId);
                        }
                    }
                    break;

                case "checkout.session.async_payment_failed":
                    var failedSession = stripeEvent.Data.Object as Session;
                    if (failedSession != null && failedSession.Metadata != null && failedSession.Metadata.TryGetValue("order_id", out string failedOrderId))
                    {
                        await orderService.UpdateOrderStatusAsync(failedOrderId, PaymentStatus.Failed);
                        
                        var failedOrder = await orderService.GetOrderByIdAsync(failedOrderId);
                        var userEmail = await profileService.GetUserEmailAsync(failedOrder!.UserId);
                       
                        var activity = ActivityExtensions.CreateActivity(
                           type: ActivityType.OrderUpdated,
                           messageTemplate: OrderUpdated,
                           userId: failedOrder.UserId,
                           entityId: failedOrderId,
                           entityType: EntityType.Order,
                           parameters: new[] {
                                ("orderId", failedOrderId),
                                ("status", failedOrder.PaymentStatus.ToString())
                           }
                        );

                        await repository.AddAsync(activity);
                        await repository.SaveChangesAsync();
                        
                        if (failedOrder != null)
                        {
                            await emailService.SendPaymentFailedAsync(userEmail, failedOrderId);
                        }
                    }
                    break;

                case "checkout.session.async_payment_succeeded":
                    var succeededSession = stripeEvent.Data.Object as Session;
                    if (succeededSession != null && succeededSession.Metadata != null && succeededSession.Metadata.TryGetValue("order_id", out string succeededOrderId))
                    {
                        await orderService.UpdateOrderStatusAsync(succeededOrderId, PaymentStatus.Completed);
                        
                        var order = await orderService.GetOrderByIdAsync(succeededOrderId);
                        var userEmail = await profileService.GetUserEmailAsync(order!.UserId);
                        
                        var activity = ActivityExtensions.CreateActivity(
                           type: ActivityType.OrderUpdated,
                           messageTemplate: OrderUpdated,
                           userId: order.UserId,
                           entityId: succeededOrderId,
                           entityType: EntityType.Order,
                           parameters: new[] {
                                ("orderId", succeededOrderId),
                                ("status", order.PaymentStatus.ToString())
                           }
                        );

                        await repository.AddAsync(activity);
                        await repository.SaveChangesAsync();
                        
                        var succeededOrder = await orderService.GetOrderByIdAsync(succeededOrderId);
                        if (succeededOrder != null)
                        {
                            await emailService.SendSuccessfulOrderAsync(userEmail, $"http://localhost:5173/orders");
                        }
                    }
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
