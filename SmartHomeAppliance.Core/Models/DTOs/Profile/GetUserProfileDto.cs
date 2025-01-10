namespace SmartHomeAppliance.Core.Models.DTOs.Profile
{
    public class GetUserProfileDto
    {
        public GetUserProfileDto()
        {
            Products = new HashSet<TechnicianProductForProfileDto>();
        }
        public string FullName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string ProfileImage { get; set; } = string.Empty;
        public string CreatedAt { get; set; } = null!;

        //If the user is a technician
        public string? PhoneNumber { get; set; }
        public string? City { get; set; }
        public IEnumerable<TechnicianProductForProfileDto> Products { get; set; }
    }
}
