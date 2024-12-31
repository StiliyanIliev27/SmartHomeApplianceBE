using Microsoft.Extensions.Configuration;
using SmartHomeAppliance.Core.Contracts;
using Stripe;

namespace SmartHomeAppliance.Core.Services
{
    public class PaymentService : IPaymentService
    {
        private readonly IConfiguration configuration;
        public PaymentService(IConfiguration configuration)
        {
            this.configuration = configuration;
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
    }
}
