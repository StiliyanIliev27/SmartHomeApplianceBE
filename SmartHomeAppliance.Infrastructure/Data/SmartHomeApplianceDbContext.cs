using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SmartHomeAppliance.Infrastructure.Data.Configurations;
using SmartHomeAppliance.Infrastructure.Data.Models;

namespace SmartHomeAppliance.Infrastructure.Data
{
    public class SmartHomeApplianceDbContext : IdentityDbContext<ApplicationUser>
    {
        public SmartHomeApplianceDbContext(DbContextOptions<SmartHomeApplianceDbContext> options) : base(options) { }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new RolesConfiguration());
            builder.ApplyConfiguration(new UsersConfiguration());
            builder.ApplyConfiguration(new UsersRolesConfiguration());

            base.OnModelCreating(builder);
        }
    }
}
