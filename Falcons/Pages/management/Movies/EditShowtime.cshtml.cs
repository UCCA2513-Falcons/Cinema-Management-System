using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Falcons.Code;
using Falcons.Data;
using Falcons.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Falcons.Pages.management.Movies

{
    [Authorize(Roles = "Admin, Manager")]

    public class EditShowtimeModel : DI_BasePageModel
    {
        private readonly FalconsDBContext _db;
        protected IServiceProvider ServiceProvider { get; }

        private IWebHostEnvironment webHostEnvironment;



        public EditShowtimeModel(FalconsDBContext db,
            IWebHostEnvironment WebHostEnvironment,
            ApplicationDbContext authcontext,
            IAuthorizationService authorizationService,
         UserManager<IdentityUser> userManager,
         RoleManager<IdentityRole> roleManager,
         IServiceProvider serviceProvider
            ) : base(authcontext, authorizationService, userManager, roleManager)
        {
            _db = db;
            ServiceProvider = serviceProvider;
            webHostEnvironment = WebHostEnvironment;

        }
        [BindProperty]
        public Showtime showtimes { get; set; }


        public IEnumerable<Showtime> Showtimes { get; set; }
        public IEnumerable<MovieDetails> Movies { get; set; }
        public IEnumerable<Showroom> Showrooms { get; set; }


        public async Task OnGet(int id)
        {
            showtimes = await _db.Showtime.FindAsync(id);
            Showrooms = await _db.Hall.ToListAsync();
            Movies = await _db.Movies.ToListAsync();
            //movies = await _db.Movies.ToListAsync();
            //showrooms = await _db.Hall.ToListAsync();
        }

        public async Task<IActionResult> OnPost()
        {

            if (ModelState.IsValid)
            {
                var showt = await _db.Showtime.FindAsync(showtimes.ShowtimeID);
                showt.StartDate = showtimes.StartDate;
                showt.StartTime = showtimes.StartTime;
                showt.MoviesMovieID = showtimes.MoviesMovieID;
                showt.ShowroomID = showtimes.ShowroomID;

                await _db.SaveChangesAsync();
                return RedirectToPage("/management/Movies/Showtimes");
            }
            else
            {
                return RedirectToPage();
            }
        }
    }
}
