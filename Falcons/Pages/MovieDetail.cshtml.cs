using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Falcons.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Falcons.Pages
{
    public class MovieDetailModel : PageModel
    {
        private readonly FalconsDBContext _db;

        [BindProperty]
        public MovieDetails movies { get; set; }


        public MovieDetailModel(FalconsDBContext db)
        {
            _db = db;
        }
        public async Task OnGet(int id)
        {
            movies = await _db.Movies.FindAsync(id);
        }
    }
}
