using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Falcons.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Falcons.Pages.FnB
{
    public class MenuModel : PageModel
    {
        private readonly FalconsDBContext _context;
        public List<Menu> Menus;
        public List<Product> Products;
        public MenuModel(FalconsDBContext context)
        {
            _context = context;
        }
        public IActionResult OnGet()
        {
            Menus = _context.Menus.ToList();
            Products = _context.Products.ToList();
            return Page();
        }

    }
}
