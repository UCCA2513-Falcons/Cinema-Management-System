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

namespace Falcons.Pages.management.FnB.Inventory
{
    [Authorize(Roles = "Admin, Manager, Staff")]
    public class DeleteModel : DI_BasePageModel
    {
        public FalconsDBContext _context;
        protected IServiceProvider ServiceProvider { get; }

        public FoodType FoodType;

        public DeleteModel(FalconsDBContext context,
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
