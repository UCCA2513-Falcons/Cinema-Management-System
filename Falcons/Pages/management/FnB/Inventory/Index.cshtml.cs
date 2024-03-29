using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Falcons.Code;
using Falcons.Data;
using Falcons.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Falcons.Pages.management.FnB.Inventory
{
    [Authorize(Roles = "Admin, Manager, Staff")]
    public class IndexModel : DI_BasePageModel
    {
        public readonly FalconsDBContext _context;
        protected IServiceProvider ServiceProvider { get; }

        [BindProperty]
        public FoodInventory FoodInventory { get; set; }

        public List<FoodInventory> FoodInventories;

        [BindProperty]
        public FoodType FoodType { get; set; }

        public List<FoodType> AllFoodTypes;

        public List<SelectListItem> FoodTypeOptions { get; set; }

        [BindProperty]
        public int RecordID { get; set; }

        public IndexModel(FalconsDBContext context,
            ApplicationDbContext authcontext,
            IAuthorizationService authorizationService,
         UserManager<IdentityUser> userManager,
         RoleManager<IdentityRole> roleManager,
         IServiceProvider serviceProvider
            ) : base(authcontext, authorizationService, userManager, roleManager)
        {
            _context = context;
            ServiceProvider = serviceProvider;
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
                bool complete = true;

                if (String.IsNullOrWhiteSpace(FoodType.Title)) {
                    complete = false;
                    TempData["message"] += "<div class='col-md-12'><div class='alert alert-danger' role='alert' style='margin-top:1rem; margin-bottom:1rem;'>Food inventory item is empty !</div></div>";
                } 

                if (String.IsNullOrWhiteSpace(FoodType.Type)) {
                    complete = false;
                    TempData["message"] += "<div class='col-md-12'><div class='alert alert-danger' role='alert' style='margin-top:1rem; margin-bottom:1rem;'>Food inventory type is empty !</div></div>";
                }

                if(complete)
                {
                    _context.FoodTypes.Add(FoodType);
                    _context.SaveChanges();
                    TempData["message"] = "<div class='col-md-12'><div class='alert alert-success' role='alert' style='margin-top:1rem; margin-bottom:1rem;'>Successfully created food inventory type !</div></div>";
                }
                
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
                TempData["message"] = "<div class='col-md-12'><div class='alert alert-success' role='alert' style='margin-top:1rem; margin-bottom:1rem;'>Successfully created food inventory record !</div></div>";
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
                    TempData["message"] = "<div class='col-md-12'><div class='alert alert-success' role='alert' style='margin-top:1rem; margin-bottom:1rem;'>Food inventory record is deleted !</div></div>";
                }
            }

            return Redirect("/management/FnB/Inventory/Index");
        }
    }
}
