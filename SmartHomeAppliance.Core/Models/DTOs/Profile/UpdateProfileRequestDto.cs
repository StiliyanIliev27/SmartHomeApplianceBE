using Microsoft.AspNetCore.Http;

namespace SmartHomeAppliance.Core.Models.DTOs.Profile
{
    public class UpdateProfileRequestDto
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public IFormFile? ProfileImage { get; set; }
        public string? PhoneNumber { get; set; }
        public string? City { get; set; }
        public string? Lat { get; set; }
        public string? Long { get; set; }
    }
}
