using System.ComponentModel.DataAnnotations.Schema;
using static CoffeeShop.Enums.StatusEnums;

namespace CoffeeShop.Models
{
    public class Users
    {
        public int Id { get; set; }

        [Column(TypeName = "varchar(50)")]
        public required string Name { get; set; }

        [Column(TypeName = "varchar(25)")]
        public required string Email { get; set; }
        public required string Password { get; set; }

        [Column(TypeName = "int(10)")]
        public int Phone { get; set; }

        [Column(TypeName = "varchar(255)")]
        public required string Address { get; set; }
        public DateTime Created_At { get; set; }
        public DateTime Updated_At { get; set; }
        public UserStatus Status { get; set; }

        public int RoleId { get; set; }
    }
}
