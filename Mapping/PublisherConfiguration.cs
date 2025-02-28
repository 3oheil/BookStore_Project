using BookStore_Project.Models.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookStore_Project.Mapping
{
    public class PublisherConfiguration : IEntityTypeConfiguration<Publisher>
    {
        public void Configure(EntityTypeBuilder<Publisher> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Name).IsRequired().HasMaxLength(128);
            builder.Property(p => p.Website).IsRequired().HasMaxLength(128);

            builder.HasMany(p => p.Books).WithOne(b => b.Publisher).
                HasForeignKey(b => b.Publisher_Id)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
