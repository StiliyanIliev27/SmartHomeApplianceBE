namespace SmartHomeAppliance.Core.Models.DTOs.Admin.Orders
{
    public class GetOrdersDto
    {
        public string OrderId { get; set; } = null!;
        public string CustomerFullName { get; set; } = null!;
        public string CustomerEmail { get; set; } = null!;
        public string CustomerProfilePicture { get; set; } = null!;
        public decimal TotalPrice { get; set; }
        public string PaymentStatus { get; set; } = null!;
        public string OrderStatus { get; set; } = null!;
        public string OrderDate { get; set; } = null!;
    }
}
