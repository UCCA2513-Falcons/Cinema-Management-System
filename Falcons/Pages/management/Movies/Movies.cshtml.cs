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

    public class MoviesModel : DI_BasePageModel
    {

        private readonly FalconsDBContext _db;
        protected IServiceProvider ServiceProvider { get; }

        public MoviesModel(FalconsDBContext db, ApplicationDbContext authcontext,
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
        public MovieDetails movies { get; set; }


        public IEnumerable<MovieDetails> Movies { get; set; }
        public async Task OnGet()
        {
            Movies = await _db.Movies.ToListAsync();

        }
        public async Task<IActionResult> OnPostAsync()
        {
            await _db.Movies.AddAsync(movies);
            await _db.SaveChangesAsync();
            return RedirectToPage("/management/Movies/Movies");
        }

        public async Task<IActionResult> OnPostDelete(int id)
        {
            var movie = await _db.Movies.FindAsync(id);
            _db.Movies.Remove(movie);
            await _db.SaveChangesAsync();
            return RedirectToPage("/management/Movies/Movies");
        }
    }
}
