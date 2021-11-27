using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Falcons.Code;
using Falcons.Data;
using Falcons.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Falcons.Pages.management.Ticketing
{
    
    [Authorize(Roles = "Admin, Manager")]
    public class BookingModel : DI_BasePageModel
    {
       
        public readonly FalconsDBContext _context;

        protected IServiceProvider ServiceProvider { get; }

        public BookingModel(FalconsDBContext context, ApplicationDbContext authcontext,
            IAuthorizationService authorizationService,
         UserManager<IdentityUser> userManager,
         RoleManager<IdentityRole> roleManager,
         IServiceProvider serviceProvider
            ) : base(authcontext, authorizationService, userManager, roleManager)
        {
            _context = context;

            ServiceProvider = serviceProvider;
        }

        [BindProperty]

        public Booking booking { get; set; }

        public IEnumerable<Booking> Booking { get; set; }
        public IEnumerable<Showtime> Showtime{ get; set; }
        public IEnumerable<MovieDetails> Movies { get; set; }

     

        // public List<SelectListItem> Options { get; set; }

        public async Task OnGet()
        {
            
            Booking = await _context.Booking.ToListAsync();
            Showtime = await _context.Showtime.ToListAsync();
            Movies = await _context.Movies.ToListAsync();

        }

        // add button is clicked
        /*public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
             {
                 return Page();
             }

            //_context.Booking.Add(Booking);
            //await _context.SaveChangesAsync();

            // await _context.booking.ToListAsync();

            await _context.Booking.AddAsync(booking);
            await _context.SaveChangesAsync();
            return RedirectToPage("/management/Ticketing/Booking");

        }*/

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

