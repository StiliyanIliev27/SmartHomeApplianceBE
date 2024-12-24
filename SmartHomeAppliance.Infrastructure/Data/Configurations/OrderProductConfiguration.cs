using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartHomeAppliance.Infrastructure.Data.Models;
using System.Reflection.Emit;

namespace SmartHomeAppliance.Infrastructure.Data.Configurations
{
    internal class OrderProductConfiguration : IEntityTypeConfiguration<OrdersProducts>
    {
        public void Configure(EntityTypeBuilder<OrdersProducts> builder)
        {
            builder.HasKey(op => new { op.OrderId, op.ProductId, op.UserId });

            builder.HasOne(op => op.Order)
            .WithMany(o => o.OrdersProducts)  // One Order can have many OrdersProducts
            .HasForeignKey(op => new { op.OrderId, op.UserId })  // Composite foreign key
            .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(op => op.Product)
            .WithMany(p => p.OrdersProducts)  // One Product can have many OrdersProducts
            .HasForeignKey(op => op.ProductId)
            .OnDelete(DeleteBehavior.Cascade); // Cascade delete for Product -> OrdersProducts

            builder.HasOne(op => op.User)
            .WithMany()  // One User can have many OrdersProducts (via Orders)
            .HasForeignKey(op => op.UserId)
            .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
