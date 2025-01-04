namespace SmartHomeAppliance.Core.Models.DTOs.Admin.Dashboard
{
    public class GetInventoryStatusDto
    {
        public int LowStockItems { get; set; }
        public int OutOfStockItems { get; set; }
    }
}
