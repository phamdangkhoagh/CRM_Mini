using System.ComponentModel.DataAnnotations.Schema;
using static CoffeeShop.Enums.StatusEnums;

namespace CoffeeShop.Models
{
    public class Payment
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }

        [Column(TypeName = "varchar(25)")]
        public string PaymentMethod { get; set; } = null!;

        [Column(TypeName = "varchar(255)")]
        public string QRCode_URL { get; set; } = null!;
        public DateTime Created_At { get; set; }
        public DateTime Completed_At { get; set; }
        public PaymentStatus Status { get; set; }
    }
}
