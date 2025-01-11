using MailKit.Security;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using MimeKit;
using MimeKit.Text;
using MailKit.Net.Smtp;
using SmartHomeAppliance.Core.Contracts;
using SmartHomeAppliance.Core.Models.Responses;


namespace SmartHomeAppliance.Core.Services
{
    public class EmailService : IEmailService
    {
        private readonly IConfiguration configuration;
        private readonly string templatePath = string.Empty;
        private readonly ILogger<EmailService> logger;

        public EmailService(IConfiguration configuration, ILogger<EmailService> logger)
        {
            this.configuration = configuration;
            this.logger = logger;
        }

        private async Task<bool> SendEmailAsync(EmailOptionsResponse emailOptions, string toEmail, string subject, string htmlBody)
        {
            var mailMessage = new MimeMessage();
            mailMessage.From.Add(MailboxAddress.Parse(emailOptions.FromEmail));
            mailMessage.To.Add(MailboxAddress.Parse(toEmail));
            mailMessage.Subject = subject;
            mailMessage.Body = new TextPart(TextFormat.Html)
            {
                Text = htmlBody
            };

            try
            {
                using var smtp = new SmtpClient();

                if (bool.TryParse(configuration["SMTP:BypassCertificateValidation"], out bool bypassCert) && bypassCert)
                {
                    smtp.ServerCertificateValidationCallback = (s, c, h, e) => true;
                }

                smtp.Connect(emailOptions.Host, emailOptions.Port, SecureSocketOptions.SslOnConnect);
                smtp.Authenticate(emailOptions.FromEmail, emailOptions.Password);
                await smtp.SendAsync(mailMessage);
                smtp.Disconnect(true);

                return true;
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Failed to send email to {Email}. Subject: {Subject}", toEmail, subject);
                return false;
            }
        }

        private EmailOptionsResponse ConfigureEmailOptions()
        {
            var emailOptionsResponse = new EmailOptionsResponse();

            var fromEmail = configuration["SMTP:Username"];
            if (string.IsNullOrWhiteSpace(fromEmail))
            {
                logger.LogError("SMTP username is not configured.");
                emailOptionsResponse.IsSuccess = false;
                return emailOptionsResponse;
            }

            var host = configuration["SMTP:Host"];
            var portString = configuration["SMTP:Port"];
            var password = configuration["SMTP:Password"];

            if (string.IsNullOrWhiteSpace(host) || string.IsNullOrWhiteSpace(portString) || string.IsNullOrWhiteSpace(password))
            {
                logger.LogError("SMTP configuration is incomplete. Please check SMTP:Host, SMTP:Port, and SMTP:Password.");
                emailOptionsResponse.IsSuccess = false;
                return emailOptionsResponse;
            }

            if (!int.TryParse(portString, out int port))
            {
                logger.LogError("SMTP port is not a valid integer.");
                emailOptionsResponse.IsSuccess = false;
                return emailOptionsResponse;
            }

            emailOptionsResponse.Host = host;
            emailOptionsResponse.Port = port;
            emailOptionsResponse.Password = password;
            emailOptionsResponse.FromEmail = fromEmail;
            emailOptionsResponse.IsSuccess = true;
            return emailOptionsResponse;
        }

        public async Task<bool> SendEmailConfirmationAsync(string toEmail, string confirmationLink)
        {
            var emailOptionsResponse = ConfigureEmailOptions();
            if (!emailOptionsResponse.IsSuccess)
            {
                return false;
            }

            var templatePath = Path.Combine("Templates", "EmailConfirmation.html");
            var template = await File.ReadAllTextAsync(templatePath);
            

            var emailBody = template
                .Replace("{LogoUrl}", "https://res.cloudinary.com/dqixe2hf5/image/upload/v1733177315/uuwkheeryeqc6doj9klt.jpg")
                .Replace("{ConfirmationLink}", confirmationLink);

            var mailMessage = new MimeMessage();
            mailMessage.From.Add(MailboxAddress.Parse(emailOptionsResponse.FromEmail));
            mailMessage.To.Add(MailboxAddress.Parse(toEmail));
            mailMessage.Subject = "Confirm Your Email - HomeCraft";
            mailMessage.Body = new TextPart(TextFormat.Html)
            {
                Text = emailBody
            };

            try
            {
                using var smtp = new SmtpClient();

                // Conditionally bypass certificate validation for development
                if (bool.TryParse(configuration["SMTP:BypassCertificateValidation"], out bool bypassCert) && bypassCert)
                {
                    smtp.ServerCertificateValidationCallback = (s, c, h, e) => true;
                }

                smtp.Connect(emailOptionsResponse.Host, emailOptionsResponse.Port, SecureSocketOptions.SslOnConnect);
                smtp.Authenticate(emailOptionsResponse.FromEmail, emailOptionsResponse.Password);
                await smtp.SendAsync(mailMessage);
                smtp.Disconnect(true);

                return true;
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Failed to send email.");
                return false;
            }
        }

        public async Task<bool> SendSuccessfulOrderAsync(string toEmail, string myOrdersLink)
        {
            var emailOptionsResponse = ConfigureEmailOptions();
            if (!emailOptionsResponse.IsSuccess)
            {
                return false;
            }

            var templatePath = Path.Combine("Templates", "SuccessfulPurchase.html");
            var template = await File.ReadAllTextAsync(templatePath);

            var emailBody = template
                .Replace("{LogoUrl}", "https://res.cloudinary.com/dqixe2hf5/image/upload/v1733177315/uuwkheeryeqc6doj9klt.jpg")
                .Replace("{ViewMyOrders}", myOrdersLink);

            return await SendEmailAsync(emailOptionsResponse, toEmail, "Successful purchase - HomeCraft", emailBody);
        }

        public async Task<bool> SendOrderCancelledAsync(string toEmail, string orderId)
        {
            var emailOptionsResponse = ConfigureEmailOptions();
            if (!emailOptionsResponse.IsSuccess)
            {
                return false;
            }

            var templatePath = Path.Combine("Templates", "CancelledOrder.html");
            var template = await File.ReadAllTextAsync(templatePath);

            var emailBody = template
                .Replace("{LogoUrl}", "https://res.cloudinary.com/dqixe2hf5/image/upload/v1733177315/uuwkheeryeqc6doj9klt.jpg")
                .Replace("{OrderId}", orderId);

            return await SendEmailAsync(emailOptionsResponse, toEmail, "Order Cancelled - HomeCraft", emailBody);
        }

        public async Task<bool> SendPaymentFailedAsync(string toEmail, string orderId)
        {
            var emailOptionsResponse = ConfigureEmailOptions();
            if (!emailOptionsResponse.IsSuccess)
            {
                return false;
            }

            var templatePath = Path.Combine("Templates", "PaymentFailed.html");
            var template = await File.ReadAllTextAsync(templatePath);

            var emailBody = template
                .Replace("{LogoUrl}", "https://res.cloudinary.com/dqixe2hf5/image/upload/v1733177315/uuwkheeryeqc6doj9klt.jpg")
                .Replace("{OrderId}", orderId);

            return await SendEmailAsync(emailOptionsResponse, toEmail, "Payment Failed - HomeCraft", emailBody);
        }
    }
}
