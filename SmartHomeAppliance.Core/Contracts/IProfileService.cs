using SmartHomeAppliance.Core.Models.DTOs.Profile;
using SmartHomeAppliance.Core.Models.Responses;

namespace SmartHomeAppliance.Core.Contracts
{
    public interface IProfileService
    {
        Task<ApiResponse> GetUserByIdAsync(string userId);
        Task<string> GetUserEmailAsync(string userId);
        Task<ApiResponse> GetUserProfileAsync(string userId);
        Task<ApiResponse> UpdateProfileAsync(UpdateProfileRequestDto updateProfileDto, string userId);
    }
}
