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

        public DbSet<FoodType> FoodType { get; set; }
        public DbSet<FoodInventory> FoodInventory { get; set; }

        public DbSet<ProductCategory> ProductCategory { get; set; }

        public DbSet<Product> Product { get; set; }

        public DbSet<Role> Role { get; set; }

        public DbSet<User> User { get; set; }
    }
}
