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
    public class EditInventoryRecordModel : DI_BasePageModel
    {
        public readonly FalconsDBContext _context;
        protected IServiceProvider ServiceProvider { get; }

        [BindProperty]
        public FoodInventory FoodInventory { get; set; }

        public List<SelectListItem> FoodTypeOptions { get; set; }

        public EditInventoryRecordModel(FalconsDBContext context,
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
