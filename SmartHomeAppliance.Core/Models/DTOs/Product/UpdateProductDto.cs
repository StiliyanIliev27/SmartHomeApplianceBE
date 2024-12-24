using System.ComponentModel.DataAnnotations;

namespace SmartHomeAppliance.Core.Models.DTOs.Product
{
    public class UpdateProductDto
    {
        [Required]  
        public string ProductId { get; set; } = null!;

        [Required]
        public string Name { get; set; } = null!;

        [Required]
        public string Description { get; set; } = null!;

        [Required]
        public decimal Price { get; set; }

        [Required]
        public string Category { get; set; } = null!;

        [Required]
        public string ImageUrl { get; set; } = null!;

        [Required]
        public int StockQuantity { get; set; }
    }
}
