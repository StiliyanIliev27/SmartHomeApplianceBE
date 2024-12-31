using Microsoft.EntityFrameworkCore;
using SmartHomeAppliance.Core.Contracts;
using SmartHomeAppliance.Core.Models.DTOs.Cart;
using SmartHomeAppliance.Core.Models.Responses;
using SmartHomeAppliance.Infrastructure.Common;
using SmartHomeAppliance.Infrastructure.Data.Models;

namespace SmartHomeAppliance.Core.Services
{
    public class CartService : ICartService
    {
        private readonly IRepository repository;
        private readonly IProductService productService;
        private ApiResponse apiResponse;
        public CartService(IRepository repository, IProductService productService)
        {
            this.repository = repository;
            this.productService = productService;
            apiResponse = new ApiResponse();
        }

        public async Task<ApiResponse> AddToCartAsync(string userId, ProductToCartDto addProductToCartDto)
        {
            var product = await productService.GetProductByIdAsync(addProductToCartDto.ProductId);
            if (product == null || addProductToCartDto.Quantity > product.StockQuantity)
            {
                apiResponse.StatusCode = 400;
                apiResponse.ErrorMessages.Add("Product not available in the desired quantity.");
                apiResponse.IsSuccess = false;
                return apiResponse;
            }

            var cart = await GetCartAsync(userId);
            if(cart is null)
            {
                cart = new Cart { UserId = userId };
                await repository.AddAsync(cart);
            }
            
            var existingCartProduct = await repository.AllReadOnly<CartsProduct>()
                .Where(cp => cp.ProductId == addProductToCartDto.ProductId && cp.CartId == cart.Id.ToString()).FirstOrDefaultAsync();

            if (existingCartProduct != null)
            {
                existingCartProduct.Quantity += addProductToCartDto.Quantity;
                apiResponse.StatusCode = 200;
                apiResponse.Message = $"User with id: {userId} added {addProductToCartDto.Quantity} " +
                    $"to the existing product with id: {existingCartProduct.ProductId}";
                apiResponse.Result = existingCartProduct;
                apiResponse.IsSuccess = true;
                await repository.UpdateAsync(existingCartProduct);
                await repository.SaveChangesAsync();
            }
            else
            {
                var cartProduct = new CartsProduct
                {
                    CartId = cart.Id.ToString(),
                    ProductId = addProductToCartDto.ProductId,
                    Quantity = addProductToCartDto.Quantity,
                    Price = product.Price
                };
                await repository.AddAsync(cartProduct);
                await repository.SaveChangesAsync();
                apiResponse.StatusCode = 200;
                apiResponse.Message = $"New product was successfully added to the cart with id: {cartProduct.CartId}.";
                apiResponse.Result = cartProduct;
                apiResponse.IsSuccess = true;
            }

            return apiResponse;
        }

        public async Task<ApiResponse> RemoveCartAsync(string userId)
        {
            var cart = await repository.All<Cart>().FirstOrDefaultAsync(c => c.UserId == userId);
            if (cart is null)
            {
                apiResponse.StatusCode = 404;
                apiResponse.ErrorMessages.Add("Cart is not available.");
                apiResponse.IsSuccess = false;
                return apiResponse;
            }

            var cartProducts = await repository.All<CartsProduct>()
                .Where(cp => cp.CartId == cart.Id.ToString()).ToListAsync();
           
            foreach(var cartProduct in cartProducts)
                repository.Delete(cartProduct);

            repository.Delete(cart);
            await repository.SaveChangesAsync();

            apiResponse.StatusCode = 200;
            apiResponse.Message = $"Cart with id: {cart.Id} successfully removed.";
            apiResponse.IsSuccess = true;
            return apiResponse;
        }

