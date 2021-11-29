using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Falcons.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Falcons.Pages.Ticketing
{

    [Authorize]

    public class TicketingModel : PageModel
    {

        private readonly FalconsDBContext _context;

        public TicketingModel(FalconsDBContext context)
        {
            _context = context;
        }

        public int showtimeID { get; set; }
        public int MovieID { get; set; }

        public List<SelectListItem> movieOpt { get; set; }

        public List<SelectListItem> showTimeOpt { get; set; }

        public List<SelectListItem> showDateOpt { get; set; }

        public List<Booking> bookings { get; set; }


        public bool bookformError { get; set; }


        [BindProperty]
        public MovieDetails MovieDetails { get; set; }

        [BindProperty]
        public Booking Booking { get; set; }

        [BindProperty]
        public SeatReservation SR { get; set; }
        
        [BindProperty]
        public Payment Payment { get; set; }

        [BindProperty]
        public Booking booking { get; set; }

        [BindProperty]
        public SeatReservation seatReservation { get; set; }


        public IEnumerable<Booking> Bookings { get; set; }
        public IEnumerable<SeatReservation> seatReservations { get; set; }
        public IEnumerable<Showtime> showtimes { get; set; }
        public List<MovieDetails> movies { get; set; }


        public async Task<IActionResult> OnGetAsync()
        {

            seatReservations = await _context.SeatReservation.ToListAsync();
            movies = await _context.Movies.ToListAsync();
            showtimes = await _context.Showtime.ToListAsync();
            Bookings = await _context.Booking.ToListAsync();


            movieOpt = await _context.Movies.Select(g =>
                 new SelectListItem
                 {
                     Value = g.MovieID.ToString(),
                     Text = g.MovieName.ToString()
                 }).ToListAsync();

            SelectListItem initialItem = new SelectListItem { Text = "Select a Movie", Value = "" };

            movieOpt.Insert(0, initialItem);

            return Page();

        }

        public async Task<IActionResult> OnPostAsync(int? MovieID, string btnUpdate)
        {
            seatReservations = await _context.SeatReservation.ToListAsync();
            Bookings = await _context.Booking.ToListAsync();

            // movie option

            movieOpt = await _context.Movies.Select(g =>
                          new SelectListItem
                          {
                              Value = g.MovieID.ToString(),
                              Text = g.MovieName.ToString()
                          }).ToListAsync();

            SelectListItem initialItem = new SelectListItem { Text = "Select Movie", Value = "" };

            movieOpt.Insert(0, initialItem);

            // show date option

            showDateOpt = await _context.Showtime.Where(m => m.MoviesMovieID == MovieID)
                .Select(g =>
            new SelectListItem
            {
                Value = g.StartDate.ToString(),
                Text = g.StartDate.ToString()
            }).Distinct().ToListAsync();

            SelectListItem initialItem1 = new SelectListItem { Text = "Select Date", Value = "" };

            showDateOpt.Insert(0, initialItem1);

            // show time option

            showTimeOpt = await _context.Showtime.Where(m => m.MoviesMovieID == MovieID)
                        .Select(g =>
             new SelectListItem
             {
                 Value = g.ShowtimeID.ToString(),
                 Text = g.StartTime.ToString()

             }).ToListAsync();

            SelectListItem initialItem2 = new SelectListItem { Text = "Select Time", Value = "" };

            showTimeOpt.Insert(0, initialItem2);



            if ((MovieID == null) && (btnUpdate == null))
            {
                ModelState.AddModelError("Movie.MovieName", "Select a valid Menu");

                return Page();
            }
            if (btnUpdate != null)
            {

                if (!ModelState.IsValid)
                {

                    await _context.Booking.AddAsync(booking);
                    await _context.SeatReservation.AddAsync(seatReservation);
                    await _context.Payments.AddAsync(Payment);

                    await _context.SaveChangesAsync();

                    return RedirectToPage("SeatBooking", new 
                    { 
                        id = Booking.ShowtimeID
                    });
                }

            }

            else
            {
                MovieDetails = _context.Movies.Where(g => g.MovieID == MovieID).SingleOrDefault();
                return Page();
            }

            return Page();

        }



        // book button



    }
}
