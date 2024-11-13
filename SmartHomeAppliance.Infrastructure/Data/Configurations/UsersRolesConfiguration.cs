using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartHomeAppliance.Infrastructure.Data.Seed;

namespace SmartHomeAppliance.Infrastructure.Data.Configurations
{
    internal class UsersRolesConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(new SeedData().UsersRoles);
        }
    }
}
