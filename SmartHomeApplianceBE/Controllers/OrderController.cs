using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SmartHomeAppliance.Core.Contracts;
using SmartHomeAppliance.Core.Models.DTOs.Order;
using SmartHomeAppliance.Core.Services;
using SmartHomeAppliance.Infrastructure.Data.Enums;
using Stripe;

namespace SmartHomeAppliance.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService orderService;
        private readonly IPaymentService paymentService;
        private readonly ILogger<OrderController> logger;
        private readonly string webhookSecret;

        public OrderController(IOrderService orderService, IPaymentService paymentService, IConfiguration configuration, ILogger<OrderController> logger)
        {
            this.orderService = orderService;
            this.paymentService = paymentService;
            webhookSecret = configuration["Stripe:WebhookSecret"]!;
            this.logger = logger;
        }

        [HttpPost("create-order")]
        public async Task<IActionResult> CreateOrder([FromBody] OrderRequestDto orderRequestDto)
        {
            var order = await orderService.CreateOrderAsync(orderRequestDto.UserId, orderRequestDto.ProductId, orderRequestDto.Quantity);

            var paymentIntent = await paymentService.CreatePaymentIntentAsync(
                order.TotalPrice,
                new Dictionary<string, string> { { "order_id", order.Id.ToString() } }
            );

            return Ok(new { clientSecret = paymentIntent });
        }

        [HttpPost("stripe-webhook")]
        [AllowAnonymous]
        public async Task<IActionResult> StripeWebhook()
        {
            var json = await new StreamReader(HttpContext.Request.Body).ReadToEndAsync();

            var stripeEvent = EventUtility.ConstructEvent(
                json,
                Request.Headers["Stripe-Signature"], 
                webhookSecret,
                throwOnApiVersionMismatch: false);

            // Handle the event
            if (stripeEvent.Type == "payment_intent.succeeded")
            {
                var paymentIntent = stripeEvent.Data.Object as PaymentIntent;

                if (paymentIntent == null)
                {
                    return BadRequest();
                }
                // Fulfill the purchase...
                await orderService.UpdateOrderStatusAsync(Guid.Parse(paymentIntent.Metadata["order_id"]), Status.Completed);
            }
            else
            {
                logger.LogWarning("Unhandled event type: {0}", stripeEvent.Type);
            }

            return Ok();
        }


    }
}
