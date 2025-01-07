using SmartHomeAppliance.Core.Models.DTOs.Admin.Orders;

namespace SmartHomeAppliance.Core.Contracts
{
    public interface IPaymentService
    {
        Task<string> CreatePaymentIntentAsync(decimal amount, Dictionary<string, string> metadata);
        Task<StripePaymentDetails> GetStripePaymentDetails(string paymentIntentId);
    }
}
