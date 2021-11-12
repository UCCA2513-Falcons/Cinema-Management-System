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
    public class IndexModel : PageModel
    {
        public readonly FalconsDBContext _context;

        [BindProperty]
        public FoodInventory FoodInventory { get; set; }

        public List<FoodInventory> FoodInventories;

        [BindProperty]
        public FoodType FoodType { get; set; }

        public List<FoodType> AllFoodTypes;

        public List<SelectListItem> FoodTypeOptions { get; set; }

        [BindProperty]
        public int RecordID { get; set; }

        public IndexModel(FalconsDBContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            FoodInventories = _context.FoodInventories.ToList();
            AllFoodTypes = _context.FoodTypes.ToList();

            FoodTypeOptions = _context.FoodTypes.Select(f => new SelectListItem { 
                Value = f.FID.ToString(),
                Text = f.Title
            }).ToList();

            return Page();
        }

        public IActionResult OnPostCreateFoodType() {
            FoodInventories = _context.FoodInventories.ToList();
            AllFoodTypes = _context.FoodTypes.ToList();
            FoodTypeOptions = _context.FoodTypes.Select(f => new SelectListItem
            {
                Value = f.FID.ToString(),
                Text = f.Title
            }).ToList();

            if (FoodType != null)
            {
                _context.FoodTypes.Add(FoodType);
                _context.SaveChanges();
            }

            return Redirect("/management/FnB/Inventory/Index");
        }

        public IActionResult OnPostCreateFoodInventoryRecord()
        {
            FoodInventories = _context.FoodInventories.ToList();
            AllFoodTypes = _context.FoodTypes.ToList();
            FoodTypeOptions = _context.FoodTypes.Select(f => new SelectListItem
            {
                Value = f.FID.ToString(),
                Text = f.Title
            }).ToList();

            if (FoodInventory != null)
            {
                _context.FoodInventories.Add(FoodInventory);
                _context.SaveChanges();
            }

            return Redirect("/management/FnB/Inventory/Index");
        }

        public IActionResult OnPostDeleteFoodInventoryRecord()
        {
            FoodInventories = _context.FoodInventories.ToList();
            AllFoodTypes = _context.FoodTypes.ToList();
            FoodTypeOptions = _context.FoodTypes.Select(f => new SelectListItem
            {
                Value = f.FID.ToString(),
                Text = f.Title
            }).ToList();

            if(RecordID != 0)
            {
                FoodInventory FI = _context.FoodInventories.Find(RecordID);
                if(FI != null)
                {
                    _context.FoodInventories.Remove(FI);
                    _context.SaveChanges();
                }
            }

            return Redirect("/management/FnB/Inventory/Index");
        }
    }
}