using SmartHomeAppliance.Core.Models.Responses;

namespace SmartHomeAppliance.Core.Contracts
{
    public interface IAdminService
    {
        Task<ApiResponse> AssignRoleAsync(string userId, string role);
    }
}
