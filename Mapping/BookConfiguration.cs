using BookStore_Project.Models.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookStore_Project.Mapping
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasKey(b => b.Id);

            builder.Property(b => b.Title).IsRequired().HasMaxLength(50);
            builder.Property(b => b.ISBN).IsRequired().HasMaxLength(20);
            builder.Property(b => b.StockQuantity).IsRequired();
            builder.Property(b => b.PublisherYear).IsRequired();
            
            builder.Property(b=>b.CategoryId).IsRequired();
            builder.Property(b => b.CoverImageUrl).IsRequired();
            builder.Property(b => b.Description).IsRequired().HasMaxLength(1000);
            builder.Property(b => b.Language).IsRequired().HasMaxLength(20);
            builder.Property(b => b.PageCount).IsRequired();
            builder.Property(b => b.StockQuantity).IsRequired();
            builder.Property(b => b.Price).IsRequired().HasColumnType("decimal(18, 2)");
       
        }
    }
}
