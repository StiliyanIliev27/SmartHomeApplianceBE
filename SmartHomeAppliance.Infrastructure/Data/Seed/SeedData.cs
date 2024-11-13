using Microsoft.AspNetCore.Identity;
using SmartHomeAppliance.Infrastructure.Data.Models;

namespace SmartHomeAppliance.Infrastructure.Data.Seed
{
    public class SeedData
    {
        public ICollection<ApplicationUser> Users { get; set; } = new HashSet<ApplicationUser>();
        public ICollection<IdentityRole> Roles { get; set; } = new HashSet<IdentityRole>();
        public ICollection<IdentityUserRole<string>> UsersRoles { get; set; } = new HashSet<IdentityUserRole<string>>();
        public SeedData()
        {
            SeedAdminUser();
            SeedRoles();
            SeedUsersRoles();
        }
        private void SeedAdminUser()
        {
            var hasher = new PasswordHasher<ApplicationUser>();

            var adminUser = new ApplicationUser
            {
                Id = "27d78708-8671-4b05-bd5e-17aa91392224",
                Email = "admin@smarthomeapp.bg",
                EmailConfirmed = true,
                NormalizedEmail = "admin@smarthomeapp.bg".ToUpper(),
                FirstName = "Admin",
                LastName = "Adminov",
                ProfilePictureUrl = "https://plus.unsplash.com/premium_photo-1689530775582-83b8abdb5020?q=80&w=2670&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                PasswordHash = hasher.HashPassword(null!, "admin123")
            };

            Users.Add(adminUser);
        }
        private void SeedRoles()
        {
            //Add random GUID strings for the role ids
            var userRoleId = "4f8554d2-cfaa-44b5-90ce-e883c804ae90";
            var adminRoleId = "656a6079-ec9a-4a98-a484-2d1752156d60";

            //Create User and Admin roles

            // Seed the roles in the Database if they do not exist
            Roles.Add(new IdentityRole
            {
                Id = userRoleId,
                ConcurrencyStamp = userRoleId,
                Name = "User",
                NormalizedName = "USER",
            });
            Roles.Add(new IdentityRole
            {
                Id = adminRoleId,
                ConcurrencyStamp = adminRoleId,
                Name = "Admin",
                NormalizedName = "ADMIN",
            });

        }
        private void SeedUsersRoles()
        {
            UsersRoles.Add(new IdentityUserRole<string>
            {
                UserId = "27d78708-8671-4b05-bd5e-17aa91392224",
                RoleId = "656a6079-ec9a-4a98-a484-2d1752156d60"
            });
        }
    }
}
