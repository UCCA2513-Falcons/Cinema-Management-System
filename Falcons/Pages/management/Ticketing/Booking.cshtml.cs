using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Falcons.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Falcons.Pages.management.Ticketing
{
    public class BookingModel : PageModel
    {
        public readonly FalconsDBContext _context;

        public void OnGet()
        {
        }
    }
}
