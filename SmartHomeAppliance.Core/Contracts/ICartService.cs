using SmartHomeAppliance.Core.Models.DTOs.Cart;
using SmartHomeAppliance.Core.Models.Responses;

namespace SmartHomeAppliance.Core.Contracts
{
    public interface ICartService
    {
        Task<ApiResponse> GetCartByUserIdAsync(string userId);
        Task<ApiResponse> AddToCartAsync(string userId, ProductToCartDto addProductToCarDto);
        Task<ApiResponse> RemoveCartProductAsync(string cartProductId);
        Task<ApiResponse> UpdateCartProductQuantityAsync(string userId, ProductToCartDto updateProductToCarDto);
        Task<ApiResponse> RemoveCartAsync(string userId);
    }
}
