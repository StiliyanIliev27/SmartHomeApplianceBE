using SmartHomeAppliance.Core.Models.DTOs.Product;
using SmartHomeAppliance.Core.Models.Responses;

namespace SmartHomeAppliance.Core.Contracts
{
    public interface IProductService
    {
        Task<ApiResponse> AllProductsAsync();
        Task<ApiResponse> CreateProductAsync(CreateProductDto productDto, string creatorId);
        Task<ApiResponse> UpdateProductAsync(UpdateProductDto updatedProductDto);
        Task<ApiResponse> DeleteProductAsync(string productId);
    }
}
