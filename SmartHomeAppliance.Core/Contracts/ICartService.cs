using SmartHomeAppliance.Core.Models.DTOs.Cart;
using SmartHomeAppliance.Core.Models.Responses;
using SmartHomeAppliance.Infrastructure.Data.Models;

namespace SmartHomeAppliance.Core.Contracts
{
    public interface ICartService
    {
        Task<ApiResponse> GetCartByUserIdAsync(string userId);
        Task<Cart?> GetCartAsync(string userId);
        Task<ApiResponse> AddToCartAsync(string userId, ProductToCartDto addProductToCarDto);
        Task<ApiResponse> RemoveCartProductAsync(RemoveProductDto removeProductDto);
        Task<ApiResponse> UpdateCartProductQuantityAsync(string userId, ProductToCartDto updateProductToCarDto);
        Task<ApiResponse> RemoveCartAsync(string userId);
    }
}
