using Microsoft.EntityFrameworkCore;
using CoffeeShop.Models;

namespace CoffeeShop.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Cart> Cart { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderDetail> OrderDetail { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<Coupon> Coupon { get; set; }
        public DbSet<CouponDetail> CouponDetail{ get; set; }
        public DbSet<Notification> Notification { get; set; }
        public DbSet<CartItem> CartItem { get; set; }
        public DbSet<Payment> Payment { get; set; }
    }
}
