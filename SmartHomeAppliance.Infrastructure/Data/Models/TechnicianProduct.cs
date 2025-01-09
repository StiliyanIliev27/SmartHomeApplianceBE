using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartHomeAppliance.Infrastructure.Data.Models
{
    public class TechnicianProduct
    {
        [Required]
        [ForeignKey(nameof(TechnicianId))]
        public string TechnicianId { get; set; } = null!;
        public Technician Technician { get; set; } = null!;
        
        [Required]
        [ForeignKey(nameof(ProductId))]
        public string ProductId { get; set; } = null!;
        public Product Product { get; set; } = null!;

        [Required]
        public decimal InstallationPrice { get; set; }
    }
}
