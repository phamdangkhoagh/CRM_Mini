using System.ComponentModel.DataAnnotations.Schema;
using static CoffeeShop.Enums.StatusEnums;

namespace CoffeeShop.Models
{
    public class Products
    {
        public int Id { get; set; }

        [Column(TypeName = "varchar(25)")]
        public required string Name { get; set; }

        [Column(TypeName = "varchar(255)")]
        public required string Description { get; set; }
        public SizeProduct Size { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal Price { get; set; }

        [Column(TypeName = "varchar(255)")]
        public required string ImageUrl { get; set; }
        public int CategoryId { get; set; }
        public DateTime Created_At { get; set; }
        public DateTime Updated_At { get; set; }
        public ProductStatus Status { get; set; }
    }
}
