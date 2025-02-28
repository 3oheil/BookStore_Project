using BookStore_Project.Mapping;
using BookStore_Project.Models.Entity;
using Microsoft.EntityFrameworkCore;

namespace BookStore_Project.data
{
    public class BookStore_Context : DbContext
    {
        public BookStore_Context(DbContextOptions<BookStore_Context> options) : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BookConfiguration());
            modelBuilder.ApplyConfiguration(new AuthorConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new PublisherConfiguration());
            modelBuilder.ApplyConfiguration(new CartConfiguration());
            modelBuilder.ApplyConfiguration(new OrderConfiguration());
            modelBuilder.ApplyConfiguration(new PaymentConfiguration());
            modelBuilder.ApplyConfiguration(new ReviewConfiguration());


            // One to Many: Order - OrderItem
            modelBuilder.Entity<OrderItem>().HasOne(oi => oi.Order)
                .WithMany(o => o.OrderItems).HasForeignKey(oi => oi.OrderId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<OrderItem>()
                .HasOne(oi => oi.Book)
                .WithMany(b => b.OrderItems).HasForeignKey(oi => oi.BookId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<CartItem>().HasOne(ci => ci.Cart)
                .WithMany(c => c.CartItems).HasForeignKey(ci => ci.CartId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<CartItem>()
                .HasOne(ci => ci.Book).WithMany(b => b.cartItems)
                .HasForeignKey(ci => ci.BookId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}