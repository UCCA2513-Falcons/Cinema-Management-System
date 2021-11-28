using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Falcons.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Falcons.Pages.Ticketing
{

    public class TicketingModel : PageModel
    {

        private readonly FalconsDBContext _context;

        public TicketingModel(FalconsDBContext context)
        {
            _context = context;
        }

        public int showtimeID { get; set; }
        public int movID { get; set; }

        public List<SelectListItem> movieOpt { get; set; }

        public List<SelectListItem> showTimeOpt { get; set; }

        public List<SelectListItem> showDateOpt { get; set; }

        public List<Booking> TBooking { get; set; }

        public bool bookFormError { get; set; }

        [BindProperty]
        public MovieDetails Movie { get; set; }

        [BindProperty]
        public Showtime showtime { get; set; }

        [BindProperty]
        public Booking booking { get; set; }

        [BindProperty]
        public BookedSeat bookedSeat { get; set; }

        [BindProperty]
        public SeatReservation SR { get; set; }

        
        public IEnumerable<SeatReservation> SRs { get; set; }
        public IEnumerable<Showtime> showtimes { get; set; }
        public IEnumerable<Booking> Bookings { get; set; }


        public List<MovieDetails> movies{ get; set; }


        public async Task<IActionResult> OnGetAsync()
        {
            Bookings = await _context.Booking.ToListAsync();
            movies = await _context.Movies.ToListAsync();
            showtimes = await _context.Showtime.ToListAsync();
            SRs = await _context.SeatReservation.ToListAsync();

            movieOpt = await _context.Movies.Select(m =>
                                           new SelectListItem
                                           {
                                               Value = m.MovieID.ToString(),
                                               Text = m.MovieName.ToString()
                                           }).ToListAsync();


            SelectListItem II = new SelectListItem
            {
                Text = "Select A Movie",
                Value = ""
            };

            movieOpt.Insert(0, II);

            return Page();

        }

        // book button



    }
}
