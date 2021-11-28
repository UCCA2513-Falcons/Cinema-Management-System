using Falcons.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Falcons.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly FalconsDBContext _db;

        public IndexModel(ILogger<IndexModel> logger, FalconsDBContext db)
        {
            _logger = logger;
            _db = db;
        }

        public MovieDetails movies { get; set; }

        public IEnumerable<MovieDetails> Movies { get; set; }

        public async Task OnGet()
        {
            Movies = await _db.Movies.ToListAsync();
        }
    }
}
