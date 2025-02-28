using BookStore_Project.Models.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookStore_Project.Mapping
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(c=>c.Category_Id);
            builder.Property(c=>c.Name).IsRequired().HasMaxLength(50);
            
            builder.HasMany(c=>c.Books)
                .WithOne(b => b.Category)
                .HasForeignKey(b=>b.CategoryId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
