using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartHomeAppliance.Infrastructure.Data.Models;
using SmartHomeAppliance.Infrastructure.Data.Seed;

namespace SmartHomeAppliance.Infrastructure.Data.Configurations
{
    internal class UsersConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            var data = new SeedData();
            builder.HasData(data.Users);
        }
    }
}
