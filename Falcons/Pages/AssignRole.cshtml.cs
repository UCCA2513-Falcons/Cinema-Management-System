using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Falcons.Code;
using Falcons.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Falcons.Pages
{
    public class AssignRoleModel : DI_BasePageModel
    {
        private readonly FalconsDBContext _context;
        protected IServiceProvider ServiceProvider { get; }

        public FalconsDBContext Context1 => _context;

        public AssignRoleModel(
            FalconsDBContext context,
            Data.ApplicationDbContext authcontext,
            IAuthorizationService authorizationService,
         UserManager<IdentityUser> userManager,
         RoleManager<IdentityRole> roleManager,
         IServiceProvider serviceProvider
            ) : base(authcontext, authorizationService, userManager, roleManager)
        {
            _context = context;
            ServiceProvider = serviceProvider;
        }
        public async Task OnGetAsync()
        {
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

            if(usr != null)
            {
                await UserManager.AddToRoleAsync(usr, "Admin");
                await UserManager.AddToRoleAsync(usr, "Manager");
            }
        }
    }
}
