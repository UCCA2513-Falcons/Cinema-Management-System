using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Falcons.Models
{
    public class FalconsDBContext : DbContext
    {
        public FalconsDBContext(DbContextOptions<FalconsDBContext> options) : base(options) {
        }

        //User & Roles
        public DbSet<Role> Role { get; set; }
        public DbSet<User> User { get; set; }

        //Food and Beverages
        public DbSet<FoodType> FoodTypes { get; set; }
        public DbSet<FoodInventory> FoodInventories { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductDetails> ProductDetails { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<MenuItem> MenuItems { get; set; } 
        public DbSet<FnBOrder> FnBOrders { get; set; }
        public DbSet<FnBOrderDetail> FnBOrderDetails { get; set; }

        public DbSet<Employee> Employee { get; set; }

        // ticket

        public DbSet<Booking> Booking { get; set; }
        public DbSet<Ticket> Ticket { get; set; }

        /*protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<FnBOrderDetail>().HasKey(table => new { table.FnBOrder, table.Product});

            builder.Entity<FnBOrderDetail>()
                .HasOne(order => order.FnBOrder)
                .WithMany(order => order.FnBOrderDetails);

            builder.Entity<FnBOrderDetail>()
                .HasOne(product => product.Product)
                .WithMany(product => product.FnBOrderDetails);
        }*/
    }
}
