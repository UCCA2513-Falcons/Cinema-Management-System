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
    [Authorize(Roles = "Admin")]
    public class DeleteModel : DI_BasePageModel
    {
        public IdentityRole identityRole;
        [BindProperty]
        public string RoleID { get; set; }

        private readonly FalconsDBContext _context;
        protected IServiceProvider ServiceProvider { get; }
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

        public async Task<IActionResult> OnGet(string? id)
        {
            if (String.IsNullOrWhiteSpace(id))
            {
                return Redirect("/management/User/RoleManagement/Index");
            }

            identityRole = await RoleManager.FindByIdAsync(id);

            return Page();
        }

        public async Task<IActionResult> OnPost()
        {
            if (!String.IsNullOrWhiteSpace(RoleID))
            {
                var role = await RoleManager.FindByIdAsync(RoleID);
                if (role != null)
                {
                    await RoleManager.DeleteAsync(role);
                }
            }
            return Redirect("/management/User/RoleManagement/Index");
        }
    }
}
