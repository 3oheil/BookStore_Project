namespace BookStore_Project.Models.Entity
{
    public class CartItem
    {
        public int Id { get; set; }
        public int CartId { get; set; }
        public int BookId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }

        public Cart Cart { get; set; }
        public Book Book { get; set; }
    }
}
