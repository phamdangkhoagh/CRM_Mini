using static CoffeeShop.Enums.StatusEnums;

namespace CoffeeShop.Models
{
    public class CouponDetail
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int CouponId { get; set; }
        public DateTime AppliedAt { get; set; }
        public DateTime ExpiryAt { get; set; }
        public DateTime Created_At { get; set; }
        public DateTime Updated_At { get; set; }
        public CouponDetailStatus Status { get; set; }
    }
}
