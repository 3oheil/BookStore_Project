namespace BookStore_Project.Models.Entity
{
    public class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalPrice { get; set; }
        public string OrderState { get; set; }
        public string PaymentStatus { get; set; }
        public string ShippingAddress { get; set; }

        public ICollection<OrderItem> OrderItems { get; set; }

        public User User { get; set; }
        public Payment Payment { get; set; }
    }
}
