﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SmartHomeAppliance.Infrastructure.Data;

#nullable disable

namespace SmartHomeAppliance.Infrastructure.Migrations
{
    [DbContext(typeof(SmartHomeApplianceDbContext))]
    [Migration("20241117141554_AddedIdentifiersToOrderProductAndCartProductEntities")]
    partial class AddedIdentifiersToOrderProductAndCartProductEntities
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
                            ConcurrencyStamp = "5950286c-b07c-4296-997f-004a95144e6a",
                            Email = "admin@smarthomeapp.bg",
                            EmailConfirmed = true,
                            FirstName = "Admin",
                            LastName = "Adminov",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@SMARTHOMEAPP.BG",
                            PasswordHash = "AQAAAAIAAYagAAAAEMcxc35XxvE4iTTd6nBbJGfUHYde6wxebzHGvVppygrbUZP9pwGnhy6rInpQhy82gA==",
                            PhoneNumberConfirmed = false,
                            ProfilePictureUrl = "https://plus.unsplash.com/premium_photo-1689530775582-83b8abdb5020?q=80&w=2670&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                            SecurityStamp = "040b6d1e-76d9-4ccd-9ac9-107e2eb91007",
                            TwoFactorEnabled = false
                        });
                });

            modelBuilder.Entity("SmartHomeAppliance.Infrastructure.Data.Models.Cart", b =>
                {
                    b.Property<Guid>("CartId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("CartId");

                    b.HasIndex("UserId");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("SmartHomeAppliance.Infrastructure.Data.Models.CartProduct", b =>
                {
                    b.Property<Guid>("CartId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("CartId", "ProductId", "Id");

                    b.HasIndex("ProductId");

                    b.ToTable("CartProducts");
                });

            modelBuilder.Entity("SmartHomeAppliance.Infrastructure.Data.Models.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("SmartHomeAppliance.Infrastructure.Data.Models.OrderProduct", b =>
                {
                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("OrderId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("OrderUserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("ProductId", "OrderId", "Id");

                    b.HasIndex("OrderId", "OrderUserId");

                    b.ToTable("OrderProducts");
                });

            modelBuilder.Entity("SmartHomeAppliance.Infrastructure.Data.Models.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

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
                            Id = new Guid("7c90d8b4-9fec-470e-8db1-624db5083b4f"),
                            Category = 0,
                            CreatorId = "27d78708-8671-4b05-bd5e-17aa91392224",
                            DateCreated = new DateTime(2024, 11, 17, 14, 15, 53, 710, DateTimeKind.Utc).AddTicks(8251),
                            Description = "A high-definition doorbell camera with night vision and motion detection.",
                            ImageUrl = "https://via.placeholder.com/400x300.png?text=Smart+Doorbell+Camera",
                            Name = "Smart Doorbell Camera",
                            Price = 129.99m,
                            StockQuantity = 50
                        },
                        new
                        {
                            Id = new Guid("4421832e-cda1-44bc-9cdc-367bda67cc94"),
                            Category = 1,
                            CreatorId = "27d78708-8671-4b05-bd5e-17aa91392224",
                            DateCreated = new DateTime(2024, 11, 17, 14, 15, 53, 710, DateTimeKind.Utc).AddTicks(8267),
                            Description = "Color-changing LED light bulbs controllable via app or voice commands.",
                            ImageUrl = "https://via.placeholder.com/400x300.png?text=Smart+LED+Light+Bulbs",
                            Name = "Smart LED Light Bulbs (4-Pack)",
                            Price = 39.99m,
                            StockQuantity = 150
                        },
                        new
                        {
                            Id = new Guid("9a09d7a9-822b-4fd2-9d8d-f0547de08963"),
                            Category = 2,
                            CreatorId = "27d78708-8671-4b05-bd5e-17aa91392224",
                            DateCreated = new DateTime(2024, 11, 17, 14, 15, 53, 710, DateTimeKind.Utc).AddTicks(8270),
                            Description = "A programmable thermostat that learns your heating and cooling preferences.",
                            ImageUrl = "https://via.placeholder.com/400x300.png?text=WiFi+Thermostat",
                            Name = "WiFi Thermostat",
                            Price = 249.99m,
                            StockQuantity = 30
                        },
                        new
                        {
                            Id = new Guid("b36b2ab5-9250-412e-a1da-a72402f6a54d"),
                            Category = 3,
                            CreatorId = "27d78708-8671-4b05-bd5e-17aa91392224",
                            DateCreated = new DateTime(2024, 11, 17, 14, 15, 53, 710, DateTimeKind.Utc).AddTicks(8273),
                            Description = "Refrigerator with touch screen, interior cameras, and WiFi connectivity.",
                            ImageUrl = "https://via.placeholder.com/400x300.png?text=Smart+Refrigerator",
                            Name = "Smart Refrigerator",
                            Price = 1599.99m,
                            StockQuantity = 10
                        },
                        new
                        {
                            Id = new Guid("13f90cdf-544f-4129-92fa-6a1d6607b32f"),
                            Category = 4,
                            CreatorId = "27d78708-8671-4b05-bd5e-17aa91392224",
                            DateCreated = new DateTime(2024, 11, 17, 14, 15, 53, 710, DateTimeKind.Utc).AddTicks(8389),
                            Description = "Voice-activated smart speaker with high-fidelity sound and assistant integration.",
                            ImageUrl = "https://via.placeholder.com/400x300.png?text=Smart+Speaker",
                            Name = "Smart Speaker",
                            Price = 99.99m,
                            StockQuantity = 100
                        },
                        new
                        {
                            Id = new Guid("a0025815-e9ae-4dc5-961c-0133f8e3e930"),
                            Category = 5,
                            CreatorId = "27d78708-8671-4b05-bd5e-17aa91392224",
                            DateCreated = new DateTime(2024, 11, 17, 14, 15, 53, 710, DateTimeKind.Utc).AddTicks(8399),
                            Description = "Smart plug that monitors energy usage of connected devices in real-time.",
                            ImageUrl = "https://via.placeholder.com/400x300.png?text=Energy+Monitor+Plug",
                            Name = "Energy Monitor Plug",
                            Price = 24.99m,
                            StockQuantity = 200
                        },
                        new
                        {
                            Id = new Guid("420ddd81-5c18-433b-8a3b-d5ad314da152"),
                            Category = 6,
                            CreatorId = "27d78708-8671-4b05-bd5e-17aa91392224",
                            DateCreated = new DateTime(2024, 11, 17, 14, 15, 53, 710, DateTimeKind.Utc).AddTicks(8401),
                            Description = "WiFi-enabled robot vacuum with auto-charge and scheduling capabilities.",
                            ImageUrl = "https://via.placeholder.com/400x300.png?text=Robot+Vacuum+Cleaner",
                            Name = "Robot Vacuum Cleaner",
                            Price = 299.99m,
                            StockQuantity = 75
                        },
                        new
                        {
                            Id = new Guid("deac797f-d5c8-4f4d-9234-3244f7e57b07"),
                            Category = 7,
                            CreatorId = "27d78708-8671-4b05-bd5e-17aa91392224",
                            DateCreated = new DateTime(2024, 11, 17, 14, 15, 53, 710, DateTimeKind.Utc).AddTicks(8404),
                            Description = "Waterproof fitness tracker with heart rate monitor and sleep tracking.",
                            ImageUrl = "https://via.placeholder.com/400x300.png?text=Smart+Fitness+Tracker",
                            Name = "Smart Fitness Tracker",
                            Price = 59.99m,
                            StockQuantity = 120
                        },
                        new
                        {
                            Id = new Guid("02341dc4-f84b-427a-b035-2d3d2b5ad020"),
                            Category = 8,
                            CreatorId = "27d78708-8671-4b05-bd5e-17aa91392224",
                            DateCreated = new DateTime(2024, 11, 17, 14, 15, 53, 710, DateTimeKind.Utc).AddTicks(8407),
                            Description = "Central hub to control and integrate all smart home devices.",
                            ImageUrl = "https://via.placeholder.com/400x300.png?text=Smart+Home+Hub",
                            Name = "Smart Home Hub",
                            Price = 129.99m,
                            StockQuantity = 40
                        },
                        new
                        {
                            Id = new Guid("d2a908fe-dbe1-44d8-bcac-83cd94129f3d"),
                            Category = 9,
                            CreatorId = "27d78708-8671-4b05-bd5e-17aa91392224",
                            DateCreated = new DateTime(2024, 11, 17, 14, 15, 53, 710, DateTimeKind.Utc).AddTicks(8409),
                            Description = "Weather-based sprinkler system for efficient garden watering.",
                            ImageUrl = "https://via.placeholder.com/400x300.png?text=Smart+Sprinkler+System",
                            Name = "Smart Sprinkler System",
                            Price = 199.99m,
                            StockQuantity = 20
                        });
                });

            modelBuilder.Entity("SmartHomeAppliance.Infrastructure.Data.Models.Review", b =>
                {
                    b.Property<string>("ProductId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ProductId1")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReviewDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ProductId", "UserId");

                    b.HasIndex("ProductId1");

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

            modelBuilder.Entity("SmartHomeAppliance.Infrastructure.Data.Models.CartProduct", b =>
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

            modelBuilder.Entity("SmartHomeAppliance.Infrastructure.Data.Models.OrderProduct", b =>
                {
                    b.HasOne("SmartHomeAppliance.Infrastructure.Data.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SmartHomeAppliance.Infrastructure.Data.Models.Order", null)
                        .WithMany("Products")
                        .HasForeignKey("OrderId", "OrderUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
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
                        .HasForeignKey("ProductId1");

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
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
