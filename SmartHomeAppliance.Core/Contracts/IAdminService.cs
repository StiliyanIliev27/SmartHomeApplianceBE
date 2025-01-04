using SmartHomeAppliance.Core.Models.DTOs.Admin.Dashboard;
using SmartHomeAppliance.Core.Models.DTOs.Admin.Users;
using SmartHomeAppliance.Core.Models.Responses;

namespace SmartHomeAppliance.Core.Contracts
{
    public interface IAdminService
    {
        Task<ApiResponse> AssignRoleAsync(AssignRoleRequestDto assignRoleDto);
        Task<ApiResponse> GetDashboardAsync();
        Task<IEnumerable<GetActivitiesDto>> GetRecentActivitiesAsync();
        Task<IDictionary<string, GetTopPerformingProductsDto>> GetTopProductsAsync();
        Task<decimal> GetOverallRatingAsync();
        Task<GetInventoryStatusDto> GetInventoryAsync();
        Task<IEnumerable<GetUsersDataDto>> GetUsersDataAsync();
    }
}
