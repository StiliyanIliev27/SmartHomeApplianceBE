namespace SmartHomeAppliance.Core.Models.DTOs.Order
{
    public class GetMyOrdersDto
    {
        public GetMyOrdersDto()
        {
            Products = new HashSet<GetProductsNameDto>();
        }
        public string OrderId { get; set; } = null!;
        public string Customer { get; set; } = null!;
        public string CustomerProfilePicture { get; set; } = string.Empty;
        public string OrderDate { get; set; } = null!;
        public string PaymentStatus { get; set; } = null!;
        public string OrderStatus { get; set; } = null!;
        public decimal TotalPrice { get; set; }
        public IEnumerable<GetProductsNameDto> Products { get; set; }
    }
}
