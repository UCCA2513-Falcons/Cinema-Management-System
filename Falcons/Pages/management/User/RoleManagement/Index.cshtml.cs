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

namespace Falcons.Pages.management.User.RoleManagement
{
    [Authorize(Roles = "Admin, Manager")]
    public class IndexModel : DI_BasePageModel
    {
        [BindProperty]
        public string RoleName { get; set; }

        public string message { get; set; }

        public List<IdentityRole> AllRoles;

        private readonly FalconsDBContext _context;
        protected IServiceProvider ServiceProvider { get; }
        public IndexModel(
            FalconsDBContext context,
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
            AllRoles = RoleManager.Roles.ToList();
            return Page();
        }

        public async Task<IActionResult> OnPost()
        {
            if (!String.IsNullOrWhiteSpace(RoleName))
            {
                if(!await RoleManager.RoleExistsAsync(RoleName)) {
                    await RoleManager.CreateAsync(new IdentityRole(RoleName));
                }else
                {
                    message = "<div class='alert alert-warning' role='alert'>Role name already exists !</div>";
                }
            }

            AllRoles = RoleManager.Roles.ToList();
            return Page();
        }
    }
}
