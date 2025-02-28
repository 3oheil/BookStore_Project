namespace BookStore_Project.Models.Entity
{
    public class Payment
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public string PaymentStatus { get; set; }
        public string PaymentMethod { get; set; }
        public string TrancationId { get; set; }
        public DateTime PaymetDate { get; set; }

        public Order Order { get; set; }
    }
}
