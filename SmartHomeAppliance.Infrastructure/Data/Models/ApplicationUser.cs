using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace SmartHomeAppliance.Infrastructure.Data.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        public string FirstName { get; set; } = null!;

        [Required]
        public string LastName { get; set; } = null!;
        public string ProfilePictureUrl { get; set; } = string.Empty;
        public DateTime? LastLoginDate { get; set; }
    }
}
