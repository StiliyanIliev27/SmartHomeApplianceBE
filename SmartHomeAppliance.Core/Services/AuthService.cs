using MailKit.Security;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using MimeKit.Text;
using MimeKit;
using SmartHomeAppliance.Core.Contracts;
using SmartHomeAppliance.Core.Models.DTOs.Auth;
using SmartHomeAppliance.Core.Models.Responses;
using SmartHomeAppliance.Infrastructure.Data.Models;
using MailKit.Net.Smtp;
using static SmartHomeAppliance.Common.CustomErrors.GlobalErrors;
using System.IdentityModel.Tokens.Jwt;

namespace SmartHomeAppliance.Core.Services
{
    public class AuthService : IAuthService
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IJwtService jwtService;
        private readonly IConfiguration configuration;
        private readonly IEmailService emailService;
        private readonly IImageStorageService imageStorageService;
        private readonly ILogger<AuthService> logger;
        private ApiResponse apiResponse;

        public AuthService(UserManager<ApplicationUser> userManager, IJwtService jwtService, 
            IConfiguration configuration, IEmailService emailService, IImageStorageService imageStorageService, 
            ILogger<AuthService> logger)
        {
            this.userManager = userManager;
            this.jwtService = jwtService;
            this.configuration = configuration;
            apiResponse = new ApiResponse();
            this.emailService = emailService;
            this.imageStorageService = imageStorageService;
            this.logger = logger;
        }

        public async Task<ApiResponse> ResetPasswordAsync(ResetPasswordDTO newPasswordModel)
        {
            var user = await userManager.FindByIdAsync(newPasswordModel.UserId);

            if (user == null)
            {
                apiResponse.ErrorMessages.Add(UserNotFound);
                apiResponse.IsSuccess = false;
                apiResponse.StatusCode = 404;
                return apiResponse;
            }

            if (!user.EmailConfirmed)
            {
                apiResponse.ErrorMessages.Add("Your account is not actived yet! Please, confirm your email first!");
                apiResponse.IsSuccess = false;
                apiResponse.StatusCode = 400;
                return apiResponse;
            }

            try
            {
                string resetToken = await userManager.GeneratePasswordResetTokenAsync(user);
                await userManager.ResetPasswordAsync(user, resetToken, newPasswordModel.NewPassword);

                apiResponse.IsSuccess = true;
                apiResponse.StatusCode = 200;
                apiResponse.Message = $"User with email {user.Email} successfully updated his/her password!";
                return apiResponse;
            }
            catch(Exception ex)
            {
                apiResponse.ErrorMessages.Add(ex.Message);
                apiResponse.IsSuccess = false;
                apiResponse.StatusCode = 500;
                return apiResponse;
            }
        }

