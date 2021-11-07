using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Falcons.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Falcons.Pages.management.FnB.Inventory
{
    public class EditModel : PageModel
    {

        public FalconsDBContext _context;

        [BindProperty]
        public FoodType FoodType { get; set; }

        public EditModel(FalconsDBContext context)
        {
            _context = context;
        }

        public IActionResult OnGet(int? id)
        {
            if(id == null)
            {
                return Redirect("/management/FnB/Inventory/Index");
            }

            FoodType = _context.FoodTypes.Find(id);

            return Page();
        }

        public IActionResult OnPost(int? id)
        {
            

            if (id == null)
            {
                return Redirect("/management/FnB/Inventory/Index");
            }

            _context.Attach(FoodType).State = EntityState.Modified;

            try
            {
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.FoodTypes.Any(e => e.FID == FoodType.FID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            //return Page();
            return Redirect("/management/FnB/Inventory/Index");
        }
    }
}
