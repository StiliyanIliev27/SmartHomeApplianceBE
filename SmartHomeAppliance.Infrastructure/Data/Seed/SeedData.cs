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
                    ImageUrl = "https://m.media-amazon.com/images/I/611pxr2ITgL.jpg",
                    StockQuantity = 50,
                    CreatorId = "27d78708-8671-4b05-bd5e-17aa91392224",
                    Rating = 4,
                    DateCreated = DateTime.UtcNow
                },
                new Product
                {
                    Name = "Smart LED Light Bulbs (4-Pack)",
                    Description = "Color-changing LED light bulbs controllable via app or voice commands.",
                    Price = 39.99m,
                    Category = Category.LightingAndAmbiance,
                    ImageUrl = "https://cdn.shopify.com/s/files/1/0024/9803/5810/products/597853-Product-0-I-637940195577281576.jpg?v=1658439198",
                    StockQuantity = 150,
                    CreatorId = "27d78708-8671-4b05-bd5e-17aa91392224",
                    Rating = 5,
                    DateCreated = DateTime.UtcNow
                },
                new Product
                {
                    Name = "WiFi Thermostat",
                    Description = "A programmable thermostat that learns your heating and cooling preferences.",
                    Price = 249.99m,
                    Category = Category.HeatingAndCooling,
                    ImageUrl = "https://engocontrols.com/wp-content/uploads/2022/07/E901WIFI-2000x2000-1_strona_-min.png",
                    StockQuantity = 30,
                    CreatorId = "27d78708-8671-4b05-bd5e-17aa91392224",
                    Rating = 4,
                    DateCreated = DateTime.UtcNow
                },
                new Product
                {
                    Name = "Smart Refrigerator",
                    Description = "Refrigerator with touch screen, interior cameras, and WiFi connectivity.",
                    Price = 1599.99m,
                    Category = Category.KitchenAppliances,
                    ImageUrl = "https://www.lifewire.com/thmb/Ib9NmsHdQ4q236zqBVxnsNYTIHA=/1500x0/filters:no_upscale():max_bytes(150000):strip_icc()/samsung-ha-ref-rf56k9540sr-family-hub-overview-5aa18f0e18ba010037c023a5.jpg",
                    StockQuantity = 10,
                    CreatorId = "27d78708-8671-4b05-bd5e-17aa91392224",
                    Rating = 3,
                    DateCreated = DateTime.UtcNow
                },
                new Product
                {
                    Name = "Smart Speaker",
                    Description = "Voice-activated smart speaker with high-fidelity sound and assistant integration.",
                    Price = 99.99m,
                    Category = Category.EntertainmentAndMedia,
                    ImageUrl = "https://cdn.aarp.net/content/dam/aarpe/en/home/home-family/personal-technology/info-2019/smart-speaker-uses/_jcr_content/root/container_main/container_body_main/container_body1/container_body_cf/container_image/articlecontentfragment/cfimage.coreimg.50.932.jpeg/content/dam/aarp/home-and-family/personal-technology/2019/10/1140-smart-speaker-functions.jpg",
                    StockQuantity = 100,
                    CreatorId = "27d78708-8671-4b05-bd5e-17aa91392224",
                    Rating = 4,
                    DateCreated = DateTime.UtcNow
                },
                new Product
                {
                    Name = "Energy Monitor Plug",
                    Description = "Smart plug that monitors energy usage of connected devices in real-time.",
                    Price = 24.99m,
                    Category = Category.EnergyManagement,
                    ImageUrl = "https://static.independent.co.uk/2023/01/10/16/best%20energy%20monitors%20Indybest%20copy.jpg",
                    StockQuantity = 200,
                    CreatorId = "27d78708-8671-4b05-bd5e-17aa91392224",
                    Rating = 5,
                    DateCreated = DateTime.UtcNow
                },
                new Product
                {
                    Name = "Robot Vacuum Cleaner",
                    Description = "WiFi-enabled robot vacuum with auto-charge and scheduling capabilities.",
                    Price = 299.99m,
                    Category = Category.CleaningAndHousehold,
                    ImageUrl = "https://crowncleaners.org.uk/wp-content/uploads/2024/08/Robot_Vacuum_Cleaner-feature-image-blog.jpg",
                    StockQuantity = 75,
                    CreatorId = "27d78708-8671-4b05-bd5e-17aa91392224",
                    Rating = 5,
                    DateCreated = DateTime.UtcNow
                },
                new Product
                {
                    Name = "Smart Fitness Tracker",
                    Description = "Waterproof fitness tracker with heart rate monitor and sleep tracking.",
                    Price = 59.99m,
                    Category = Category.HealthAndFitness,
                    ImageUrl = "https://s13emagst.akamaized.net/products/62903/62902367/images/res_b892254d28f050b61467aa3472854e47.jpg",
                    StockQuantity = 120,
                    CreatorId = "27d78708-8671-4b05-bd5e-17aa91392224",
                    Rating = 4,
                    DateCreated = DateTime.UtcNow
                },
                new Product
                {
                    Name = "Smart Home Hub",
                    Description = "Central hub to control and integrate all smart home devices.",
                    Price = 129.99m,
                    Category = Category.SmartHubsAndControllers,
                    ImageUrl = "https://smartechdaily.com/wp-content/uploads/2024/05/19690_Generated_Image-1024x585.webp",
                    StockQuantity = 40,
                    CreatorId = "27d78708-8671-4b05-bd5e-17aa91392224",
                    Rating = 3,
                    DateCreated = DateTime.UtcNow
                },
                new Product
                {
                    Name = "Smart Sprinkler System",
                    Description = "Weather-based sprinkler system for efficient garden watering.",
                    Price = 199.99m,
                    Category = Category.OutdoorAndGarden,
                    ImageUrl = "https://i.pcmag.com/imagery/reviews/05VIJDsjiZiHbe0MImRiYLr-1..v1569469978.jpg",
                    StockQuantity = 20,
                    CreatorId = "27d78708-8671-4b05-bd5e-17aa91392224",
                    Rating = 2,
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
