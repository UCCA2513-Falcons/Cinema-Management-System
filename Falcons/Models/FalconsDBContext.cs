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
        public DbSet<FoodType> FoodType { get; set; }
        public DbSet<FoodInventory> FoodInventory { get; set; }
        public DbSet<ProductCategory> ProductCategory { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Menu> Menu { get; set; }
        public DbSet<MenuItem> MenuItem { get; set; } 
        public DbSet<FnBOrder> FnBOrder { get; set; }
        public DbSet<FnBOrderDetail> FnBOrderDetail { get; set; }

        public DbSet<Employee> Employee { get; set; }

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
