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
using Microsoft.EntityFrameworkCore;

namespace Falcons.Pages.management.User.Users
{
    [Authorize(Roles = "Admin, Manager")]
    public class EditModel : DI_BasePageModel
    {
        public IdentityUser user { get; set; }
        [BindProperty]
        public List<string> Role { get; set; }

        public List<string> AllRole;
        [BindProperty]
        public string Username { get; set; }
        [BindProperty]
        public string Email { get; set; }
        [BindProperty]
        public string PhoneNumber { get; set; }
        [BindProperty]
        public string UserId { get; set; }

        public UserManager<IdentityUser> UserManager1;

        private readonly FalconsDBContext _context;
        protected IServiceProvider ServiceProvider { get; }
        public EditModel(FalconsDBContext context,
            ApplicationDbContext authcontext,
            IAuthorizationService authorizationService,
            UserManager<IdentityUser> userManager,
            RoleManager<IdentityRole> roleManager,
            IServiceProvider serviceProvider) : base(authcontext, authorizationService, userManager, roleManager)
        {
            _context = context;
            ServiceProvider = serviceProvider;
            UserManager1 = userManager;
        }
            
        public IActionResult OnGet(string? id)
        {
            if (!String.IsNullOrWhiteSpace(id)) {
                user = UserManager.Users.Where(u => u.Id == id).FirstOrDefault();
                //return Page();
                AllRole = RoleManager.Roles.Select(r=>r.Name).ToList();
                
            }
            else
            {
                TempData["message"] += "<div class='col-md-12'><div class='alert alert-warning' role='alert' style='margin-top:1rem; margin-bottom:1rem;'>The user profile you are trying to access is not exists !</div></div>";
                return Redirect("/management/User/Users");
            }

            return Page();
        }

        public async Task<IActionResult> OnPost(string? id) {

            if (!String.IsNullOrWhiteSpace(id))
            {
                AllRole = RoleManager.Roles.Select(r => r.Name).ToList();
                user = await UserManager.FindByIdAsync(id);
                if (user != null)
                {
                    //var status = await UserManager.UpdateAsync(user);
                    /*if (status.Succeeded) {
                        TempData["message"] += "<div class='col-md-12'><div class='alert alert-success' role='alert' style='margin-top:1rem; margin-bottom:1rem;'>User profile updated !</div></div>";
                    }*/

                    if (!String.IsNullOrWhiteSpace(Username)) {
                        var setUsernameResult = await UserManager.SetUserNameAsync(user, Username);
                        if (!setUsernameResult.Succeeded)
                        {
                            TempData["message"] += "<div class='col-md-12'><div class='alert alert-danger' role='alert' style='margin-top:1rem; margin-bottom:1rem;'>Unexpected error when trying to set username.</div></div>";
                            return RedirectToPage();
                        }
                        else{
                            TempData["message"] += "<div class='col-md-12'><div class='alert alert-success' role='alert' style='margin-top:1rem; margin-bottom:1rem;'>Username is updated.</div></div>";
                        }
                    }
                    else
                    {
                        TempData["message"] += "<div class='col-md-12'><div class='alert alert-danger' role='alert' style='margin-top:1rem; margin-bottom:1rem;'>Blank username is not allowed.</div></div>";
                    }

                    if (!String.IsNullOrWhiteSpace(Email))
                    {
                        if (!user.Email.Equals(Email)) {
                            var setEmailResult = await UserManager.SetEmailAsync(user, Email);
                            //set the email confirmed
                            user.EmailConfirmed = true;
                            await UserManager.UpdateAsync(user);
                            
                            if (!setEmailResult.Succeeded)
                            {
                                TempData["message"] += "<div class='col-md-12'><div class='alert alert-danger' role='alert' style='margin-top:1rem; margin-bottom:1rem;'>Unexpected error when trying to set email.</div></div>";
                                return RedirectToPage();
                            }
                            else
                            {
                                TempData["message"] += "<div class='col-md-12'><div class='alert alert-success' role='alert' style='margin-top:1rem; margin-bottom:1rem;'>Email is updated.</div></div>";
                            }
                        }
                    }
                    else
                    {
                        TempData["message"] += "<div class='col-md-12'><div class='alert alert-danger' role='alert' style='margin-top:1rem; margin-bottom:1rem;'>Blank email is not allowed.</div></div>";
                    }

                    if (!String.IsNullOrWhiteSpace(PhoneNumber))
                    {
                        var setPhoneNumberResult = await UserManager.SetEmailAsync(user, PhoneNumber);
                        if (!setPhoneNumberResult.Succeeded)
                        {
                            TempData["message"] += "<div class='col-md-12'><div class='alert alert-danger' role='alert' style='margin-top:1rem; margin-bottom:1rem;'>Unexpected error when trying to set Phone Number.</div></div>";
                            return RedirectToPage();
                        }
                        else
                        {
                            TempData["message"] += "<div class='col-md-12'><div class='alert alert-success' role='alert' style='margin-top:1rem; margin-bottom:1rem;'>Phone Number is updated.</div></div>";
                        }
                    }

                    var usr = UserManager.Users.Where(u => u.Id == user.Id).FirstOrDefault();

                    foreach (var item in AllRole) {
                        if (Role.Contains(item))
                        {
                            await UserManager.AddToRoleAsync(usr, item);
                        }
                        else {
                            //UserManager.GetRolesAsync(await UserManager.FindByIdAsync(id)).Result.ToArray();
                            await UserManager.RemoveFromRoleAsync(usr, item);
                        }
                    }

                }

                user = UserManager.Users.Where(u => u.Id == id).FirstOrDefault();
                //return Page();
                AllRole = RoleManager.Roles.Select(r => r.Name).ToList();
                
            }
            else
            {
                TempData["message"] += "<div class='col-md-12'><div class='alert alert-warning' role='alert' style='margin-top:1rem; margin-bottom:1rem;'>The user profile you are trying to access is not exists !</div></div>";
                return Redirect("/management/User/Users");
            }

            return Page();
        }
    }
}
