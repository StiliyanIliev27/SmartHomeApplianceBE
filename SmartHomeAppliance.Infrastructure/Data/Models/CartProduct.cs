using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartHomeAppliance.Infrastructure.Data.Models
{
    public class CartProduct
    {
        [ForeignKey(nameof(CartId))]
        [Required]
        public Guid CartId { get; set; }

        public Cart Cart { get; set; } = null!;

        [ForeignKey(nameof(ProductId))]
        [Required]
        public Guid ProductId { get; set; }

        public Product Product { get; set; } = null!;

        [Required]
        public int Quantity { get; set; }

        [Required]
        public decimal Price { get; set; }
    }
}
