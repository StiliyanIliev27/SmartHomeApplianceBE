using SmartHomeAppliance.Infrastructure.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartHomeAppliance.Infrastructure.Data.Models
{
    public class Order
    {
        public Order()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }

        [Required]
        [ForeignKey(nameof(UserId))]
        public string UserId { get; set; } = null!;
        public ApplicationUser? User { get; set; }

        [Required]
        [ForeignKey(nameof(ProductId))]
        public string ProductId { get; set; } = null!;
        public Product? Product { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public decimal TotalPrice { get; set; }

        [Required]
        public Status Status { get; set; } = Status.Pending;

        [Required]
        public DateTime OrderDate { get; set; }
    }
}
