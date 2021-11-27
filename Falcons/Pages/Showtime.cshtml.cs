using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Falcons.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Falcons.Pages
{
    public class ShowtimeModel : PageModel
    {

        private readonly FalconsDBContext _db;

        public ShowtimeModel(FalconsDBContext db)
        {
            _db = db;
        }

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


  

    }
}
