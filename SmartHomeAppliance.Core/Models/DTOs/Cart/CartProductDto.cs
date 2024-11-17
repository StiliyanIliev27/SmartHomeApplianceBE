using SmartHomeAppliance.Infrastructure.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace SmartHomeAppliance.Core.Models.DTOs.Cart
{
    public class CartProductDto
    {
        public string Id { get; set; } = null!;

        public string ProductId { get; set; } = null!;
       
        public string ProductName { get; set; } = null!;

        public decimal Price { get; set; }

        public string Category { get; set; } = null!;

        public string ImageUrl { get; set; } = null!;

        public int Quantity { get; set; }
    }
}
