using SmartHomeAppliance.Core.Models.DTOs.Technician;
using SmartHomeAppliance.Core.Models.Responses;

namespace SmartHomeAppliance.Core.Contracts
{
    public interface ITechnicianService
    {
        Task<IEnumerable<GetAllTechniciansByProductDto>> GetAllTechniciansByProductId(string productId);
        Task<ApiResponse> AddProductAsync(string userId, AddProductDto addProductDto);
        Task<ApiResponse> RemoveProductAsync(string productId);
    }
}
