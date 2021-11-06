using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Falcons.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Falcons.Pages.management.FnB.Category
{

    public class IndexModel : PageModel
    {
        [BindProperty]
        public ProductCategory NewPC { get; set; }

        private readonly FalconsDBContext _context;

        public IndexModel(FalconsDBContext context)
        {
            _context = context;
        }

        public List<ProductCategory> category;

        public void OnGet()
        {
            category = _context.ProductCategories.ToList();
        }

        public void OnPost()
        {
            _context.ProductCategories.Add(NewPC);
            _context.SaveChanges();
            category = _context.ProductCategories.ToList();
        }
    }
}
