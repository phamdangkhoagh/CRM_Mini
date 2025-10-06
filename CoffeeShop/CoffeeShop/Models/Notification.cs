using System.ComponentModel.DataAnnotations.Schema;
using static CoffeeShop.Enums.StatusEnums;

namespace CoffeeShop.Models
{
    public class Notification
    {
        public int Id { get; set; }
        public int UserId { get; set; }

        [Column(TypeName = "varchar(25)")]
        public required string Type { get; set; }

        [Column(TypeName = "varchar(255)")]
        public required string Message { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsRead { get; set; }
        public NotificationStatus Status { get; set; }
    }
}
