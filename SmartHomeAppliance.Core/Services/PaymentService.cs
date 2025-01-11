using Microsoft.Extensions.Configuration;
using SmartHomeAppliance.Core.Contracts;
using SmartHomeAppliance.Core.Models.DTOs.Admin.Orders;
using Stripe;

namespace SmartHomeAppliance.Core.Services
{
    public class PaymentService : IPaymentService
    {
        private readonly IConfiguration configuration;
        private readonly IStripeClient client;
        public PaymentService(IConfiguration configuration)
        {
            this.configuration = configuration;
            StripeConfiguration.ApiKey = configuration["Stripe:SecretKey"];
            client = new StripeClient(configuration["Stripe:SecretKey"]);
        }
        public async Task<string> CreatePaymentIntentAsync(decimal amount, Dictionary<string, string> metadata)
        {
            var options = new PaymentIntentCreateOptions
            {
                Amount = (long)(amount * 100), // Stripe uses cents
                Currency = "usd",
                Metadata = metadata,
                AutomaticPaymentMethods = new PaymentIntentAutomaticPaymentMethodsOptions
                {
                    Enabled = true,
                }
            };

            var service = new PaymentIntentService();
            var paymentIntent = await service.CreateAsync(options);

            return paymentIntent.ClientSecret;
        }

        public async Task<StripePaymentDetails> GetStripePaymentDetails(string paymentIntentId)
        {
            try
            {
                var service = new PaymentIntentService(client);
                var paymentIntent = await service.GetAsync(paymentIntentId);

                if (paymentIntent == null)
                    throw new Exception("Payment intent not found");

                var paymentMethod = await new PaymentMethodService(client)
                    .GetAsync(paymentIntent.PaymentMethodId);

                return new StripePaymentDetails
                {   
                    ShippingDetails = new AddressDto
                    {
                        FirstName = paymentIntent.Shipping?.Name?.Split(' ').FirstOrDefault()!,
                        LastName = paymentIntent.Shipping?.Name?.Split(' ').LastOrDefault()!,
                        Street = paymentIntent.Shipping?.Address?.Line1!,
                        City = paymentIntent.Shipping?.Address?.City!,
                        State = paymentIntent.Shipping?.Address?.State!,
                        PostalCode = paymentIntent.Shipping?.Address?.PostalCode!,
                        Country = paymentIntent.Shipping?.Address?.Country!,
                    }
                };
            }
            catch (StripeException ex)
            {
                throw new Exception($"Stripe API error: {ex.Message}");
            }
        }
    }
}
