namespace SmartHomeAppliance.Core.Contracts
{
    public interface IPaymentService
    {
        Task<string> CreatePaymentIntentAsync(decimal amount, Dictionary<string, string> metadata);
    }
}
