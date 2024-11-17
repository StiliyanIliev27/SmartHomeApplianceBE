using Microsoft.EntityFrameworkCore;
using SmartHomeAppliance.Core.Contracts;
using SmartHomeAppliance.Core.Models.Responses;
using SmartHomeAppliance.Infrastructure.Common;
using SmartHomeAppliance.Infrastructure.Data.Enums;
using SmartHomeAppliance.Infrastructure.Data.Models;

namespace SmartHomeAppliance.Core.Services
{
    public class OrderService : IOrderService
    {
        private readonly IRepository repository;
        private ApiResponse apiResponse;
        public OrderService(IRepository repository)
        {
            this.repository = repository;
            apiResponse = new ApiResponse();
        }
        public async Task<ApiResponse> CreateOrderFromCartAsync(string userId)
        {
            var cart = await repository.All<Cart>().FirstOrDefaultAsync(c => c.UserId == userId);

            if(cart == null)
            {
                apiResponse.ErrorMessages.Add($"No cart found for the current user with id: {userId}");
                apiResponse.StatusCode = 404;
                apiResponse.IsSuccess = false;
                return apiResponse;
            }

            // Retrieve the cart for the user
            var cartItems = await repository.All<CartProduct>()
                .Where(ci => ci.CartId == cart.CartId)
                .Include(ci => ci.Product) // Include product details
                .ToListAsync();

            if (!cartItems.Any())
            {
                apiResponse.ErrorMessages.Add($"Cart is empty. Cannot create an order.");
                apiResponse.StatusCode = 400;
                apiResponse.IsSuccess = false;
                return apiResponse;
            }

            // Calculate total price
            var totalPrice = cartItems.Sum(ci => ci.Quantity * ci.Product.Price);

            // Create a new order
            var newOrder = new Order
            {
                UserId = userId.ToString(),
                OrderDate = DateTime.Now,
                TotalPrice = totalPrice,
                Status = Status.Pending,
                Products = cartItems.Select(ci => new OrderProduct
                {
                    ProductId = ci.ProductId,
                    Quantity = ci.Quantity,
                    Price = ci.Product.Price
                }).ToList()
            };

            // Add the order to the repository
            await repository.AddAsync(newOrder);

            // Remove cart items since they are now part of the order
            foreach(var product in cartItems)
            {
                repository.Delete(product);
            }

            // Save changes
            await repository.SaveChangesAsync();

            apiResponse.Result = newOrder;
            apiResponse.IsSuccess = true;
            apiResponse.StatusCode = 201;
            return apiResponse;
        }

        public async Task<Order?> GetOrderByIdAsync(Guid orderId)
        {
            return await repository.GetByIdAsync<Order>(orderId);
        }

        public async Task UpdateOrderStatusAsync(Guid orderId, Status status)
        {
            var order = await repository.All<Order>().Where(o => o.Id == orderId).FirstOrDefaultAsync();
            if (order == null) throw new KeyNotFoundException("Order not found");

            order.Status = status;
            await repository.UpdateAsync(order);
            await repository.SaveChangesAsync();
        }
    }
}
