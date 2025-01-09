using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartHomeAppliance.Infrastructure.Data.Models;

namespace SmartHomeAppliance.Infrastructure.Data.Configurations
{
    internal class TechniciansProductsConfiguration : IEntityTypeConfiguration<TechnicianProduct>
    {

        public void Configure(EntityTypeBuilder<TechnicianProduct> builder)
        {
            builder.HasKey(tp => new { tp.ProductId, tp.TechnicianId });
        }
    }
}
