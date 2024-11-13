using System.ComponentModel.DataAnnotations;

namespace SmartHomeAppliance.Core.Models.DTOs
{
    public class LoginDTO
    {
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; } = null!;

        [Required]
        public string Password { get; set; } = null!;
    }
}
