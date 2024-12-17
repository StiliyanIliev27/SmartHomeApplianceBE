﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SmartHomeAppliance.Infrastructure.Data;

#nullable disable

namespace SmartHomeAppliance.Infrastructure.Migrations
{
    [DbContext(typeof(SmartHomeApplianceDbContext))]
    partial class SmartHomeApplianceDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "4f8554d2-cfaa-44b5-90ce-e883c804ae90",
                            ConcurrencyStamp = "4f8554d2-cfaa-44b5-90ce-e883c804ae90",
                            Name = "User",
                            NormalizedName = "USER"
                        },
                        new
                        {
                            Id = "656a6079-ec9a-4a98-a484-2d1752156d60",
                            ConcurrencyStamp = "656a6079-ec9a-4a98-a484-2d1752156d60",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "27d78708-8671-4b05-bd5e-17aa91392224",
                            RoleId = "656a6079-ec9a-4a98-a484-2d1752156d60"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("SmartHomeAppliance.Infrastructure.Data.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("ProfilePictureUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "27d78708-8671-4b05-bd5e-17aa91392224",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "59755b83-3706-4edf-870a-df326b58a674",
                            Email = "admin@smarthomeapp.bg",
                            EmailConfirmed = true,
                            FirstName = "Admin",
                            LastName = "Adminov",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@SMARTHOMEAPP.BG",
                            PasswordHash = "AQAAAAIAAYagAAAAECXFGe+Mu+Yw+5GMNrpFbMiaYjVWZ1E32Hpsn3GnwRCgcOhwopoNV0fTLrLRUQXB1w==",
                            PhoneNumberConfirmed = false,
                            ProfilePictureUrl = "https://plus.unsplash.com/premium_photo-1689530775582-83b8abdb5020?q=80&w=2670&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                            SecurityStamp = "12f1279f-e7d0-4c92-96e1-8475347f2e24",
                            TwoFactorEnabled = false
                        });
                });

            modelBuilder.Entity("SmartHomeAppliance.Infrastructure.Data.Models.Cart", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("SmartHomeAppliance.Infrastructure.Data.Models.CartsProduct", b =>
                {
                    b.Property<string>("CartId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProductId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("CartId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("CartsProducts");
                });

            modelBuilder.Entity("SmartHomeAppliance.Infrastructure.Data.Models.Order", b =>
                {
                    b.Property<string>("OrderId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("OrderId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("SmartHomeAppliance.Infrastructure.Data.Models.OrdersProducts", b =>
                {
                    b.Property<string>("OrderId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProductId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("OrderUserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("OrderId", "ProductId", "UserId");

                    b.HasIndex("ProductId");

                    b.HasIndex("UserId");

                    b.HasIndex("OrderId", "UserId");

                    b.ToTable("OrdersProducts");
                });

            modelBuilder.Entity("SmartHomeAppliance.Infrastructure.Data.Models.Product", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Category")
                        .HasColumnType("int");

                    b.Property<string>("CreatorId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("StockQuantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CreatorId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = "670ebaec-49bb-4947-8bea-d466123d0af0",
                            Category = 0,
                            CreatorId = "27d78708-8671-4b05-bd5e-17aa91392224",
                            DateCreated = new DateTime(2024, 12, 11, 22, 55, 15, 512, DateTimeKind.Utc).AddTicks(7953),
                            Description = "A high-definition doorbell camera with night vision and motion detection.",
                            ImageUrl = "https://m.media-amazon.com/images/I/611pxr2ITgL.jpg",
                            Name = "Smart Doorbell Camera",
                            Price = 129.99m,
                            StockQuantity = 50
                        },
                        new
                        {
                            Id = "548ecd9a-dab3-4f00-9835-4084b47f3c07",
                            Category = 1,
                            CreatorId = "27d78708-8671-4b05-bd5e-17aa91392224",
                            DateCreated = new DateTime(2024, 12, 11, 22, 55, 15, 512, DateTimeKind.Utc).AddTicks(7978),
                            Description = "Color-changing LED light bulbs controllable via app or voice commands.",
                            ImageUrl = "https://cdn.shopify.com/s/files/1/0024/9803/5810/products/597853-Product-0-I-637940195577281576.jpg?v=1658439198",
                            Name = "Smart LED Light Bulbs (4-Pack)",
                            Price = 39.99m,
                            StockQuantity = 150
                        },
                        new
                        {
                            Id = "6578befc-6f3c-486e-83da-39b641c15336",
                            Category = 2,
                            CreatorId = "27d78708-8671-4b05-bd5e-17aa91392224",
                            DateCreated = new DateTime(2024, 12, 11, 22, 55, 15, 512, DateTimeKind.Utc).AddTicks(7984),
                            Description = "A programmable thermostat that learns your heating and cooling preferences.",
                            ImageUrl = "https://engocontrols.com/wp-content/uploads/2022/07/E901WIFI-2000x2000-1_strona_-min.png",
                            Name = "WiFi Thermostat",
                            Price = 249.99m,
                            StockQuantity = 30
                        },
                        new
                        {
                            Id = "ef697ed7-40e6-4f0f-8df6-8f579b26a473",
                            Category = 3,
                            CreatorId = "27d78708-8671-4b05-bd5e-17aa91392224",
                            DateCreated = new DateTime(2024, 12, 11, 22, 55, 15, 512, DateTimeKind.Utc).AddTicks(8009),
                            Description = "Refrigerator with touch screen, interior cameras, and WiFi connectivity.",
                            ImageUrl = "https://www.lifewire.com/thmb/Ib9NmsHdQ4q236zqBVxnsNYTIHA=/1500x0/filters:no_upscale():max_bytes(150000):strip_icc()/samsung-ha-ref-rf56k9540sr-family-hub-overview-5aa18f0e18ba010037c023a5.jpg",
                            Name = "Smart Refrigerator",
                            Price = 1599.99m,
                            StockQuantity = 10
                        },
                        new
                        {
                            Id = "3c078fae-2a18-48cc-8d24-eccce0ced69c",
                            Category = 4,
                            CreatorId = "27d78708-8671-4b05-bd5e-17aa91392224",
                            DateCreated = new DateTime(2024, 12, 11, 22, 55, 15, 512, DateTimeKind.Utc).AddTicks(8049),
                            Description = "Voice-activated smart speaker with high-fidelity sound and assistant integration.",
                            ImageUrl = "https://cdn.aarp.net/content/dam/aarpe/en/home/home-family/personal-technology/info-2019/smart-speaker-uses/_jcr_content/root/container_main/container_body_main/container_body1/container_body_cf/container_image/articlecontentfragment/cfimage.coreimg.50.932.jpeg/content/dam/aarp/home-and-family/personal-technology/2019/10/1140-smart-speaker-functions.jpg",
                            Name = "Smart Speaker",
                            Price = 99.99m,
                            StockQuantity = 100
                        },
                        new
                        {
                            Id = "06c1cfcc-ef7a-453e-879b-a9249e8a67b9",
                            Category = 5,
                            CreatorId = "27d78708-8671-4b05-bd5e-17aa91392224",
                            DateCreated = new DateTime(2024, 12, 11, 22, 55, 15, 512, DateTimeKind.Utc).AddTicks(8058),
                            Description = "Smart plug that monitors energy usage of connected devices in real-time.",
                            ImageUrl = "https://static.independent.co.uk/2023/01/10/16/best%20energy%20monitors%20Indybest%20copy.jpg",
                            Name = "Energy Monitor Plug",
                            Price = 24.99m,
                            StockQuantity = 200
                        },
                        new
                        {
                            Id = "945bd2a5-b16c-45d7-a685-bde6bbf28fc0",
                            Category = 6,
                            CreatorId = "27d78708-8671-4b05-bd5e-17aa91392224",
                            DateCreated = new DateTime(2024, 12, 11, 22, 55, 15, 512, DateTimeKind.Utc).AddTicks(8063),
                            Description = "WiFi-enabled robot vacuum with auto-charge and scheduling capabilities.",
                            ImageUrl = "https://crowncleaners.org.uk/wp-content/uploads/2024/08/Robot_Vacuum_Cleaner-feature-image-blog.jpg",
                            Name = "Robot Vacuum Cleaner",
                            Price = 299.99m,
                            StockQuantity = 75
                        },
                        new
                        {
                            Id = "b084f708-534f-4400-94c8-8d5669cbb6c6",
                            Category = 7,
                            CreatorId = "27d78708-8671-4b05-bd5e-17aa91392224",
                            DateCreated = new DateTime(2024, 12, 11, 22, 55, 15, 512, DateTimeKind.Utc).AddTicks(8069),
                            Description = "Waterproof fitness tracker with heart rate monitor and sleep tracking.",
                            ImageUrl = "https://s13emagst.akamaized.net/products/62903/62902367/images/res_b892254d28f050b61467aa3472854e47.jpg",
                            Name = "Smart Fitness Tracker",
                            Price = 59.99m,
                            StockQuantity = 120
                        },
                        new
                        {
                            Id = "0eeb842b-f9a7-4e52-87db-4a69906dec4c",
                            Category = 8,
                            CreatorId = "27d78708-8671-4b05-bd5e-17aa91392224",
                            DateCreated = new DateTime(2024, 12, 11, 22, 55, 15, 512, DateTimeKind.Utc).AddTicks(8078),
                            Description = "Central hub to control and integrate all smart home devices.",
                            ImageUrl = "https://smartechdaily.com/wp-content/uploads/2024/05/19690_Generated_Image-1024x585.webp",
                            Name = "Smart Home Hub",
                            Price = 129.99m,
                            StockQuantity = 40
                        },
                        new
                        {
                            Id = "9b601fc3-89c8-4dc2-a5cc-58c805f426b4",
                            Category = 9,
                            CreatorId = "27d78708-8671-4b05-bd5e-17aa91392224",
                            DateCreated = new DateTime(2024, 12, 11, 22, 55, 15, 512, DateTimeKind.Utc).AddTicks(8298),
                            Description = "Weather-based sprinkler system for efficient garden watering.",
                            ImageUrl = "https://i.pcmag.com/imagery/reviews/05VIJDsjiZiHbe0MImRiYLr-1..v1569469978.jpg",
                            Name = "Smart Sprinkler System",
                            Price = 199.99m,
                            StockQuantity = 20
                        });
                });

            modelBuilder.Entity("SmartHomeAppliance.Infrastructure.Data.Models.Review", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReviewDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("UserId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("SmartHomeAppliance.Infrastructure.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("SmartHomeAppliance.Infrastructure.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SmartHomeAppliance.Infrastructure.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("SmartHomeAppliance.Infrastructure.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SmartHomeAppliance.Infrastructure.Data.Models.Cart", b =>
                {
                    b.HasOne("SmartHomeAppliance.Infrastructure.Data.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("SmartHomeAppliance.Infrastructure.Data.Models.CartsProduct", b =>
                {
                    b.HasOne("SmartHomeAppliance.Infrastructure.Data.Models.Cart", "Cart")
                        .WithMany()
                        .HasForeignKey("CartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SmartHomeAppliance.Infrastructure.Data.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cart");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("SmartHomeAppliance.Infrastructure.Data.Models.Order", b =>
                {
                    b.HasOne("SmartHomeAppliance.Infrastructure.Data.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("SmartHomeAppliance.Infrastructure.Data.Models.OrdersProducts", b =>
                {
                    b.HasOne("SmartHomeAppliance.Infrastructure.Data.Models.Product", "Product")
                        .WithMany("OrdersProducts")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SmartHomeAppliance.Infrastructure.Data.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SmartHomeAppliance.Infrastructure.Data.Models.Order", "Order")
                        .WithMany("OrdersProducts")
                        .HasForeignKey("OrderId", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");

                    b.Navigation("User");
                });

            modelBuilder.Entity("SmartHomeAppliance.Infrastructure.Data.Models.Product", b =>
                {
                    b.HasOne("SmartHomeAppliance.Infrastructure.Data.Models.ApplicationUser", "Creator")
                        .WithMany()
                        .HasForeignKey("CreatorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Creator");
                });

            modelBuilder.Entity("SmartHomeAppliance.Infrastructure.Data.Models.Review", b =>
                {
                    b.HasOne("SmartHomeAppliance.Infrastructure.Data.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SmartHomeAppliance.Infrastructure.Data.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("User");
                });

            modelBuilder.Entity("SmartHomeAppliance.Infrastructure.Data.Models.Order", b =>
                {
                    b.Navigation("OrdersProducts");
                });

            modelBuilder.Entity("SmartHomeAppliance.Infrastructure.Data.Models.Product", b =>
                {
                    b.Navigation("OrdersProducts");
                });
#pragma warning restore 612, 618
        }
    }
}
