namespace SmartHomeAppliance.Core.Models.Responses
{
    public class UserResponseDto
    {
        public string Id { get; set; } = null!;

        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public string Email { get; set; } = null!;

        public string ProfilePictureUrl { get; set; } = string.Empty;

        public bool IsAdmin { get; set; }
    }
}
