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
using Microsoft.EntityFrameworkCore;

namespace Falcons.Pages.management.FnB.Inventory
{
    [Authorize(Roles = "Admin, Manager, Staff")]
    public class EditModel : DI_BasePageModel
    {

        public FalconsDBContext _context;
        protected IServiceProvider ServiceProvider { get; }

        [BindProperty]
        public FoodType FoodType { get; set; }

        public EditModel(FalconsDBContext context,
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
