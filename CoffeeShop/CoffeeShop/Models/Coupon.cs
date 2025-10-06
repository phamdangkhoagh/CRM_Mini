using System.ComponentModel.DataAnnotations.Schema;
using static CoffeeShop.Enums.StatusEnums;

namespace CoffeeShop.Models
{
    public class Coupon
    {
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public required string Code { get; set; }
        
        public DateTime ExpiryDate { get; set; }
        public int DiscountPercentage { get; set; }
        public DateTime Created_At { get; set; }
        public DateTime Updated_At { get; set; }
        public CouponStatus Status { get; set; }
    }
}
