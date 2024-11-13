namespace SmartHomeAppliance.Core.Contracts
{
    public interface IEmailService
    {
        Task<bool> SendEmailConfirmationAsync(string toEmail, string confirmationLink);
    }
}
