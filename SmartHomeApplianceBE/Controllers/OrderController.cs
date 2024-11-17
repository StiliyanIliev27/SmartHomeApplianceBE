using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SmartHomeAppliance.API.Controllers;
using SmartHomeAppliance.Core.Contracts;
using SmartHomeAppliance.Infrastructure.Data.Enums;
using SmartHomeAppliance.Infrastructure.Data.Models;
using Stripe;

[Route("api/[controller]")]
[ApiController]
[Authorize]
public class OrderController : BaseController
{
    private readonly IOrderService orderService;
    private readonly IPaymentService paymentService;
    private readonly ICartService cartService;
    private readonly string webhookSecret;

    public OrderController(
        IOrderService orderService,
        IPaymentService paymentService,
        ICartService cartService,
        IConfiguration configuration)
    {
        this.orderService = orderService;
        this.paymentService = paymentService;
        this.cartService = cartService;
        webhookSecret = configuration["Stripe:WebhookSecret"]!;
    }

    [HttpPost("checkout")]
    public async Task<IActionResult> Checkout()
    {
        // Fetch user's cart
        var cart = await cartService.GetCartAsync(UserId);
        if (cart == null)
        {
            return BadRequest(new { message = "Your cart is empty." });
        }

        // Create an order from the cart
        var orderResponse = await orderService.CreateOrderFromCartAsync(UserId);
        if (!orderResponse.IsSuccess)
        {
            return BadRequest(new { message = string.Join(", ", orderResponse.ErrorMessages) });
        }

        var order = orderResponse.Result as Order;
        if (order == null)
        {
            return StatusCode(500, new { message = "Failed to create order. Please try again." });
        }

        // Create a payment intent
        string clientSecret;
        try
        {
            clientSecret = await paymentService.CreatePaymentIntentAsync(
                order.TotalPrice,
                new Dictionary<string, string> { { "order_id", order.OrderId.ToString() } }
            );
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Failed to create payment intent.", error = ex.Message });
        }

        // Clear the cart
        try
        {
            await cartService.RemoveCartAsync(cart.UserId);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Failed to clear the cart.", error = ex.Message });
        }

        // Return the client secret for frontend payment processing
        return Ok(new
        {
            orderId = order.OrderId,
            clientSecret = clientSecret
        });
    }


    [HttpPost("stripe-webhook")]
    [AllowAnonymous]
    public async Task<IActionResult> StripeWebhook()
    {
        var json = await new StreamReader(HttpContext.Request.Body).ReadToEndAsync();

        Event stripeEvent;
        try
        {
            stripeEvent = EventUtility.ConstructEvent(
                json,
                Request.Headers["Stripe-Signature"],
                webhookSecret, 
                throwOnApiVersionMismatch: false
            );
        }
        catch (StripeException e)
        {
            return BadRequest($"Stripe Webhook Error: {e.Message}");
        }

        // Handle the event
        switch (stripeEvent.Type)
        {
            case "payment_intent.succeeded":
                var paymentIntent = stripeEvent.Data.Object as PaymentIntent;
                if (paymentIntent != null)
                {
                    var orderId = paymentIntent.Metadata["order_id"];
                    await orderService.UpdateOrderStatusAsync(orderId, Status.Completed);
                }
                break;

            case "payment_intent.payment_failed":
                var failedPaymentIntent = stripeEvent.Data.Object as PaymentIntent;
                if (failedPaymentIntent != null)
                {
                    var orderId = failedPaymentIntent.Metadata["order_id"];
                    await orderService.UpdateOrderStatusAsync(orderId, Status.Cancelled);
                }
                break;

            default:
                Console.WriteLine($"Unhandled event type: {stripeEvent.Type}");
                break;
        }

        return Ok();
    }
}
