using BookStore_Project.Models.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookStore_Project.Mapping
{
    public class ReviewConfiguration : IEntityTypeConfiguration<Review>
    {
        public void Configure(EntityTypeBuilder<Review> builder)
        {
            builder.HasKey(r => r.Id);
            builder.Property(r => r.Comment).IsRequired().HasMaxLength(555);


            builder.HasOne(r => r.User).WithMany(b => b.Reviews)
                .HasForeignKey(r => r.BookId).OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(r => r.Book).WithMany(b => b.Reviews)
                .HasForeignKey(r => r.BookId).OnDelete(DeleteBehavior.Cascade);



        }
    }
}

