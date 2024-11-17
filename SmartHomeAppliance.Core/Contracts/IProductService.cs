using SmartHomeAppliance.Core.Models.DTOs.Product;
using SmartHomeAppliance.Core.Models.Responses;
using SmartHomeAppliance.Infrastructure.Data.Models;

namespace SmartHomeAppliance.Core.Contracts
{
    public interface IProductService
    {
        Task<Product> GetProductByIdAsync(Guid productId);
        Task<ApiResponse> AllProductsByFilterAsync(string? category, 
            decimal? minPrice, decimal? maxPrice, 
            string? searchTerm, 
            int page = 1, int pageSize = 10);
        Task<ApiResponse> CreateProductAsync(CreateProductDto productDto, string creatorId);
        Task<ApiResponse> UpdateProductAsync(UpdateProductDto updatedProductDto);
        Task<ApiResponse> DeleteProductAsync(string productId);
    }
}
