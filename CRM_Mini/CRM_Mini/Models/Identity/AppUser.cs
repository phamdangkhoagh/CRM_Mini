using Microsoft.AspNetCore.Identity;

namespace CRM_Mini.Models
{
    public class AppUser : IdentityUser
    {
        // Add additional properties if needed
        public string? FullName { get; set; } 
        public DateTime CreateAt { get; set; } = DateTime.UtcNow;
    }
}