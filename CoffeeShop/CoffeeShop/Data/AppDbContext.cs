using Microsoft.EntityFrameworkCore;
using CoffeeShop.Models;
namespace CoffeeShop.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Users> Users { get; set; }
        public DbSet<Order> Roles { get; set; }  
    }
}
