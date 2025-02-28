using BookStore_Project.Models.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace BookStore_Project.Mapping
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(o => o.Id);
            builder.Property(o => o.ShippingAddress).IsRequired()
                .HasMaxLength(255);
            builder.Property(o => o.PaymentStatus).IsRequired();
            builder.Property(o => o.OrderState).IsRequired();
            builder.Property(o => o.TotalPrice).HasColumnType("decimal(18,2)");

            builder.HasOne(o => o.User)
    .WithMany(u => u.Orders);
        }
    }
}
