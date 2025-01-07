namespace SmartHomeAppliance.Core.Models.DTOs.Admin.Orders
{
    public class GetProductDetailsDto
    {
        public int Quantity { get; set; }
        public decimal PricePerProduct { get; set; }
        public string ProductName { get; set; } = null!;
        public string ProductCategory { get; set; } = null!;
        public string ProductImage { get; set; } = string.Empty;
    }
}
