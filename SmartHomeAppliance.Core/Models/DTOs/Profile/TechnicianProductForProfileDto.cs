namespace SmartHomeAppliance.Core.Models.DTOs.Profile
{
    public class TechnicianProductForProfileDto
    {
        public string ProductId { get; set; } = null!;
        public string ProductName { get; set; } = null!;
        public string ProductImage { get; set; } = null!;
        public decimal InstallationPrice { get; set; }
    }
}
