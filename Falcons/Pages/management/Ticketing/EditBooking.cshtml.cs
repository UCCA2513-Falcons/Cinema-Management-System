using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Falcons.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Falcons.Pages.management.Ticketing
{
    public class EditBookingModel : PageModel
    {

        private readonly FalconsDBContext _context;
        public EditBookingModel(FalconsDBContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Booking booking { get; set; }


        public async Task OnGet(int id)
        {
            booking = await _context.Booking.FindAsync(id);
        }

        public async Task <IActionResult> OnPost()
        {
            if(ModelState.IsValid)
            {
                var b = await _context.Booking.FindAsync(booking.ID);
                b.email = booking.email;
                b.movieName = booking.movieName;
                b.bookingDateTime = booking.bookingDateTime;
                b.showDateTime = booking.showDateTime;
                b.amount = booking.amount;

                await _context.SaveChangesAsync();
                return RedirectToPage("/management/Ticketing/Booking");
            }
            else
            {
                return RedirectToPage();
            }
        }
    }
}
