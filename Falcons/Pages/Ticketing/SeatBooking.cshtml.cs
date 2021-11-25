using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Falcons.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Falcons.Pages.Ticketing
{
    public class SeatBookingModel : PageModel
    {

        FalconsDBContext _context;

        public List<BookedSeat> BookedSeats { get; set; }

        public SeatBookingModel(FalconsDBContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> OnGetAsync()
        {
            BookedSeats = await _context.BookedSeats.ToListAsync();

            return Page();
        }
    }
}
