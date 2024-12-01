using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using SmartHomeAppliance.Core.Contracts;
using SmartHomeAppliance.Core.Models.DTOs.Auth;
using SmartHomeAppliance.Core.Models.Responses;
using SmartHomeAppliance.Infrastructure.Data.Models;
using System.Web;

namespace SmartHomeAppliance.Core.Services
{
    public class AuthService : IAuthService
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IJwtService jwtService;
        private readonly IConfiguration configuration;
        private readonly IEmailService emailService;
        private ApiResponse apiResponse;

        public AuthService(UserManager<ApplicationUser> userManager, IJwtService jwtService, IConfiguration configuration, IEmailService emailService)
        {
            this.userManager = userManager;
            this.jwtService = jwtService;
            this.configuration = configuration;
            apiResponse = new ApiResponse();
            this.emailService = emailService;
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

            apiResponse.StatusCode = 200;
            apiResponse.Result = new
            {
                token,
                userId = user.Id,
                userEmail = user.Email,
                userName = $"{user.FirstName} {user.LastName}"
            };
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

            // 2. Create a new User
            var user = new ApplicationUser
            {
                FirstName = registerModel.FirstName,
                LastName = registerModel.LastName,
                UserName = registerModel.Email,
                Email = registerModel.Email,
                ProfilePictureUrl = registerModel.ProfilePictureUrl
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
