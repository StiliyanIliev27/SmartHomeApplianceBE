using SmartHomeAppliance.Core.Models.DTOs.Admin;
using SmartHomeAppliance.Core.Models.Responses;

namespace SmartHomeAppliance.Core.Contracts
{
    public interface IAdminService
    {
        Task<ApiResponse> AssignRoleAsync(string userId, string role);
        Task<ApiResponse> GetDashboardAsync();
        Task<IEnumerable<GetActivitiesDto>> GetRecentActivitiesAsync();
    }
}
