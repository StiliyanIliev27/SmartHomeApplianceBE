using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartHomeAppliance.Infrastructure.Data.Models;

namespace SmartHomeAppliance.Infrastructure.Data.Configurations
{
    internal class OrderProductConfiguration : IEntityTypeConfiguration<OrderProduct>
    {
        public void Configure(EntityTypeBuilder<OrderProduct> builder)
        {
            builder
                .HasKey(op => new { op.ProductId, op.OrderId, op.Id });
        }
    }
}
