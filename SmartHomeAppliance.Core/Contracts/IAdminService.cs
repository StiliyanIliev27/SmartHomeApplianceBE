using SmartHomeAppliance.Core.Models.DTOs.Admin.Dashboard;
using SmartHomeAppliance.Core.Models.DTOs.Admin.Orders;
using SmartHomeAppliance.Core.Models.DTOs.Admin.Products;
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
        Task<ApiResponse> DeleteUserAsync(string userId);
        Task<IEnumerable<GetAllProductsDto>> GetProductsAsync();
        Task<ApiResponse> EditProductAsync(EditProductDto editProductDto);
        Task<ApiResponse> AddProductAsync(EditProductDto addProductDto, string creatorId);
        Task<ApiResponse> DeleteProductAsync(string productId);
        Task<IEnumerable<GetOrdersDto>> GetOrdersAsync();
        Task<ApiResponse> GetOrderDetailsByIdAsync(string orderId);
        Task<ApiResponse> UpdateOrderStatusAsync(UpdateOrderStatusDto updateStatusDto);
    }
}
