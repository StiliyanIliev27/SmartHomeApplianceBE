using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartHomeAppliance.Infrastructure.Data.Models
{
    public class Review
    {
        public Review()
        {
            Id = Guid.NewGuid();
        }

        [Required]
        public Guid Id { get; set; }

        [Required]
        [ForeignKey(nameof(ProductId))]
        public string ProductId { get; set; } = null!;
        public Product? Product { get; set; }

        [Required]
        [ForeignKey(nameof(ProductId))]
        public string UserId { get; set; } = null!;
        public ApplicationUser? User { get; set; }

        [Required]
        public int Rating {  get; set; }
        public string Comment { get; set; } = string.Empty;

        [Required]
        public DateTime ReviewDate { get; set; }

    }
}
