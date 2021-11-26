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

<<<<<<< HEAD
        //public DbSet<Employee> Employee { get; set; }
=======
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeLeave> EmployeeLeaves { get; set; }
>>>>>>> b44e8906a0743d25fdff2d328db44db6879eaf18

        // ticket

        public DbSet<Booking> Booking { get; set; }

        public DbSet<BookedSeat> BookedSeats { get; set; }

<<<<<<< HEAD
        public DbSet<Showroom> Hall { get; set; }
=======
        // public DbSet<Ticket> Ticket { get; set; }

        // public DbSet<Seat> Seat { get; set; }

        //  public DbSet<Hall> Hall { get; set; }
>>>>>>> b44e8906a0743d25fdff2d328db44db6879eaf18

        // Movies
        public DbSet<MovieDetails> Movies { get; set; }
        public DbSet<Showtime> Showtime { get; set; }
    }
}
