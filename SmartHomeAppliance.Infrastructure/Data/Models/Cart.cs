using System.ComponentModel.DataAnnotations;

namespace SmartHomeAppliance.Infrastructure.Data.Models
{
    public class Cart
    {
        public Cart()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }

        [Required]
        public string UserId { get; set; } = null!;

        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
