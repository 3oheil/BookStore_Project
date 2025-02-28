using BookStore_Project.Models.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookStore_Project.Mapping
{
    public class AuthorConfiguration : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.HasKey(a=>a.Auther_Id);
            builder.Property(a => a.FullName).IsRequired().HasMaxLength(50);
            builder.Property(a => a.Country).IsRequired().HasMaxLength(20);
            builder.Property(a => a.BirthYear).IsRequired().HasMaxLength(30);

            builder.HasMany(a => a.Books).WithMany(b => b.Authors);
        }
    }
}
