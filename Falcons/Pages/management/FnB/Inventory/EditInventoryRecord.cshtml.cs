using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Falcons.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Falcons.Pages.management.FnB.Inventory
{
    public class EditInventoryRecordModel : PageModel
    {
        public readonly FalconsDBContext _context;

        [BindProperty]
        public FoodInventory FoodInventory { get; set; }

        public List<SelectListItem> FoodTypeOptions { get; set; }

        public EditInventoryRecordModel(FalconsDBContext context)
        {
            _context = context;
        }

        public IActionResult OnGet(int? id)
        {
            if(id == null)
            {
                return Redirect("/management/FnB/Inventory/Index");
            }

            FoodTypeOptions = _context.FoodTypes.Select(f => new SelectListItem
            {
                Value = f.FID.ToString(),
                Text = f.Title
            }).ToList();

            FoodInventory = _context.FoodInventories.Find(id);

            return Page();
        }

        public IActionResult OnPost(int? id)
        {
            if (id == null)
            {
                return Redirect("/management/FnB/Inventory/Index");
            }

            FoodTypeOptions = _context.FoodTypes.Select(f => new SelectListItem
            {
                Value = f.FID.ToString(),
                Text = f.Title
            }).ToList();

            _context.Attach(FoodInventory).State = EntityState.Modified;

            try
            {
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.FoodInventories.Any(e => e.RecordID == FoodInventory.RecordID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Page();
        }
    }
}