        public async Task<Cart?> GetCartAsync(string userId)
        {
            return await repository.AllReadOnly<Cart>().FirstOrDefaultAsync(c => c.UserId == userId);
        }
        public async Task<ApiResponse> GetCartByUserIdAsync(string userId, decimal promCodePerc = 0)
        {
            var cart = await repository.AllReadOnly<Cart>()
                .Include(c => c.User)
                .FirstOrDefaultAsync(c => c.UserId == userId);         
            if(cart is null)
            {
                apiResponse.ErrorMessages.Add($"Cart for user with id: {userId} was not found.");
                apiResponse.StatusCode = 404;
                apiResponse.IsSuccess = false;
                return apiResponse;
            }

            var cartProducts = await repository.AllReadOnly<CartsProduct>()
                .Where(cp => cp.CartId == cart.Id.ToString())
                .Include(cp => cp.Product)
                .ToListAsync();

            var cartProductsDto = new List<CartProductDto>();
            decimal totalPrice = 0;
            foreach(var cartProduct in cartProducts)
            {
                cartProductsDto.Add(new CartProductDto()
                {
                    ProductId = cartProduct.ProductId.ToString(),
                    Price = cartProduct.Price,
                    ProductName = cartProduct.Product.Name,
                    Category = cartProduct.Product.Category.ToString(),
                    ImageUrl = cartProduct.Product.ImageUrl,
                    Quantity = cartProduct.Quantity,
                });

                totalPrice += cartProduct.Price * cartProduct.Quantity;
            }

            var responseObject = new GetCartModelDto()
            {
                UserFullName = $"{cart.User.FirstName} {cart.User.LastName}",
                UserEmail = cart.User.Email!,
                CartProducts = cartProductsDto,
                TotalPrice = totalPrice
            };

            if (promCodePerc > 0)
            {
                responseObject.TotalPrice -= 100 * (promCodePerc / 100);
            }

            apiResponse.StatusCode = 200;
            apiResponse.Result = responseObject;
            apiResponse.IsSuccess = true;
            apiResponse.Message = $"Cart with an id: {cart.Id} for user with id: {userId}";
            return apiResponse;
        }

        public async Task<ApiResponse> RemoveCartProductAsync(RemoveProductDto removeProductDto)
        {
            var cartProduct = await repository.All<CartsProduct>().FirstOrDefaultAsync(c => c.ProductId.ToString() == removeProductDto.ProductId);
            if (cartProduct is null)
            {
                apiResponse.ErrorMessages.Add("No product was not found for the particular cart.");
                apiResponse.StatusCode = 404;
                apiResponse.IsSuccess = false;
                return apiResponse;
            }

            repository.Delete(cartProduct);
            await repository.SaveChangesAsync();

            apiResponse.Message = $"Successfully removed product with id: {removeProductDto.ProductId} from the cart with id: {cartProduct.CartId}";
            apiResponse.IsSuccess = true;
            apiResponse.StatusCode = 200;
            return apiResponse;
        }

        public async Task<ApiResponse> UpdateCartProductQuantityAsync(string userId, ProductToCartDto updateProductToCarDto)
        {
            var cart = await repository.All<Cart>().FirstOrDefaultAsync(c => c.UserId == userId);
            if(cart is null)
            {
                apiResponse.ErrorMessages.Add("No cart was not found for the particular user.");
                apiResponse.StatusCode = 404;
                apiResponse.IsSuccess = false;
                return apiResponse;
            }
          
            var cartProduct = await repository.All<CartsProduct>()
                .FirstOrDefaultAsync(c => c.ProductId == updateProductToCarDto.ProductId && c.CartId == cart.Id.ToString());
            if (cartProduct is null)
            {
                apiResponse.ErrorMessages.Add("No product was not found for the particular cart.");
                apiResponse.StatusCode = 404;
                apiResponse.IsSuccess = false;
                return apiResponse;
            }

            cartProduct.Quantity = updateProductToCarDto.Quantity;
            await repository.UpdateAsync(cartProduct);
            await repository.SaveChangesAsync();

            apiResponse.StatusCode = 200;
            apiResponse.Message = $"Product with id: {updateProductToCarDto.ProductId} has been " +
                $"successfully updated with new quantity of {updateProductToCarDto.Quantity}.";
            apiResponse.IsSuccess = true;
            return apiResponse;
        }

        public async Task<IEnumerable<CartsProduct>> GetCartProductsAsync(string cartId)
        {
            return await repository.AllReadOnly<CartsProduct>()
                .Where(cp => cp.CartId == cartId)
                .Include(cp => cp.Product)
                .ToListAsync();
        }
    }
}
