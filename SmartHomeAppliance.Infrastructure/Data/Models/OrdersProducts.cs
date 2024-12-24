using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartHomeAppliance.Infrastructure.Data.Models
{
    public class OrdersProducts
    {
        public string OrderId { get; set; } = null!;
        public string UserId { get; set; } = null!; // Add this to match the composite key
        public string ProductId { get; set; } = null!;

        public int Quantity { get; set; }
        public decimal Price { get; set; }

        // Navigation properties
        public Order? Order { get; set; }
        public Product? Product { get; set; }
        public ApplicationUser? User { get; set; }

        // Foreign keys
        [ForeignKey("OrderId, UserId")]
        public string OrderUserId { get; set; } = null!;
    }
}
