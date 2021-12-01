using Falcons.Code;
using Falcons.Data;
using Falcons.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Falcons.Pages
{
    public class IndexModel : DI_BasePageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly FalconsDBContext _db;
        private readonly ApplicationDbContext AuthContext;
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
            _db = context;
            ServiceProvider = serviceProvider;
            AuthContext = authcontext;
        }

        public MovieDetails movies { get; set; }

        public IEnumerable<MovieDetails> Movies { get; set; }

        public async Task OnGet()
        {
            Movies = await _db.Movies.ToListAsync();


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



            if (!AuthContext.Users.Any())
            {
                var user = new IdentityUser
                {
                    UserName = "admin",
                    NormalizedUserName = "ADMIN",
                    NormalizedEmail = "ADMIN@1UTAR.MY",
                    EmailConfirmed = true,
                    Email = "admin@1utar.my",
                };

                var result = await UserManager.CreateAsync(user, "Admin@123");

                if (result.Succeeded)
                {
                    await UserManager.AddToRoleAsync(user, "Admin");
                }
            }
        }
    }
}
