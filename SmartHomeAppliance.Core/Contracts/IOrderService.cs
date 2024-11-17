﻿using SmartHomeAppliance.Core.Models.Responses;
using SmartHomeAppliance.Infrastructure.Data.Enums;
using SmartHomeAppliance.Infrastructure.Data.Models;

namespace SmartHomeAppliance.Core.Contracts
{
    public interface IOrderService
    {
        Task<ApiResponse> CreateOrderFromCartAsync(string userId);
        Task<Order?> GetOrderByIdAsync(Guid orderId);
        Task UpdateOrderStatusAsync(Guid orderId, Status status);
    }
}
