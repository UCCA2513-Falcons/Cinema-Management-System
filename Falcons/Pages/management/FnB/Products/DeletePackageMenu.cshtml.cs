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

namespace Falcons.Pages.management.FnB.Products
{
    [Authorize(Roles = "Admin, Manager")]
    public class DeletePackageMenuModel : DI_BasePageModel
    {
        public FalconsDBContext _context;
        protected IServiceProvider ServiceProvider { get; }

        public Menu Menu;

        public DeletePackageMenuModel(FalconsDBContext context,
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
                return Redirect("/management/FnB/Products");
            }

            Menu = _context.Menus.Find(id);

            if(Menu == null)
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
            Menu = _context.Menus.Find(id);

            if(Menu != null)
            {
                /*foreach(var item in _context.MenuItems.Where(i=>i.MenuID == id))
                {
                    _context.MenuItems.Remove(item);
                }*/

                _context.Menus.Remove(Menu);
                _context.SaveChanges();
            }
            return Redirect("/management/FnB/Products");
        }
    }
}
