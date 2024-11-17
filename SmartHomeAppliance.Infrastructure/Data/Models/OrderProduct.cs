using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartHomeAppliance.Infrastructure.Data.Models
{
    public class OrderProduct
    {
        public OrderProduct()
        {
            Id = Guid.NewGuid();
        }

        [Key]
        public Guid Id { get; set; }

        [ForeignKey(nameof(OrderId))]
        [Required]
        public Guid OrderId { get; set; }

        [ForeignKey(nameof(ProductId))]
        [Required]
        public Guid ProductId { get; set; }
        public Product Product { get; set; } = null!; // Navigation property

        [Required]
        public int Quantity { get; set; }

        [Required]
        public decimal Price { get; set; }
    }
}
