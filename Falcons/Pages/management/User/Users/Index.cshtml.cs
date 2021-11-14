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
    [Authorize(Roles = "Admin, Manager")]
    public class IndexModel : DI_BasePageModel
    {
        public List<IdentityUser> AllUsers;
        public string message;
        [BindProperty]
        public string Email { get; set; }
        [BindProperty]
        public string Password { get; set; }
        [BindProperty]
        public string ConfirmPassword { get; set; }

        public UserManager<IdentityUser> UserManager1;

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
            UserManager1 = userManager;
        }
        public async Task OnGetAsync()
        {
            AllUsers = UserManager.Users.ToList();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            IdentityResult IR = null;

            if (!User.IsInRole("Admin"))
            {
                message = "<div class='alert alert-danger' role='alert'>Not enough privileges !</div>";
                AllUsers = UserManager.Users.ToList();
                return Page();
            }

            if (String.IsNullOrWhiteSpace(Email))
            {
                message += "<div class='alert alert-danger' role='alert'>Email is empty !</div>";
            }
            if (String.IsNullOrWhiteSpace(Password) || String.IsNullOrWhiteSpace(ConfirmPassword))
            {
                message += "<div class='alert alert-danger' role='alert'>Password or Confirm password is empty !</div>";
            }

            if (Password != ConfirmPassword)
            {
                message += "<div class='alert alert-danger' role='alert'>Confirm password did not match !</div>";
            }

            //proceed if everything is fine
            if(!String.IsNullOrWhiteSpace(Email) && (!String.IsNullOrWhiteSpace(Password) && !String.IsNullOrWhiteSpace(ConfirmPassword)) && (Password == ConfirmPassword))
            {
                var user = await UserManager.FindByEmailAsync(Email);
                if(user == null)
                {
                    user = new IdentityUser
                    {
                        UserName = Email,
                        EmailConfirmed = true,
                        Email = Email
                    };

                    IR = await UserManager.CreateAsync(user, Password);
                }

                if (!IR.Succeeded)
                {
                    string errorMsg = "";
                    foreach (IdentityError ie in IR.Errors)
                    {
                        errorMsg += ie.Description;
                    }

                    message += "<div class='alert alert-danger' role='alert'>" + errorMsg + "</div>";
                    
                }
            }

            //fetch all users list at the last once
            AllUsers = UserManager.Users.ToList();

            return Page();
        }
    }
}
