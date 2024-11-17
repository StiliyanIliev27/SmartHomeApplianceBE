namespace SmartHomeAppliance.Core.Models.DTOs.Order
{
    public class OrderRequestDto
    {
        public string UserId { get; set; } = null!;
        public string ProductId { get; set; } = null!;
        public int Quantity { get; set; }   
    }
}
