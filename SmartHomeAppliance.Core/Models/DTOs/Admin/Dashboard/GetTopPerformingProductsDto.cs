namespace SmartHomeAppliance.Core.Models.DTOs.Admin.Dashboard
{
    public class GetTopPerformingProductsDto
    {
        public string ProductName { get; set; } = null!;
        public int SalesCount { get; set; }
        public decimal TotalRevenue { get; set; }
    }
}
