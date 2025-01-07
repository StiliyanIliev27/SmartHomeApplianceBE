namespace SmartHomeAppliance.Core.Models.DTOs.Admin.Orders
{
    public class UpdateOrderStatusDto
    {
        public string OrderId { get; set; } = null!;
        public string OrderStatus { get; set; } = null!;
    }
}
