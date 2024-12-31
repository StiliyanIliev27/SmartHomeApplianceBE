using SmartHomeAppliance.Core.Models.Responses;

namespace SmartHomeAppliance.Core.Contracts
{
    public interface IProfileService
    {
        Task<ApiResponse> GetUserByIdAsync(string userId);
        Task<string> GetUserEmailAsync(string userId);
    }
}
