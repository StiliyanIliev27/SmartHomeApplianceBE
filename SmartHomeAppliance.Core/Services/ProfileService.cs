using Microsoft.EntityFrameworkCore;
using SmartHomeAppliance.Core.Contracts;
using SmartHomeAppliance.Core.Models.Responses;
using SmartHomeAppliance.Infrastructure.Common;
using SmartHomeAppliance.Infrastructure.Data.Models;
using static SmartHomeAppliance.Common.CustomErrors.GlobalErrors;

namespace SmartHomeAppliance.Core.Services
{
    public class ProfileService : IProfileService
    {
        private readonly IRepository repository;
        private ApiResponse apiResponse;
        public ProfileService(IRepository repository)
        {
            this.repository = repository;
            apiResponse = new ApiResponse();
        }
        public async Task<ApiResponse> GetUserByIdAsync(string userId)
        {
            var user = await repository.GetByIdAsync<ApplicationUser>(userId);
            if(user is null)
            {
                apiResponse.ErrorMessages.Add(UserNotFound);
                apiResponse.StatusCode = 404;
                apiResponse.IsSuccess = false;
                return apiResponse;
            }

            apiResponse.IsSuccess = true;
            apiResponse.StatusCode = 200;
            apiResponse.Result = user;
            return apiResponse;
        }

        public async Task<string> GetUserEmailAsync(string userId)
        {
            var user = await repository.AllReadOnly<ApplicationUser>().Where(u => u.Id == userId).FirstOrDefaultAsync();
            if (user is null)
                return string.Empty;

            return user.Email!;
        }
    }
}
