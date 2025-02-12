﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartHomeAppliance.Infrastructure.Data.Models;
using SmartHomeAppliance.Infrastructure.Data.Seed;

namespace SmartHomeAppliance.Infrastructure.Data.Configurations
{
    internal class ReviewConfiguration : IEntityTypeConfiguration<Review>
    {
        public void Configure(EntityTypeBuilder<Review> builder)
        {
            var seed = new SeedData();
            builder.HasData(seed.Reviews);

            builder.HasOne(r => r.Product)
            .WithMany()  // Assuming a product can have many reviews
            .HasForeignKey(r => r.ProductId)
            .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(r => r.User)
            .WithMany()  // Assuming a user can write many reviews
            .HasForeignKey(r => r.UserId)
            .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
