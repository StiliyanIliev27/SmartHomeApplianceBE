namespace SmartHomeAppliance.Core.Models.DTOs.Admin.Products
{
    public class GetAllProductsDto
    {
        public string? Id { get; set; }
        public string ProductName { get; set; } = null!;
        public string Category { get; set; } = null!;
        public int StockQuantity { get; set; }
        public string Description { get; set; } = string.Empty;
        public string? ProductImage { get; set; }
        public decimal Price { get; set; }
    }
}
