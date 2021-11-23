using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Falcons.Code;
using Falcons.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
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

        public Booking booking { get; set; }

        public IEnumerable<Booking> Booking { get; set; }

        public int BID { get; set; }

        // public List<SelectListItem> Options { get; set; }

        public async Task OnGet()
        {
            /* Options = await _context.Movies.Select(m =>
             new SelectListItem
             {
                 Value = m.MovieID.ToString(),
                 Text = m.MovieName.ToString()
             }).ToListAsync();

             SelectListItem initialItem = new SelectListItem
             { Text = "Select a movie", Value = "" };*/

            Booking = await _context.Booking.ToListAsync();

        }

        // add button is clicked
        public async Task<IActionResult> OnPostAsync()
        {
            /* if (!ModelState.IsValid)
             {
                 return Page();
             }*/

            //_context.Booking.Add(Booking);
            //await _context.SaveChangesAsync();

            // await _context.booking.ToListAsync();

            await _context.Booking.AddAsync(booking);
            await _context.SaveChangesAsync();
            return RedirectToPage("/management/Ticketing/Booking");

        }

        /*
        public IActionResult OnPostCancel()
        {

            TempData["message"] = "No record added";
            return Page();
        }*/

        /*public async Task<IActionResult> OnPostDelete(int id)
        {
            var bookings = await _context.Booking.FindAsync(id);
            _context.Booking.Remove(bookings);
            await _context.SaveChangesAsync();
            return RedirectToPage("/management/Ticketing/Booking");
        }*/

        public async Task<IActionResult> OnPostDelete(int ID)
        {
            var bookings = await _context.Booking.FindAsync(ID);
            _context.Booking.Remove(bookings);
            await _context.SaveChangesAsync();
            return RedirectToPage("/management/Ticketing/Booking");
        }
    }
}

