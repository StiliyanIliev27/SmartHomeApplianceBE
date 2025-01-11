using System.Diagnostics.CodeAnalysis;

namespace SmartHomeAppliance.Core.Models.DTOs.Payment
{
    public class DiscountCouponDto
    {
        [AllowNull]
        public decimal DiscountPercentage { get; set; }
        public string? DiscountCode { get; set; }
    }
}
