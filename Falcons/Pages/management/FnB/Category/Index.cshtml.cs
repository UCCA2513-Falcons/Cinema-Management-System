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

        public async Task OnGet()
        {
            category = _context.ProductCategories.ToList();

            var usr = await UserManager.GetUserAsync(User);

            var role = await RoleManager.FindByNameAsync("Admin");
            if (role == null)
            {
                await RoleManager.CreateAsync(new IdentityRole("Admin"));
            }

            await UserManager.AddToRoleAsync(usr, "Admin");
        }

        public void OnPost()
        {
            _context.ProductCategories.Add(NewPC);
            _context.SaveChanges();
            category = _context.ProductCategories.ToList();
        }
    }
}
