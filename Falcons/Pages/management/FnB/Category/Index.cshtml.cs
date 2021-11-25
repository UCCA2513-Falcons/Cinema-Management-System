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

namespace Falcons.Pages.management.FnB.Category
{
    [Authorize(Roles = "Admin, Manager")]
    public class IndexModel : DI_BasePageModel
    {
        [BindProperty]
        public ProductCategory NewPC { get; set; }

        private readonly FalconsDBContext _context;
        protected IServiceProvider ServiceProvider { get; }
        public IndexModel(
            FalconsDBContext context,
            ApplicationDbContext authcontext,
            IAuthorizationService authorizationService,
         UserManager<IdentityUser> userManager,
         RoleManager<IdentityRole> roleManager,
         IServiceProvider serviceProvider
            ): base(authcontext, authorizationService, userManager, roleManager)
        {
            _context = context;
            ServiceProvider = serviceProvider;
        }

        public List<ProductCategory> category;

        public string message { get; set; }

        public async Task OnGet()
        {
            category = _context.ProductCategories.ToList();

            var usr = await UserManager.GetUserAsync(User);

            var role = await RoleManager.FindByNameAsync("Admin");
            if (role == null)
            {
                await RoleManager.CreateAsync(new IdentityRole("Admin"));
            }

            //add role for manager
            var ManagerRole = await RoleManager.FindByNameAsync("Manager");
            if (ManagerRole == null)
            {
                await RoleManager.CreateAsync(new IdentityRole("Manager"));
            }

            //add role for staff
            var StaffRole = await RoleManager.FindByNameAsync("Staff");
            if (StaffRole == null)
            {
                await RoleManager.CreateAsync(new IdentityRole("Staff"));
            }

            //add role for user
            var UserRole = await RoleManager.FindByNameAsync("User");
            if (UserRole == null)
            {
                await RoleManager.CreateAsync(new IdentityRole("User"));
            }

            /*await UserManager.AddToRoleAsync(usr, "Admin");
            await UserManager.AddToRoleAsync(usr, "Manager");*/
        }

        public async Task OnPostAsync()
        {
            var user = await UserManager.GetUserAsync(User);
            IList<string> userRole = await UserManager.GetRolesAsync(user);

            bool admin = false;

            for (int i = 0; i < userRole.Count; i++) {
                if (userRole[i].Equals("Admin")) {
                    admin = true;
                    break;
                }
            }

            if (admin) {
                if (String.IsNullOrWhiteSpace(NewPC.CategoryName))
                {
                    // no input is received
                    message = message + "<div class='alert alert-danger' role='alert' style='margin-top:1rem; margin-bottom:1rem;'>Category name is requried !</div>";
                }
                else
                {
                    _context.ProductCategories.Add(NewPC);
                    _context.SaveChanges();
                }
            }
            else
            {
                message = message + "<div class='alert alert-danger' role='alert' style='margin-top:1rem; margin-bottom:1rem;'>You don't have enough privileges !</div>";
            }
            
            category = _context.ProductCategories.ToList();
        }
    }
}
