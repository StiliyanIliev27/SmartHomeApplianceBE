using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using SmartHomeAppliance.Infrastructure.Data.Enums;

namespace SmartHomeAppliance.Infrastructure.Data.Models
{
    public class Activity
    {
        public Activity()
        {
            Id = Guid.NewGuid().ToString();
        }
        public string Id { get; set; }

        [Required]
        public ActivityType Type { get; set; } 

        [Required]
        [StringLength(255)]
        public string Message { get; set; } = null!;


        [ForeignKey(nameof(UserId))]
        public string? UserId { get; set; }
        public ApplicationUser? User { get; set; }

        [ForeignKey(nameof(EntityId))]
        public string? EntityId { get; set; }

        [Required]
        public EntityType EntityType { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
