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
            var cartProducts = await repository.All<CartsProduct>()
                .Where(ci => ci.CartId == cart.Id.ToString())
                .Include(ci => ci.Product)
                .Include(ci => ci.Cart)
                .ToListAsync();

            if (!cartProducts.Any())
            {
                apiResponse.ErrorMessages.Add($"Cart is empty. Cannot create an order.");
                apiResponse.StatusCode = 400;
                apiResponse.IsSuccess = false;
                return apiResponse;
            }    

            // Calculate total price
            var totalPrice = cartProducts.Sum(ci => ci.Quantity * ci.Product.Price);

            // Create a new order
            var newOrder = new Order
            {       
                UserId = userId,
                OrderDate = DateTime.Now,
                TotalPrice = totalPrice,
                Status = Status.Pending,
            };

            foreach (var cartProduct in cartProducts)
            {
                var orderProduct = new OrdersProducts()
                {
                    OrderUserId = userId,
                    UserId = cartProduct.Cart.UserId,
                    ProductId = cartProduct.ProductId,
                    Price = cartProduct.Price,
                    Quantity = cartProduct.Quantity,
                    OrderId = newOrder.OrderId.ToString()
                };
                await repository.AddAsync(orderProduct);
            }

            // Add the order to the repository
            await repository.AddAsync(newOrder);

            // Remove cart items since they are now part of the order
            foreach(var cartProduct in cartProducts)
            {
                repository.Delete(cartProduct);
            }
            // Save changes
            await repository.SaveChangesAsync();

            apiResponse.Result = newOrder;
            apiResponse.IsSuccess = true;
            apiResponse.StatusCode = 201;
            return apiResponse;
        }

        public async Task<Order?> GetOrderByIdAsync(string orderId)
        {
            return await repository.GetByIdAsync<Order>(orderId);
        }

        public async Task UpdateOrderStatusAsync(string orderId, Status status)
        {
            var order = await repository.All<Order>().Where(o => o.OrderId == orderId).FirstOrDefaultAsync();
            if (order == null) throw new KeyNotFoundException("Order not found");

            order.Status = status;
            await repository.UpdateAsync(order);
            await repository.SaveChangesAsync();
        }
    }
}
