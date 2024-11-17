using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartHomeAppliance.Infrastructure.Data.Models;

namespace SmartHomeAppliance.Infrastructure.Data.Configurations
{
    internal class CartProductConfiguration : IEntityTypeConfiguration<CartsProduct>
    {
        public void Configure(EntityTypeBuilder<CartsProduct> builder)
        {
            builder
                .HasKey(ci => new { ci.CartId, ci.ProductId });
        }
    }
}
