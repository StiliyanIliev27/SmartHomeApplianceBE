namespace SmartHomeAppliance.Core.Models.DTOs.Admin.Users
{
    public class GetUsersDataDto
    {
        public string Id { get; set; } = null!;
        public string ProfilePicture { get; set; } = string.Empty;
        public string FullName { get; set; } = null!;
        public string Email { get; set; } = null!;  
        public string Role { get; set; } = null!;
        public bool IsActive { get; set; }
        public string LastLoginDate { get; set; } = string.Empty;
    }
}
