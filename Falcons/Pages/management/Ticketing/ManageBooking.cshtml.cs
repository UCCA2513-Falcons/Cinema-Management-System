using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Falcons.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Falcons.Pages.management.Ticketing
{
    public class ManageBookingModel : PageModel
    {

        private readonly FalconsDBContext _context;

        public ManageBookingModel(FalconsDBContext context)
        {
            _context = context;
        }

        public IEnumerable<MovieDetails> MovieDetails { get; set; }
        public IEnumerable<Booking> Bookings { get; set; }
        public IEnumerable<Showtime> Showtimes { get; set; }
        public IEnumerable<Showroom> Showrooms { get; set; }

        public async Task OnGet()
        {
            MovieDetails = await _context.Movies.ToListAsync();
            Showtimes = await _context.Showtime.ToListAsync();
            Bookings = await _context.Booking.ToListAsync();
            Showrooms = await _context.Hall.ToListAsync();
        }

        public async Task<IActionResult> OnPostDelete(int id)
        {
            var bookings = await _context.Booking.FindAsync(id);
            if(bookings == null)
            {
                return NotFound();
            }

            _context.Booking.Remove(bookings);
            await _context.SaveChangesAsync();
            return RedirectToPage("/management/Ticketing/ManageBooking");
        }

    }
}
