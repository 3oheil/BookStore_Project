namespace BookStore_Project.Models.Entity
{
    public class Cart
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public decimal TotalPrice { get; set; }

        public ICollection<CartItem> CartItems { get; set; }

        public User User { get; set; }

    }
}
