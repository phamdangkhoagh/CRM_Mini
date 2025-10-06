using System.ComponentModel.DataAnnotations.Schema;
using static CoffeeShop.Enums.StatusEnums;

namespace CoffeeShop.Models
{
    public class Role
    {
        public int Id { get; set; }

        [Column(TypeName = "varchar(25)")]
        public required string Name { get; set; }
        public DateTime Created_At { get; set; }
        public DateTime Updated_At { get; set; }
        public RoleStatus Status { get; set; }
    }
}
