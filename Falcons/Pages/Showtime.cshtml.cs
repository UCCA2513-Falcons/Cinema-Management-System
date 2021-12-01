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

        public List<List<Showtime>> Showtimes { get; set; }
        public List<int> MovieID { get; set; }
        public IEnumerable<MovieDetails> Movies { get; set; }
        public IEnumerable<Showroom> Showrooms { get; set; }


        public async Task OnGet()
        {
            Showtimes = new List<List<Showtime>>();
            List<Showtime> tempShowtime = await _db.Showtime.ToListAsync();
            MovieID = new List<int>();

            foreach (var item in _db.Showtime.Select(s=>s.MoviesMovieID).Distinct()) {
                MovieID.Add(item);
            }

            for(int i=0;i<MovieID.Count; i++)
            {
                List<Showtime> ShowtimeNestItem = new List<Showtime>();
                foreach(var item in tempShowtime)
                {
                    if(item.MoviesMovieID == MovieID[i]) {
                        ShowtimeNestItem.Add(item);
                    }
                }
                Showtimes.Add(ShowtimeNestItem);
            }

            Movies = await _db.Movies.ToListAsync();
            Showrooms = await _db.Hall.ToListAsync();
        }


  

    }
}
