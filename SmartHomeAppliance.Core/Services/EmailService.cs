﻿using MailKit.Security;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using MimeKit;
using MimeKit.Text;
using MailKit.Net.Smtp;
using SmartHomeAppliance.Core.Contracts;

namespace SmartHomeAppliance.Core.Services
{
    public class EmailService : IEmailService
    {
        private readonly IConfiguration configuration;
        private readonly ILogger<EmailService> logger;

        public EmailService(IConfiguration configuration, ILogger<EmailService> logger)
        {
            this.configuration = configuration;
            this.logger = logger;
        }

        public async Task<bool> SendEmailConfirmationAsync(string toEmail, string confirmationLink)
        {
            var fromEmail = configuration["SMTP:Username"];
            if (string.IsNullOrWhiteSpace(fromEmail))
            {
                logger.LogError("SMTP username is not configured.");
                return false;
            }

            var host = configuration["SMTP:Host"];
            var portString = configuration["SMTP:Port"];
            var password = configuration["SMTP:Password"];

            if (string.IsNullOrWhiteSpace(host) || string.IsNullOrWhiteSpace(portString) || string.IsNullOrWhiteSpace(password))
            {
                logger.LogError("SMTP configuration is incomplete. Please check SMTP:Host, SMTP:Port, and SMTP:Password.");
                return false;
            }

            if (!int.TryParse(portString, out int port))
            {
                logger.LogError("SMTP port is not a valid integer.");
                return false;
            }

            var mailMessage = new MimeMessage();
            mailMessage.From.Add(MailboxAddress.Parse(fromEmail));
            mailMessage.To.Add(MailboxAddress.Parse(toEmail));
            mailMessage.Subject = "Confirm Your Email";
            mailMessage.Body = new TextPart(TextFormat.Html)
            {
                Text = $"Please confirm your email by clicking on the link: <a href='{confirmationLink}'>Confirm Email</a>"
            };

            try
            {
                using var smtp = new SmtpClient();

                // Conditionally bypass certificate validation for development
                if (bool.TryParse(configuration["SMTP:BypassCertificateValidation"], out bool bypassCert) && bypassCert)
                {
                    smtp.ServerCertificateValidationCallback = (s, c, h, e) => true;
                }

                smtp.Connect(host, port, SecureSocketOptions.SslOnConnect);
                smtp.Authenticate(fromEmail, password);
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

    }
}