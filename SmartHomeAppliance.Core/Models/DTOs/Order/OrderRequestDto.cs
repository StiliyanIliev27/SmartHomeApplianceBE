namespace SmartHomeAppliance.Core.Models.DTOs.Order
{
    public class OrderRequestDto
    {
        public string UserId { get; set; } = null!;
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }   
    }
}
