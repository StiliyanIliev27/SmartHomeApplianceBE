namespace SmartHomeAppliance.Core.Models.DTOs.Technician
{
    public class GetAllTechniciansByProductDto
    {
        public string FullName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string ProfileImage { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = null!;    
        public string City { get; set; } = null!;
        public string Lat { get; set; } = null!;
        public string Long { get; set; } = null!;
        public decimal InstallationPrice { get; set; }
        public TechnicianProductDto? Product { get; set; } 
    }
}
