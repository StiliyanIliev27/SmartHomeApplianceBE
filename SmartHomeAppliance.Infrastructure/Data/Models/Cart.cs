using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartHomeAppliance.Infrastructure.Data.Models
{
    public class Cart
    {
        public Cart()
        {
            CartId = Guid.NewGuid();
        }

        [Key]
        public Guid CartId { get; set; }

        [ForeignKey(nameof(UserId))]
        [Required]
        public string UserId { get; set; } = null!;
        public ApplicationUser User { get; set; } = null!;

        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
