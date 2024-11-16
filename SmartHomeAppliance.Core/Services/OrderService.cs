using Microsoft.EntityFrameworkCore;
using SmartHomeAppliance.Core.Contracts;
using SmartHomeAppliance.Infrastructure.Common;
using SmartHomeAppliance.Infrastructure.Data.Enums;
using SmartHomeAppliance.Infrastructure.Data.Models;

namespace SmartHomeAppliance.Core.Services
{
    public class OrderService : IOrderService
    {
        private readonly IRepository repository;
        public OrderService(IRepository repository)
        {
            this.repository = repository;
        }
        public async Task<Order> CreateOrderAsync(string userId, Guid productId, int quantity)
        {
            var product = await repository.GetByIdAsync<Product>(productId);
            if (product == null || product.StockQuantity < quantity)
            {
                throw new InvalidOperationException("Product not available or insufficient stock.");
            }

            var totalPrice = product.Price * quantity;
            var order = new Order
            {
                UserId = userId,
                ProductId = product.Id.ToString(),
                Quantity = quantity,
                TotalPrice = totalPrice,
                OrderDate = DateTime.UtcNow
            };

            product.StockQuantity -= quantity; // Decrement stock
            await repository.UpdateAsync(product);
            await repository.AddAsync(order);
            await repository.SaveChangesAsync();
            return order;
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
