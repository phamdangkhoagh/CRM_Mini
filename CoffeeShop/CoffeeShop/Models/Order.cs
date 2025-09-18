namespace CoffeeShop.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int PaymentId { get; set; }
        public int CouponId { get; set; }
        public DateTime Date { get; set; }
        public decimal TotalAmount { get; set; }
        public DateTime Created_At { get; set; }
        public DateTime Updated_At { get; set; }
        public string Status { get; set; }
    }
}
