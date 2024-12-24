using Microsoft.EntityFrameworkCore;
using SmartHomeAppliance.Infrastructure.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static SmartHomeAppliance.Common.ValidationConstants.ValidationConstants.Product;

namespace SmartHomeAppliance.Infrastructure.Data.Models
{
    public class Product
    {
        public Product()
        {
            Id = Guid.NewGuid().ToString();
        }
        public string Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        [Required]
        public string Description { get; set; } = null!;

        [Required]
        public decimal Price { get; set; }

        [Required]
        public Category Category { get; set; }

        [Required]
        public string ImageUrl { get; set; } = null!;

        [Required]
        [Length(ProductMinRatingValue, ProductMaxRatingValue, ErrorMessage = ProductRatingErrorMessage)]
        public int Rating { get; set; }

        [Required]
        [ForeignKey(nameof(CreatorId))]
        public string CreatorId { get; set; } = null!;
        public ApplicationUser? Creator { get; set; }

        [Required]
        public DateTime DateCreated { get; set; }

        [Required]
        public int StockQuantity { get; set; }
        public List<OrdersProducts> OrdersProducts { get; set; } = new List<OrdersProducts>();
    }
}
