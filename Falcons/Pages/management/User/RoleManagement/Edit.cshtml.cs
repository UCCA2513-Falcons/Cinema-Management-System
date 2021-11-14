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
    public class EditModel : DI_BasePageModel
    {
        public string message;

        [BindProperty]
        public string EditedRoleID { get; set; }
        [BindProperty]
        public string EditedRoleName { get; set; }
        public IdentityRole identityRole;

        private readonly FalconsDBContext _context;
        protected IServiceProvider ServiceProvider { get; }
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
        public async Task<IActionResult> OnGetAsync(string? id)
        {
            if (String.IsNullOrWhiteSpace(id))
            {
                return Redirect("/management/User/RoleManagement/Index");
            }

            identityRole = await RoleManager.FindByIdAsync(id);

            return Page();
        }

        public async Task<IActionResult> OnPostAsync() {
            if(EditedRoleID != null && EditedRoleName != null)
            {
                //find out the role first
                var targetRole = await RoleManager.FindByIdAsync(EditedRoleID);
                if(targetRole != null)
                {
                    //assign the new role name to it
                    targetRole.Name = EditedRoleName;
                    //update it to the identity database
                    await RoleManager.UpdateAsync(targetRole);
                    identityRole = await RoleManager.FindByIdAsync(targetRole.Id);

                    message = "<div class='alert alert-success' role='alert'>Role name already updated !</div>";

                    //return Redirect("/management/User/RoleManagement/Edit?id="+ EditedRole.Id);
                    return Page();
                }
                return Redirect("/management/User/RoleManagement/Index");
            }
            return Redirect("/management/User/RoleManagement/Index");
        }
    }
}
