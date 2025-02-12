﻿using SmartHomeAppliance.Core.Models.DTOs.Order;
using SmartHomeAppliance.Core.Models.Responses;
using SmartHomeAppliance.Infrastructure.Data.Enums;
using SmartHomeAppliance.Infrastructure.Data.Models;

namespace SmartHomeAppliance.Core.Contracts
{
    public interface IOrderService
    {
        Task<ApiResponse> CreateOrderFromCartAsync(string userId, decimal promCodePerc);
        Task<Order?> GetOrderByIdAsync(string orderId);
        Task<IEnumerable<GetMyOrdersDto>> GetMyOrdersAsync(string userId);
        Task UpdateOrderStatusAsync(string orderId, PaymentStatus status);
    }
}
