using Microsoft.AspNetCore.Identity;
using SmartHomeAppliance.Infrastructure.Data.Enums;
using SmartHomeAppliance.Infrastructure.Data.Models;

namespace SmartHomeAppliance.Infrastructure.Data.Seed
{
    public class SeedData
    {
        public List<ApplicationUser> Users { get; set; } = new List<ApplicationUser>();
        public ICollection<IdentityRole> Roles { get; set; } = new HashSet<IdentityRole>();
        public ICollection<IdentityUserRole<string>> UsersRoles { get; set; } = new HashSet<IdentityUserRole<string>>();
        public List<Product> Products { get; set; } = new List<Product>();
        public List<Review> Reviews { get; set; } = new List<Review>();
        public SeedData()
        {
            SeedAdminUser();
            SeedRoles();
            SeedUsersRoles();
            SeedProducts();
            SeedReviews();
        }

        private void SeedProducts()
        {
            var products = new HashSet<Product>
            {
                new Product
                {
                    Id = "c5a8a95c-0fe5-4f7d-9e46-0ad9fabf78ec",
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
                    Id = "d39a7ae3-78c5-40ae-8569-34a0454dc909",
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
                    Id = "40941ea9-019c-415c-a101-9ccbc93a07d6",
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
                    Id = "54a7eca8-ed42-4444-8522-d5a00310ed62",
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
                    Id = "800a6ca2-3027-4a0f-ae72-0156405a6a58",
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
                    Id = "a2fa3f78-c2ce-44ae-8b3f-402f54563b30",
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
                    Id = "668c6a85-f13f-43e9-b898-64d210b1cd45",
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
                    Id = "7be0663a-6953-44a8-9d06-80f1d72ce6b3",
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
                    Id = "b109e70a-6b64-489f-a216-1d407abcf02f",
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
                    Id = "398a846c-2b2c-4b01-90f2-55d342268673",
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
        private void SeedReviews()
        {
            var reviews = new HashSet<Review>()
            {
                // Reviews by John Doe
                new Review
                {
                    ProductId = "c5a8a95c-0fe5-4f7d-9e46-0ad9fabf78ec",
                    Comment = "I love how easy it is to set up this doorbell camera. The image quality is superb.",
                    UserId = "12345678-9abc-def0-1234-56789abcdef0", // John Doe
                    Rating = 5,
                    ReviewDate = DateTime.UtcNow.AddDays(-10)
                },
                new Review
                {
                    ProductId = "54a7eca8-ed42-4444-8522-d5a00310ed62",
                    Comment = "The refrigerator is sleek, but I think it's overpriced for the features.",
                    UserId = "12345678-9abc-def0-1234-56789abcdef0", // John Doe
                    Rating = 3,
                    ReviewDate = DateTime.UtcNow.AddDays(-15)
                },
                new Review
                {
                    ProductId = "7be0663a-6953-44a8-9d06-80f1d72ce6b3",
                    Comment = "A must-have fitness tracker for anyone serious about health.",
                    UserId = "12345678-9abc-def0-1234-56789abcdef0", // John Doe
                    Rating = 5,
                    ReviewDate = DateTime.UtcNow.AddDays(-20)
                },

                // Reviews by Jane Smith
                new Review
                {
                    ProductId = "d39a7ae3-78c5-40ae-8569-34a0454dc909",
                    Comment = "Fun to use and great for parties! The color-changing feature is amazing.",
                    UserId = "abcdef12-3456-7890-abcd-ef1234567890", // Jane Smith
                    Rating = 5,
                    ReviewDate = DateTime.UtcNow.AddDays(-5)
                },
                new Review
                {
                    ProductId = "668c6a85-f13f-43e9-b898-64d210b1cd45",
                    Comment = "The robot vacuum works well on carpets and tiles but struggles with edges.",
                    UserId = "abcdef12-3456-7890-abcd-ef1234567890", // Jane Smith
                    Rating = 4,
                    ReviewDate = DateTime.UtcNow.AddDays(-12)
                },
                new Review
                {
                    ProductId = "a2fa3f78-c2ce-44ae-8b3f-402f54563b30",
                    Comment = "I saved so much energy with this plug. The real-time monitoring is awesome.",
                    UserId = "abcdef12-3456-7890-abcd-ef1234567890", // Jane Smith
                    Rating = 5,
                    ReviewDate = DateTime.UtcNow.AddDays(-18)
                },

                // Reviews by Guest User
                new Review
                {
                    ProductId = "40941ea9-019c-415c-a101-9ccbc93a07d6",
                    Comment = "This thermostat was a game-changer for our energy bills.",
                    UserId = "fedcba98-7654-3210-fedc-ba9876543210", // Guest User
                    Rating = 5,
                    ReviewDate = DateTime.UtcNow.AddDays(-25)
                },
                new Review
                {
                    ProductId = "398a846c-2b2c-4b01-90f2-55d342268673",
                    Comment = "The weather-based feature works like a charm for my garden.",
                    UserId = "fedcba98-7654-3210-fedc-ba9876543210", // Guest User
                    Rating = 5,
                    ReviewDate = DateTime.UtcNow.AddDays(-8)
                },
                new Review
                {
                    ProductId = "b109e70a-6b64-489f-a216-1d407abcf02f",
                    Comment = "The hub has some lag when controlling multiple devices.",
                    UserId = "fedcba98-7654-3210-fedc-ba9876543210", // Guest User
                    Rating = 3,
                    ReviewDate = DateTime.UtcNow.AddDays(-30)
                },

                // Reviews by Moderator
                new Review
                {
                    ProductId = "c5a8a95c-0fe5-4f7d-9e46-0ad9fabf78ec",
                    Comment = "The night vision is good, but the motion detection can be too sensitive.",
                    UserId = "11223344-5566-7788-99aa-bbccddeeff00", // Moderator
                    Rating = 4,
                    ReviewDate = DateTime.UtcNow.AddDays(-14)
                },
                new Review
                {
                    ProductId = "668c6a85-f13f-43e9-b898-64d210b1cd45",
                    Comment = "Perfect for busy people. It cleans thoroughly and docks automatically.",
                    UserId = "11223344-5566-7788-99aa-bbccddeeff00", // Moderator
                    Rating = 5,
                    ReviewDate = DateTime.UtcNow.AddDays(-20)
                },
                new Review
                {
                    ProductId = "54a7eca8-ed42-4444-8522-d5a00310ed62",
                    Comment = "Great design, but I wish the touch screen was more responsive.",
                    UserId = "11223344-5566-7788-99aa-bbccddeeff00", // Moderator
                    Rating = 4,
                    ReviewDate = DateTime.UtcNow.AddDays(-22)
                },

                // Additional Random Reviews
                new Review
                {
                    ProductId = "d39a7ae3-78c5-40ae-8569-34a0454dc909",
                    Comment = "The lights are fantastic, and the app is super intuitive.",
                    UserId = "12345678-9abc-def0-1234-56789abcdef0",
                    Rating = 5,
                    ReviewDate = DateTime.UtcNow.AddDays(-7)
                },
                new Review
                {
                    ProductId = "7be0663a-6953-44a8-9d06-80f1d72ce6b3",
                    Comment = "Accurate sleep tracking, but the battery life is shorter than expected.",
                    UserId = "abcdef12-3456-7890-abcd-ef1234567890",
                    Rating = 4,
                    ReviewDate = DateTime.UtcNow.AddDays(-11)
                },
                new Review
                {
                    ProductId = "b109e70a-6b64-489f-a216-1d407abcf02f",
                    Comment = "Works well for basic needs, but advanced users may want more features.",
                    UserId = "fedcba98-7654-3210-fedc-ba9876543210",
                    Rating = 3,
                    ReviewDate = DateTime.UtcNow.AddDays(-16)
                },
                new Review
                {
                    ProductId = "398a846c-2b2c-4b01-90f2-55d342268673",
                    Comment = "Easy to install and very efficient for garden watering.",
                    UserId = "11223344-5566-7788-99aa-bbccddeeff00",
                    Rating = 5,
                    ReviewDate = DateTime.UtcNow.AddDays(-9)
                },
                new Review
                {
                    ProductId = "c5a8a95c-0fe5-4f7d-9e46-0ad9fabf78ec",
                    Comment = "This doorbell camera works great! The motion detection is very accurate.",
                    UserId = "12345678-9abc-def0-1234-56789abcdef0", // John Doe
                    Rating = 5,
                    ReviewDate = DateTime.UtcNow.AddDays(-10)
                },
                new Review
                {
                    ProductId = "d39a7ae3-78c5-40ae-8569-34a0454dc909",
                    Comment = "The lights are very bright and the app is easy to use.",
                    UserId = "abcdef12-3456-7890-abcd-ef1234567890", // Jane Smith
                    Rating = 4,
                    ReviewDate = DateTime.UtcNow.AddDays(-20)
                },
                new Review
                {
                    ProductId = "40941ea9-019c-415c-a101-9ccbc93a07d6",
                    Comment = "A bit pricey, but I love how it learns my preferences!",
                    UserId = "11223344-5566-7788-99aa-bbccddeeff00", // Moderator
                    Rating = 5,
                    ReviewDate = DateTime.UtcNow.AddDays(-15)
                },
                new Review
                {
                    ProductId = "54a7eca8-ed42-4444-8522-d5a00310ed62",
                    Comment = "The screen is impressive, but the cooling performance could be better.",
                    UserId = "fedcba98-7654-3210-fedc-ba9876543210", // Guest User
                    Rating = 3,
                    ReviewDate = DateTime.UtcNow.AddDays(-5)
                },
                new Review
                {
                    ProductId = "668c6a85-f13f-43e9-b898-64d210b1cd45",
                    Comment = "This vacuum cleaner has saved me so much time. Highly recommend!",
                    UserId = "12345678-9abc-def0-1234-56789abcdef0", // John Doe
                    Rating = 5,
                    ReviewDate = DateTime.UtcNow.AddDays(-8)
                },
                new Review
                {
                    ProductId = "7be0663a-6953-44a8-9d06-80f1d72ce6b3",
                    Comment = "Great for tracking my workouts, but the strap feels a bit cheap.",
                    UserId = "abcdef12-3456-7890-abcd-ef1234567890", // Jane Smith
                    Rating = 4,
                    ReviewDate = DateTime.UtcNow.AddDays(-12)
                },
                new Review
                {
                    ProductId = "b109e70a-6b64-489f-a216-1d407abcf02f",
                    Comment = "Good hub, but it doesn't support some devices I own.",
                    UserId = "11223344-5566-7788-99aa-bbccddeeff00", // Moderator
                    Rating = 3,
                    ReviewDate = DateTime.UtcNow.AddDays(-18)
                },
                new Review
                {
                    ProductId = "398a846c-2b2c-4b01-90f2-55d342268673",
                    Comment = "The sprinkler system works well, but setup was confusing.",
                    UserId = "fedcba98-7654-3210-fedc-ba9876543210", // Guest User
                    Rating = 4,
                    ReviewDate = DateTime.UtcNow.AddDays(-22)
                },
                new Review
                {
                    ProductId = "a2fa3f78-c2ce-44ae-8b3f-402f54563b30",
                    Comment = "Simple to use and very informative. A must-have for saving energy.",
                    UserId = "12345678-9abc-def0-1234-56789abcdef0", // John Doe
                    Rating = 5,
                    ReviewDate = DateTime.UtcNow.AddDays(-30)
                }
            };

            Reviews.AddRange(reviews);
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
                PasswordHash = hasher.HashPassword(null!, "admin123"),
                CreatedAt = DateTime.Parse("01-01-2025")
            };

            //Test users for reviews 
            var testUsers = new HashSet<ApplicationUser>()
            {
                // Regular User 1
                new ApplicationUser
                {
                    Id = "12345678-9abc-def0-1234-56789abcdef0",
                    Email = "john.doe@example.com",
                    EmailConfirmed = true,
                    NormalizedEmail = "JOHN.DOE@EXAMPLE.COM",
                    FirstName = "John",
                    LastName = "Doe",
                    ProfilePictureUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSGiRJA_5DqmVm7TxMV7E0IzYzUujF4p3SHPg&s",
                    PasswordHash = hasher.HashPassword(null!, "password123"),
                    CreatedAt = DateTime.Parse("01-01-2025")
                },

                // Regular User 2
                new ApplicationUser
                {
                    Id = "abcdef12-3456-7890-abcd-ef1234567890",
                    Email = "jane.smith@example.com",
                    EmailConfirmed = true,
                    NormalizedEmail = "JANE.SMITH@EXAMPLE.COM",
                    FirstName = "Jane",
                    LastName = "Smith",
                    ProfilePictureUrl = "https://images.unsplash.com/photo-1511367461989-f85a21fda167",
                    PasswordHash = hasher.HashPassword(null!, "securePass!456"),
                    CreatedAt = DateTime.Parse("01-01-2025")
                },

                // Guest User
                new ApplicationUser
                {
                    Id = "fedcba98-7654-3210-fedc-ba9876543210",
                    Email = "guest@example.com",
                    EmailConfirmed = false,
                    NormalizedEmail = "GUEST@EXAMPLE.COM",
                    FirstName = "Guest",
                    LastName = "User",
                    ProfilePictureUrl = "https://images.unsplash.com/photo-1529626455594-4ff0802cfb7e",
                    PasswordHash = hasher.HashPassword(null!, "guestPassword123"),
                    CreatedAt = DateTime.Parse("01-01-2025")
                },

                // Moderator User
                new ApplicationUser
                {
                    Id = "11223344-5566-7788-99aa-bbccddeeff00",
                    Email = "moderator@smarthomeapp.bg",
                    EmailConfirmed = true,
                    NormalizedEmail = "MODERATOR@SMARTHOMEAPP.BG",
                    FirstName = "Mod",
                    LastName = "Erator",
                    ProfilePictureUrl = "https://images.unsplash.com/photo-1534528741775-53994a69daeb",
                    PasswordHash = hasher.HashPassword(null!, "modSecure789"),
                    CreatedAt = DateTime.Parse("01-01-2025")
                }
            };

            Users.Add(adminUser);
            Users.AddRange(testUsers);
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
