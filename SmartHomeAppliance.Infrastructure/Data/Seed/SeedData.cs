using Microsoft.AspNetCore.Identity;
using SmartHomeAppliance.Infrastructure.Data.Enums;
using SmartHomeAppliance.Infrastructure.Data.Models;

namespace SmartHomeAppliance.Infrastructure.Data.Seed
{
    public class SeedData
    {
        public ICollection<ApplicationUser> Users { get; set; } = new HashSet<ApplicationUser>();
        public ICollection<IdentityRole> Roles { get; set; } = new HashSet<IdentityRole>();
        public ICollection<IdentityUserRole<string>> UsersRoles { get; set; } = new HashSet<IdentityUserRole<string>>();
        public List<Product> Products { get; set; } = new List<Product>();
        public SeedData()
        {
            SeedAdminUser();
            SeedRoles();
            SeedUsersRoles();
            SeedProducts();
        }

        private void SeedProducts()
        {
            var products = new HashSet<Product>
            {
                new Product
                {
                    Name = "Smart Doorbell Camera",
                    Description = "A high-definition doorbell camera with night vision and motion detection.",
                    Price = 129.99m,
                    Category = Category.SecurityAndSurveillance,
                    ImageUrl = "https://via.placeholder.com/400x300.png?text=Smart+Doorbell+Camera",
                    StockQuantity = 50,
                    CreatorId = "27d78708-8671-4b05-bd5e-17aa91392224",
                    DateCreated = DateTime.UtcNow
                },
                new Product
                {
                    Name = "Smart LED Light Bulbs (4-Pack)",
                    Description = "Color-changing LED light bulbs controllable via app or voice commands.",
                    Price = 39.99m,
                    Category = Category.LightingAndAmbiance,
                    ImageUrl = "https://via.placeholder.com/400x300.png?text=Smart+LED+Light+Bulbs",
                    StockQuantity = 150,
                    CreatorId = "27d78708-8671-4b05-bd5e-17aa91392224",
                    DateCreated = DateTime.UtcNow
                },
                new Product
                {
                    Name = "WiFi Thermostat",
                    Description = "A programmable thermostat that learns your heating and cooling preferences.",
                    Price = 249.99m,
                    Category = Category.HeatingAndCooling,
                    ImageUrl = "https://via.placeholder.com/400x300.png?text=WiFi+Thermostat",
                    StockQuantity = 30,
                    CreatorId = "27d78708-8671-4b05-bd5e-17aa91392224",
                    DateCreated = DateTime.UtcNow
                },
                new Product
                {
                    Name = "Smart Refrigerator",
                    Description = "Refrigerator with touch screen, interior cameras, and WiFi connectivity.",
                    Price = 1599.99m,
                    Category = Category.KitchenAppliances,
                    ImageUrl = "https://via.placeholder.com/400x300.png?text=Smart+Refrigerator",
                    StockQuantity = 10,
                    CreatorId = "27d78708-8671-4b05-bd5e-17aa91392224",
                    DateCreated = DateTime.UtcNow
                },
                new Product
                {
                    Name = "Smart Speaker",
                    Description = "Voice-activated smart speaker with high-fidelity sound and assistant integration.",
                    Price = 99.99m,
                    Category = Category.EntertainmentAndMedia,
                    ImageUrl = "https://via.placeholder.com/400x300.png?text=Smart+Speaker",
                    StockQuantity = 100,
                    CreatorId = "27d78708-8671-4b05-bd5e-17aa91392224",
                    DateCreated = DateTime.UtcNow
                },
                new Product
                {
                    Name = "Energy Monitor Plug",
                    Description = "Smart plug that monitors energy usage of connected devices in real-time.",
                    Price = 24.99m,
                    Category = Category.EnergyManagement,
                    ImageUrl = "https://via.placeholder.com/400x300.png?text=Energy+Monitor+Plug",
                    StockQuantity = 200,
                    CreatorId = "27d78708-8671-4b05-bd5e-17aa91392224",
                    DateCreated = DateTime.UtcNow
                },
                new Product
                {
                    Name = "Robot Vacuum Cleaner",
                    Description = "WiFi-enabled robot vacuum with auto-charge and scheduling capabilities.",
                    Price = 299.99m,
                    Category = Category.CleaningAndHousehold,
                    ImageUrl = "https://via.placeholder.com/400x300.png?text=Robot+Vacuum+Cleaner",
                    StockQuantity = 75,
                    CreatorId = "27d78708-8671-4b05-bd5e-17aa91392224",
                    DateCreated = DateTime.UtcNow
                },
                new Product
                {
                    Name = "Smart Fitness Tracker",
                    Description = "Waterproof fitness tracker with heart rate monitor and sleep tracking.",
                    Price = 59.99m,
                    Category = Category.HealthAndFitness,
                    ImageUrl = "https://via.placeholder.com/400x300.png?text=Smart+Fitness+Tracker",
                    StockQuantity = 120,
                    CreatorId = "27d78708-8671-4b05-bd5e-17aa91392224",
                    DateCreated = DateTime.UtcNow
                },
                new Product
                {
                    Name = "Smart Home Hub",
                    Description = "Central hub to control and integrate all smart home devices.",
                    Price = 129.99m,
                    Category = Category.SmartHubsAndControllers,
                    ImageUrl = "https://via.placeholder.com/400x300.png?text=Smart+Home+Hub",
                    StockQuantity = 40,
                    CreatorId = "27d78708-8671-4b05-bd5e-17aa91392224",
                    DateCreated = DateTime.UtcNow
                },
                new Product
                {
                    Name = "Smart Sprinkler System",
                    Description = "Weather-based sprinkler system for efficient garden watering.",
                    Price = 199.99m,
                    Category = Category.OutdoorAndGarden,
                    ImageUrl = "https://via.placeholder.com/400x300.png?text=Smart+Sprinkler+System",
                    StockQuantity = 20,
                    CreatorId = "27d78708-8671-4b05-bd5e-17aa91392224",
                    DateCreated = DateTime.UtcNow
                }
            };

            Products.AddRange(products);
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
