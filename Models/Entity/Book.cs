using System.Reflection.Metadata.Ecma335;

namespace BookStore_Project.Models.Entity
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public  string ISBN { get; set; }
        public string Description { get; set; }
        public int Author_Id { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
        public int Publisher_Id { get; set; }
        public int CategoryId { get; set; }
        public int PublisherYear { get; set; }
        public int PageCount { get; set; }
        public string Language { get; set; }
        public string CoverImageUrl { get; set; }
        public int Rating { get; set; }

        public ICollection<Review> Reviews { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }

        public Category Category { get; set; }
        public Publisher Publisher { get; set; }

        public ICollection<CartItem> cartItems { get; set; }
        public ICollection<Author> Authors { get; set; }
    }
}
