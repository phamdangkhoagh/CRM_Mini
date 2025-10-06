using System.ComponentModel.DataAnnotations.Schema;
using static CoffeeShop.Enums.StatusEnums;

namespace CoffeeShop.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Column(TypeName = "varchar(255)")]
        public required string Name { get; set; }
        public DateTime Created_At { get; set; }
        public DateTime Updated_At { get; set; }
        public CategoryStatus Status { get; set; }
        
    }
}
