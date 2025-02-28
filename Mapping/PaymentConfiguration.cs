using BookStore_Project.Models.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookStore_Project.Mapping
{
    public class PaymentConfiguration : IEntityTypeConfiguration<Payment>
    {
        public void Configure(EntityTypeBuilder<Payment> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.PaymentMethod).IsRequired().HasMaxLength(50);
            builder.Property(p => p.PaymentStatus).IsRequired().HasMaxLength(50);
            builder.Property(p => p.TrancationId).IsRequired();

            builder.HasOne(p => p.Order).WithOne(o => o.Payment)
                .HasForeignKey<Payment>(p => p.OrderId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
