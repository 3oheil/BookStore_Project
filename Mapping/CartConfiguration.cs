﻿using BookStore_Project.Models.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookStore_Project.Mapping
{
    public class CartConfiguration : IEntityTypeConfiguration<Cart>
    {
        public void Configure(EntityTypeBuilder<Cart> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.TotalPrice).HasColumnType("decimal(18,2)");

            builder.HasOne(c => c.User).WithOne(u => u.Cart)
                .HasForeignKey<Cart>(c => c.UserId).OnDelete(DeleteBehavior.Cascade);


        }
    }
}


