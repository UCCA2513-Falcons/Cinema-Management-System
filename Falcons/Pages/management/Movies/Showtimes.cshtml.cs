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
using Microsoft.EntityFrameworkCore;

namespace Falcons.Pages.management.Movies
{

    [Authorize(Roles = "Admin, Manager")]
    public class ShowtimesModel : DI_BasePageModel
    {
        private readonly FalconsDBContext _db;
        protected IServiceProvider ServiceProvider { get; }

        public ShowtimesModel(FalconsDBContext db, ApplicationDbContext authcontext,
            IAuthorizationService authorizationService,
         UserManager<IdentityUser> userManager,
         RoleManager<IdentityRole> roleManager,
         IServiceProvider serviceProvider
            ) : base(authcontext, authorizationService, userManager, roleManager)
        {
            _db = db;

            ServiceProvider = serviceProvider;
        }

        [BindProperty]
        public Showtime showtimes { get; set; }

        public IEnumerable<Showtime> Showtimes { get; set; }
        public IEnumerable<MovieDetails> Movies { get; set; }
        public IEnumerable<Showroom> Showrooms { get; set; }


        public async Task OnGet()
        {
            Showtimes = await _db.Showtime.ToListAsync();
            Movies = await _db.Movies.ToListAsync();
            Showrooms = await _db.Hall.ToListAsync();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await _db.Showtime.AddAsync(showtimes);
            await _db.SaveChangesAsync();
            return RedirectToPage("/management/Movies/Showtimes");
        }

        public async Task<IActionResult> OnPostDelete(int id)
        {
            var showtime = await _db.Showtime.FindAsync(id);
            _db.Showtime.Remove(showtime);
            await _db.SaveChangesAsync();
            return RedirectToPage("/management/Movies/Showtimes");
        }
    }
}
