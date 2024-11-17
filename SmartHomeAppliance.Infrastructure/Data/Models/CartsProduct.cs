using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartHomeAppliance.Infrastructure.Data.Models
{
    public class CartsProduct
    {

        [ForeignKey(nameof(CartId))]
        [Required]
        public string CartId { get; set; } = null!;

        public Cart Cart { get; set; } = null!;

        [ForeignKey(nameof(ProductId))]
        [Required]
        public string ProductId { get; set; } = null!;

        public Product Product { get; set; } = null!;

        [Required]
        public int Quantity { get; set; }

        [Required]
        public decimal Price { get; set; }
    }
}
