using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Falcons.Code;
using Falcons.Data;
using Falcons.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
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

        private IWebHostEnvironment webHostEnvironment;



        public EditMovieModel(FalconsDBContext db,
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
        public MovieDetails movies { get; set; }

        [BindProperty]
        public IFormFile Poster { get; set; }
        public string UniqueFileName { get; set; }

        public async Task OnGet(int id)
        {
            movies = await _db.Movies.FindAsync(id);
        }

        public async Task<IActionResult> OnPost()
        {

            MovieDetails EditMovie = _db.Movies.Find(movies.MovieID);
            //string imgURL = "";

            //execute save image only if the image is uploaded when update detail
            if(Poster != null) {
                string UploadFolder = Path.Combine(webHostEnvironment.WebRootPath, "assets\\img\\movies");

                UniqueFileName = Guid.NewGuid().ToString() + "_" + Poster.FileName;
                string FilePath = Path.Combine(UploadFolder, UniqueFileName);
                using (var FileStream = new FileStream(FilePath, FileMode.Create))
                {
                    Poster.CopyTo(FileStream);
                    FileStream.Flush();
                }
            }

            

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
                //mov.Distributor = movies.Distributor;
                mov.ReleaseDate = movies.ReleaseDate;
                mov.Synopsis = movies.Synopsis;

                //save the image file name only if the image is uploaded
                if (Poster != null) {
                    EditMovie.MoviesImgURL = UniqueFileName;
                }

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
