using SmartHomeAppliance.Infrastructure.Data.Enums;
using SmartHomeAppliance.Infrastructure.Data.Models;

namespace SmartHomeAppliance.Core.Contracts
{
    public interface IOrderService
    {
        Task<Order> CreateOrderAsync(string userId, Guid productId, int quantity);
        Task<Order?> GetOrderByIdAsync(Guid orderId);
        Task UpdateOrderStatusAsync(Guid orderId, Status status);
    }
}
