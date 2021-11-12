using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Falcons.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Falcons.Pages.management.FnB.Inventory
{
    public class DeleteModel : PageModel
    {
        public FalconsDBContext _context;

        public FoodType FoodType;

        public DeleteModel(FalconsDBContext context)
        {
            _context = context;
        }
        public IActionResult OnGet(int? id)
        {
            if (id == null)
            {
                //return NotFound();
                return Redirect("/management/FnB/Inventory/Index");
            }

            FoodType = _context.FoodTypes.FirstOrDefault(m => m.FID == id);

            if (FoodType == null)
            {
                return NotFound();
            }
            return Page();
        }

        public IActionResult OnPost(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            FoodType = _context.FoodTypes.Find(id);

            if (FoodType != null)
            {
                _context.FoodTypes.Remove(FoodType);
                _context.SaveChanges();
            }

            return RedirectToPage("./Index");
        }
    }
}
