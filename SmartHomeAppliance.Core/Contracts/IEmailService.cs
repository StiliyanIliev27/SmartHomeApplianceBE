namespace SmartHomeAppliance.Core.Contracts
{
    public interface IEmailService
    {
        Task<bool> SendEmailConfirmationAsync(string toEmail, string confirmationLink);
        Task<bool> SendSuccessfulOrderAsync(string toEmail, string myOrdersLink);
        Task<bool> SendOrderCancelledAsync(string email, string orderId);
        Task<bool> SendPaymentFailedAsync(string email, string orderId);
    }
}
