namespace SmartHomeAppliance.Core.Models.DTOs.Admin.Users
{
    public class AssignRoleRequestDto
    {
        public string CurrentUserId { get; set; } = null!;
        public string UserId { get; set; } = null!;
        public string Role { get; set; } = null!;
    }
}
