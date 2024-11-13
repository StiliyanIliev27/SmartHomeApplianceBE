using Microsoft.AspNetCore.Identity;
using SmartHomeAppliance.Core.Contracts;
using SmartHomeAppliance.Core.Models.Responses;
using SmartHomeAppliance.Infrastructure.Common;
using SmartHomeAppliance.Infrastructure.Data.Models;
using static SmartHomeAppliance.Common.CustomErrors.GlobalErrors;

namespace SmartHomeAppliance.Core.Services
{
    public class AdminService : IAdminService
    {
        private readonly IRepository repository;
        private readonly UserManager<ApplicationUser> userManager;
        private ApiResponse apiResponse;
        public AdminService(IRepository repository, UserManager<ApplicationUser> userManager)
        {
            this.repository = repository;
            this.userManager = userManager;
            apiResponse = new ApiResponse();
        }
        public async Task<ApiResponse> AssignRoleAsync(string userId, string role)
        {
            var user = await userManager.FindByIdAsync(userId);
            if(user == null)
            {
                apiResponse.ErrorMessages.Add(UserNotFound);
                apiResponse.StatusCode = 404;
                apiResponse.IsSuccess = false;
                return apiResponse;
            }

            var result = await userManager.AddToRoleAsync(user, role);
            if (!result.Succeeded)
            {
                apiResponse.ErrorMessages.Add(result.Errors.ToString()!);
                apiResponse.StatusCode = 400;
                apiResponse.IsSuccess = false;
                return apiResponse;
            }

            apiResponse.StatusCode = 200;
            apiResponse.Result = user;
            apiResponse.IsSuccess = true;
            apiResponse.Message = $"Role {role} assigned to {user.FirstName} {user.LastName}";

            return apiResponse;               
        }
    }
}
