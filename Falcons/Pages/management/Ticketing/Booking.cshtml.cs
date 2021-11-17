using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Falcons.Code;
using Falcons.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Falcons.Pages.management.Ticketing
{
    public class BookingModel : PageModel
    {
        public readonly FalconsDBContext _context;

        public BookingModel(FalconsDBContext context)
        {
            _context = context;
        }

        [BindProperty]

        public Booking Booking { get; set; }

        public List<Booking> BookingList { get; set; }

        public Int32 BID { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            BookingList = await _context.Booking.ToListAsync();
            return Page();
        }

        // add button is clicked
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Booking.Add(Booking);
            await _context.SaveChangesAsync();

            // await _context.booking.ToListAsync();

            return Page();

        }

        public IActionResult OnPostCancel()
        {

            TempData["message"] = "No record added";
            return Page();
        }
    }
}
