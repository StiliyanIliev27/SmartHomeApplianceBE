using Microsoft.EntityFrameworkCore;
using SmartHomeAppliance.Core.Contracts;
using SmartHomeAppliance.Core.Models.DTOs.Profile;
using SmartHomeAppliance.Core.Models.Responses;
using SmartHomeAppliance.Infrastructure.Common;
using SmartHomeAppliance.Infrastructure.Data.Models;
using static SmartHomeAppliance.Common.CustomErrors.GlobalErrors;

namespace SmartHomeAppliance.Core.Services
{
    public class ProfileService : IProfileService
    {
        private readonly IRepository repository;
        private readonly IImageStorageService imageStorageService;
        private ApiResponse apiResponse;
        public ProfileService(IRepository repository, IImageStorageService imageStorageService)
        {
            this.repository = repository;
            apiResponse = new ApiResponse();
            this.imageStorageService = imageStorageService;
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

        public async Task<ApiResponse> GetUserProfileAsync(string userId)
        {
            var user = await repository.AllReadOnly<ApplicationUser>()
                .Where(u => u.Id == userId).FirstOrDefaultAsync();
            if(user is null)
            { 
                apiResponse.ErrorMessages.Add(UserNotFound);
                apiResponse.StatusCode = 404;
                apiResponse.IsSuccess = false;
                return apiResponse;
            }

            var userProfile = new GetUserProfileDto();
            var technician = await repository.AllReadOnly<Technician>()
                .Where(t => t.UserId == user.Id).FirstOrDefaultAsync();
            if(technician != null)
            {
                userProfile.PhoneNumber = technician.PhoneNumber;
                userProfile.City = technician.City;
            }

            var month = GetMonthName(user.CreatedAt.Month);
            var year = user.CreatedAt.Year;

            userProfile.FullName = $"{user.FirstName} {user.LastName}";
            userProfile.Email = user.Email!;
            userProfile.ProfileImage = user.ProfilePictureUrl;
            userProfile.CreatedAt = $"{month} {year}";


            apiResponse.IsSuccess = true;
            apiResponse.Message = "User profile retrieved successfully";
            apiResponse.StatusCode = 200;
            apiResponse.Result = userProfile;
            return apiResponse;
        }

        private async Task DeleteCurrentUserImageAsync(ApplicationUser user)
        {
            int startIndex = user.ProfilePictureUrl.IndexOf("homecraft");
            int endIndex = user.ProfilePictureUrl.LastIndexOf('.');

            string productImageIdCloud = user.ProfilePictureUrl.Substring(startIndex, endIndex - startIndex);

            var result = await imageStorageService.DeleteImageAsync(productImageIdCloud);

            user.ProfilePictureUrl = string.Empty;
            await repository.UpdateAsync(user);
            await repository.SaveChangesAsync();
        }

        public async Task<ApiResponse> UpdateProfileAsync(UpdateProfileRequestDto updateProfileDto, string userId)
        {
            var user = await repository.GetByIdAsync<ApplicationUser>(userId);
            if(user is null)
            {
                apiResponse.ErrorMessages.Add(UserNotFound);
                apiResponse.IsSuccess = false;
                apiResponse.StatusCode = 404;
                return apiResponse;
            }

            var profileImage = string.Empty;
            if(updateProfileDto.ProfileImage != null)
            {
                await DeleteCurrentUserImageAsync(user);
                profileImage = await imageStorageService.UploadImageAsync(updateProfileDto.ProfileImage!);
            }

            
            user.ProfilePictureUrl = profileImage != string.Empty ? profileImage : user.ProfilePictureUrl;
            user.FirstName = updateProfileDto.FirstName;
            user.LastName = updateProfileDto.LastName;
            await repository.UpdateAsync(user);

            var technician = await repository.All<Technician>().Where(t => t.UserId == userId).FirstOrDefaultAsync();
            if (technician != null)
            {
                technician.PhoneNumber = updateProfileDto.PhoneNumber!;
                technician.City = updateProfileDto.City!;
                await repository.UpdateAsync(technician);
            }

            await repository.SaveChangesAsync();

            apiResponse.Message = "User profile successfully updated!";
            apiResponse.IsSuccess = true;
            apiResponse.StatusCode = 200;
            return apiResponse;
        }

        private string GetMonthName(int month)
        {
            return month switch
            {
                1 => "January",
                2 => "February",
                3 => "March",
                4 => "April",
                5 => "May",
                6 => "June",
                7 => "July",
                8 => "August",
                9 => "September",
                10 => "October",
                11 => "November",
                12 => "December",
                _ => string.Empty
            };
        }
    }
}
