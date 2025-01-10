using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartHomeAppliance.Infrastructure.Data.Models
{
    public class Technician
    {
        public Technician()
        {
            Id = Guid.NewGuid().ToString();
        }

        [Required]
        public string Id { get; set; }

        [Required]
        public string PhoneNumber { get; set; } = string.Empty;

        [Required]
        public string City { get; set; } = null!;

        [Required]
        public string Long { get; set; } = null!;

        [Required]
        public string Lat { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(UserId))]
        public string UserId { get; set; } = null!;
        public ApplicationUser? User { get; set; }
    }
}
