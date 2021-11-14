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

namespace Falcons.Pages.management.User.Users
{
    [Authorize(Roles = "Admin")]
    public class DeleteModel : DI_BasePageModel
    {
        public IdentityUser IdentityUser;

        [BindProperty]
        public string ID { get; set; }

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

        public async Task<IActionResult> OnGetAsync(string? id)
        {
            if (String.IsNullOrWhiteSpace(id))
            {
                return Redirect("/management/User/Users/Index");
            }

            //IdentityUser = await UserManager.GetUserAsync(User);
            IdentityUser = await UserManager.FindByIdAsync(id);

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!String.IsNullOrWhiteSpace(ID))
            {
                IdentityUser targetUser = await UserManager.FindByIdAsync(ID);
                if(targetUser != null)
                {
                    await UserManager.DeleteAsync(targetUser);
                }
            }
            return Redirect("/management/User/Users/Index");
        }
    }
}
