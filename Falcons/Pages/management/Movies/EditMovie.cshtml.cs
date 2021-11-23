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

namespace Falcons.Pages.management.Movies
{
    [Authorize(Roles = "Admin, Manager")]

    public class EditMovieModel : DI_BasePageModel
    {
        private readonly FalconsDBContext _db;
        protected IServiceProvider ServiceProvider { get; }



        public EditMovieModel(FalconsDBContext db,

            ApplicationDbContext authcontext,
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

        public async Task OnGet(int id)
        {
            movies = await _db.Movies.FindAsync(id);
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                var mov = await _db.Movies.FindAsync(movies.MovieID);
                mov.MovieName = movies.MovieName;
                mov.Language = movies.Language;
                mov.Subtitle = movies.Subtitle;
                mov.Duration = movies.Duration;
                mov.Genre = movies.Genre;
                mov.Category = movies.Category;
                mov.Director = movies.Director;
                mov.Cast = movies.Cast;
                mov.Distributor = movies.Distributor;
                mov.ReleaseDate = movies.ReleaseDate;
                mov.Synopsis = movies.Synopsis;

                await _db.SaveChangesAsync();
                return RedirectToPage("/management/Movies/Movies");
            }
            else
            {
                return RedirectToPage();
            }
        }
    }
}
