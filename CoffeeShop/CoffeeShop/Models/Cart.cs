using System.ComponentModel.DataAnnotations.Schema;

namespace CoffeeShop.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public int UserId { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal TotalAmount { get; set; }
        public DateTime Created_At { get; set; }
        public DateTime Updated_At { get; set; }
 
    }
}
