using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SmartHomeAppliance.API.Controllers;
using SmartHomeAppliance.Core.Contracts;
using SmartHomeAppliance.Infrastructure.Data.Enums;
using SmartHomeAppliance.Infrastructure.Data.Models;
using Stripe;
using Stripe.Checkout;

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
    private readonly string webhookSecret;

    public OrderController(
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
        webhookSecret = configuration["Stripe:WebhookSecret"]!;
    }

    [HttpPost("create-checkout-session")]
    public async Task<IActionResult> CreateCheckoutSession([FromQuery] decimal promoCodePerc)
    {
        try
        {
            var cart = await cartService.GetCartAsync(UserId);
            if (cart == null)
            {
                return BadRequest(new { error = new { message = "Your cart is empty." } });
            }

            // Вземаме продуктите от количката
            var cartProducts = await cartService.GetCartProductsAsync(cart.Id);
            if (!cartProducts.Any())
            {
                return BadRequest(new { error = new { message = "Your cart is empty." } });
            }

            // Създаваме LineItems за всеки продукт в количката с проверки
            var lineItems = new List<SessionLineItemOptions>();

            foreach (var item in cartProducts)
            {
                if (item?.Product == null || item.Price <= 0 || item.Quantity <= 0)
                {
                    continue;
                }

                var lineItem = new SessionLineItemOptions
                {
                    PriceData = new SessionLineItemPriceDataOptions
                    {
                        UnitAmount = (long)(item.Price * 100),
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

            var orderResponse = await orderService.CreateOrderFromCartAsync(UserId, promoCodePerc);
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
                CancelUrl = $"http://localhost:5173/payment/cancel",
                CustomerEmail = User.Identity?.Name,
                Metadata = new Dictionary<string, string>
            {
                { "order_id", order.OrderId.ToString() }
            },
                // Добавяме shipping адрес
                ShippingAddressCollection = new SessionShippingAddressCollectionOptions
                {
                    AllowedCountries = new List<string> { "US", "CA", "GB", "BG" }
                },
                // Добавяме данни за поръчката
                PaymentIntentData = new SessionPaymentIntentDataOptions
                {
                    Description = $"Order #{order.OrderId} - Smart Home Products",
                    Metadata = new Dictionary<string, string>
                {
                    { "order_id", order.OrderId.ToString() }
                }
                }
            };

            var service = new SessionService();
            var session = await service.CreateAsync(options);

            // Clear the cart after creating the session
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
                        await orderService.UpdateOrderStatusAsync(orderId, Status.Completed);
                        var order = await orderService.GetOrderByIdAsync(orderId);
                        var userEmail = await profileService.GetUserEmailAsync(order!.UserId);
                        await emailService.SendSuccessfulOrderAsync(userEmail, $"http://localhost:5173/myOrders");
                    }
                    break;

                case "checkout.session.expired":
                    var expiredSession = stripeEvent.Data.Object as Session;
                    if (expiredSession != null && expiredSession.Metadata != null && expiredSession.Metadata.TryGetValue("order_id", out string expiredOrderId))
                    {
                        await orderService.UpdateOrderStatusAsync(expiredOrderId, Status.Cancelled);
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
            return BadRequest($"Webhook Error: {e.Message}");
        }
        catch (Exception e)
        {
            return StatusCode(500, $"Internal Error: {e.Message}");
        }
    }
}
