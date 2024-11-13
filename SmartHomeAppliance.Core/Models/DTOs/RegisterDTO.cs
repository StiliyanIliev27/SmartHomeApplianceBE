using System.ComponentModel.DataAnnotations;

namespace SmartHomeAppliance.Core.Models.DTOs
{
    public class RegisterDTO
    {
        [Required]
        [StringLength(30, MinimumLength = 3)]
        public string FirstName { get; set; } = null!;

        [Required]
        [StringLength(20, MinimumLength = 3)]
        public string LastName { get; set; } = null!;

        [Required]
        public string Password { get; set; } = null!;

        [Required]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; } = null!;
        public string ProfilePictureUrl { get; set; } = string.Empty;
    }
}
