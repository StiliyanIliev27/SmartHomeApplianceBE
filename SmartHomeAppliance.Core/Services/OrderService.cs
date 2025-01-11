using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SmartHomeAppliance.Core.Contracts;
using SmartHomeAppliance.Core.Extensions;
using SmartHomeAppliance.Core.Models.DTOs.Order;
using SmartHomeAppliance.Core.Models.Responses;
using SmartHomeAppliance.Infrastructure.Common;
using SmartHomeAppliance.Infrastructure.Data.Enums;
using SmartHomeAppliance.Infrastructure.Data.Models;
using static SmartHomeAppliance.Common.GlobalConstants.ActivityMessages;

namespace SmartHomeAppliance.Core.Services
{
    public class OrderService : IOrderService
    {
        private readonly IRepository repository;
        private ApiResponse apiResponse;
        private readonly UserManager<ApplicationUser> userManager;
        public OrderService(IRepository repository, UserManager<ApplicationUser> userManager)
        {
            this.repository = repository;
            apiResponse = new ApiResponse();
            this.userManager = userManager;
        }
        public async Task<ApiResponse> CreateOrderFromCartAsync(string userId, decimal promCodePerc = 0)
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
                PaymentStatus = PaymentStatus.Pending,
            };

            if (promCodePerc > 0)
            {
                newOrder.TotalPrice -= 100 * (promCodePerc / 100);
            }

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

                var product = await repository.GetByIdAsync<Product>(orderProduct.ProductId);
                if(product!.StockQuantity < 1)
                {
                    apiResponse.ErrorMessages.Add("Product is out of stock!");
                    apiResponse.StatusCode = 400;
                    apiResponse.IsSuccess = false;
                    return apiResponse;
                }

                product!.StockQuantity -= orderProduct.Quantity;

                await repository.UpdateAsync(product);
                await repository.AddAsync(orderProduct);
            }

            // Add the order to the repository
            await repository.AddAsync(newOrder);

            // Remove cart items since they are now part of the order
            foreach(var cartProduct in cartProducts)
            {
                repository.Delete(cartProduct);
            }

            var user = await repository.GetByIdAsync<ApplicationUser>(userId);

            var activity = ActivityExtensions.CreateActivity(
                type: ActivityType.OrderCreated,
                messageTemplate: OrderCreated,
                userId: newOrder.UserId,
                entityId: newOrder.OrderId,
                entityType: EntityType.Order,
                parameters: new[] {
                    ("orderId", newOrder.OrderId),
                    ("email", user!.Email!)
                }
            );

            await repository.AddAsync(activity);
            await repository.SaveChangesAsync();

            apiResponse.Result = newOrder;
            apiResponse.IsSuccess = true;
            apiResponse.StatusCode = 201;
            return apiResponse;
        }

        private async Task<bool> IsAdminAsync(string userId)
        {
            var user = await repository.GetByIdAsync<ApplicationUser>(userId);
            if (user is null)
                return false;

            return await userManager.IsInRoleAsync(user, "Admin");
        }

        public async Task<IEnumerable<GetMyOrdersDto>> GetMyOrdersAsync(string userId)
        {

            return await repository.AllReadOnly<Order>()
                .Where(o => o.UserId == userId)
                .Include(o => o.User)
                .Select(o => new GetMyOrdersDto()
                {
                    OrderId = o.OrderId,
                    Customer = o.User!.FirstName + " " + o.User.LastName,
                    CustomerProfilePicture = o.User.ProfilePictureUrl,
                    PaymentStatus = o.PaymentStatus.ToString(),
                    OrderStatus = o.OrderStatus.ToString(),
                    OrderDate = o.OrderDate.ToString("dd-MM-yyyy"),
                    Products = o.OrdersProducts
                        .Where(op => op.OrderId == o.OrderId).Select(op => new GetProductsNameDto()
                    {
                        ProductName = op.Product!.Name
                    }),
                    TotalPrice = o.TotalPrice
                })
                .ToListAsync();
        }

        public async Task<Order?> GetOrderByIdAsync(string orderId)
        {
            return await repository.AllReadOnly<Order>().Where(o => o.OrderId == orderId).FirstOrDefaultAsync();
        }

        public async Task UpdateOrderStatusAsync(string orderId, PaymentStatus status)
        {
            var order = await repository.All<Order>().Where(o => o.OrderId == orderId).FirstOrDefaultAsync();
            if (order == null) throw new KeyNotFoundException("Order not found");

            if(status == PaymentStatus.Cancelled || status == PaymentStatus.Failed)
            {
                order.OrderStatus = OrderStatus.Cancelled;
            }

            order.PaymentStatus = status;

            var user = await repository.GetByIdAsync<ApplicationUser>(order.UserId);

            var activity = ActivityExtensions.CreateActivity(
                type: ActivityType.OrderUpdated,
                messageTemplate: OrderUpdated,
                userId: order.UserId,
                entityId: order.OrderId,
                entityType: EntityType.Order,
                parameters: new[] {
                    ("orderId", order.OrderId),
                    ("email", user!.Email!)
                }
            );

            await repository.AddAsync(activity);
            await repository.UpdateAsync(order);
            await repository.SaveChangesAsync();
        }
    }
}