        public async Task<ApiResponse> ForgotPasswordAsync(ForgotPasswordDTO forgotPasswordModel)
        {
            var user = await userManager.FindByEmailAsync(forgotPasswordModel.Email);

            if(user == null)
            {
                apiResponse.ErrorMessages.Add($"User with email {forgotPasswordModel.Email} was not found!");
                apiResponse.IsSuccess = false;
                apiResponse.StatusCode = 404;
                return apiResponse;
            }

            if (!user.EmailConfirmed)
            {
                apiResponse.ErrorMessages.Add("Your account is not actived yet! Please, confirm your email first!");
                apiResponse.IsSuccess = false;
                apiResponse.StatusCode = 400;
                return apiResponse;
            }

            var fromEmail = configuration["SMTP:Username"];
            if (string.IsNullOrWhiteSpace(fromEmail))
            {
                logger.LogError("SMTP username is not configured.");
                apiResponse.IsSuccess = false;
                apiResponse.StatusCode = 400;
                return apiResponse;
            }

            var host = configuration["SMTP:Host"];
            var portString = configuration["SMTP:Port"];
            var password = configuration["SMTP:Password"];

            if (string.IsNullOrWhiteSpace(host) || string.IsNullOrWhiteSpace(portString) || string.IsNullOrWhiteSpace(password))
            {
                logger.LogError("SMTP configuration is incomplete. Please check SMTP:Host, SMTP:Port, and SMTP:Password.");
                apiResponse.IsSuccess = false;
                apiResponse.StatusCode = 400;
                return apiResponse;
            }

            if (!int.TryParse(portString, out int port))
            {
                logger.LogError("SMTP port is not a valid integer.");
                apiResponse.IsSuccess = false;
                apiResponse.StatusCode = 400;
                return apiResponse;
            }

            var templatePath = Path.Combine("Templates", "ChangePassword.html");
            var template = await File.ReadAllTextAsync(templatePath);

            var forgotPasswordLink = $"{configuration["FrontendUrl"]}/reset-password?userId={user.Id}";

            var emailBody = template
                .Replace("{LogoUrl}", "https://res.cloudinary.com/dqixe2hf5/image/upload/v1733177315/uuwkheeryeqc6doj9klt.jpg")
                .Replace("{ChangePasswordLink}", forgotPasswordLink);

            var mailMessage = new MimeMessage();
            mailMessage.From.Add(MailboxAddress.Parse(fromEmail));
            mailMessage.To.Add(MailboxAddress.Parse(forgotPasswordModel.Email));
            mailMessage.Subject = "Forgot Password - HomeCraft";
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

                smtp.Connect(host, port, SecureSocketOptions.SslOnConnect);
                smtp.Authenticate(fromEmail, password);
                await smtp.SendAsync(mailMessage);
                smtp.Disconnect(true);

                apiResponse.Message = $"Email for reset password was sent successfully to the email {forgotPasswordModel.Email}";
                apiResponse.IsSuccess = true;
                apiResponse.StatusCode = 200;
                return apiResponse;
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Failed to send email.");
                apiResponse.ErrorMessages.Add(ex.Message);
                apiResponse.IsSuccess = false;
                apiResponse.StatusCode = 500;
                return apiResponse;
            }
        }

        public async Task<ApiResponse> LoginAsync(LoginDTO loginModel)
        {
            var user = await userManager.FindByEmailAsync(loginModel.Email);

            if (user is null || !await userManager.CheckPasswordAsync(user, loginModel.Password))
            {
                apiResponse.ErrorMessages.Add("Email or password is incorrect!");
                apiResponse.IsSuccess = false;
                apiResponse.StatusCode = 400;
                return apiResponse;
            }

            if (!user.EmailConfirmed)
            {
                apiResponse.ErrorMessages.Add("Your account is not actived yet! Please, confirm your email first!");
                apiResponse.IsSuccess = false;
                apiResponse.StatusCode = 400;
                return apiResponse;
            }

            var token = await jwtService.GenerateTokenAsync(user.Id); // Include user roles and other claims if needed
            var isAdmin = await userManager.IsInRoleAsync(user, "Admin");

            apiResponse.StatusCode = 200;
            apiResponse.Result = new { token, user, isAdmin };
            apiResponse.IsSuccess = true;

            return apiResponse;
        }
        public async Task<ApiResponse> RegisterAsync(RegisterDTO registerModel)
        {
            // 1. Check if user already exists
            if (await userManager.FindByEmailAsync(registerModel.Email) != null)
            {
                apiResponse.ErrorMessages.Add("User with this email already registered!");
                apiResponse.IsSuccess = false;
                apiResponse.StatusCode = 400;
                return apiResponse;
            }

            string profilePictureUrl = string.Empty;

            if(registerModel.ProfilePicture != null)
            {
                profilePictureUrl = await imageStorageService.UploadImageAsync(registerModel.ProfilePicture);
            }

            // 2. Create a new User
            var user = new ApplicationUser
            {
                FirstName = registerModel.FirstName,
                LastName = registerModel.LastName,
                UserName = registerModel.Email,
                Email = registerModel.Email,
                ProfilePictureUrl = profilePictureUrl
            };

            // 3. Create the user in the database first
            var result = await userManager.CreateAsync(user, registerModel.Password);
            await userManager.AddToRoleAsync(user, "User");

            if (!result.Succeeded)
            {
                apiResponse.ErrorMessages.Add("User creation failed!");
                apiResponse.IsSuccess = false;
                apiResponse.StatusCode = 400;
                return apiResponse;
            }

            // Step 4. Generate the email confirmation token
            var confirmationToken = await userManager.GenerateEmailConfirmationTokenAsync(user);

            var confirmationUrl = $"{configuration["FrontendUrl"]}/confirm-email?token={confirmationToken}&userId={user.Id}";

            // Step 5: Send the confirmation email
            var emailSent = await emailService.SendEmailConfirmationAsync(user.Email, confirmationUrl);
            if (!emailSent)
            {
                apiResponse.ErrorMessages.Add("Failed to send confirmation email.");
                apiResponse.IsSuccess = false;
                apiResponse.StatusCode = 500;
                return apiResponse;
            }

            // Step 6: Return response
            apiResponse.StatusCode = 201;
            apiResponse.Result = new { Message = "Please check your email to confirm your account." };
            apiResponse.IsSuccess = true;

            return apiResponse;
        }

        private UserResponseDto MapUserToUserResponseDto(ApplicationUser user)
        {
            return new UserResponseDto()
            {
                Id = user.Id,
                Email = user.Email!,
                FirstName = user.FirstName,
                LastName = user.LastName,
                ProfilePictureUrl = user.ProfilePictureUrl
            };
        }
    }
}
