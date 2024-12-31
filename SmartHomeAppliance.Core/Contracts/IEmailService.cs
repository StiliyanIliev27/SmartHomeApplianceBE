namespace SmartHomeAppliance.Core.Contracts
{
    public interface IEmailService
    {
        Task<bool> SendEmailConfirmationAsync(string toEmail, string confirmationLink);
        Task<bool> SendSuccessfulOrderAsync(string toEmail, string myOrdersLink);
    }
}
