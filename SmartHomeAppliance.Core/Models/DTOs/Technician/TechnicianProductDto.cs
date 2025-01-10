namespace SmartHomeAppliance.Core.Models.DTOs.Technician
{
    public class TechnicianProductDto
    {
        public string ProductName { get; set; } = null!;
        public string ProductCategory { get; set; } = null!;
        public string ProductImage { get; set; } = string.Empty;
        public string ProductDescription { get; set; } = null!;
    }
}
