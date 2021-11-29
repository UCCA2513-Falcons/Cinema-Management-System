using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Falcons.Code;
using Falcons.Data;
using Falcons.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Falcons.Pages.management.Movies
{

    [Authorize(Roles = "Admin, Manager")]

    public class EditShowroomModel : DI_BasePageModel
    {
        private readonly FalconsDBContext _db;
        protected IServiceProvider ServiceProvider { get; }

        private IWebHostEnvironment webHostEnvironment;



        public EditShowroomModel(FalconsDBContext db,
            IWebHostEnvironment WebHostEnvironment,
            ApplicationDbContext authcontext,
            IAuthorizationService authorizationService,
         UserManager<IdentityUser> userManager,
         RoleManager<IdentityRole> roleManager,
         IServiceProvider serviceProvider
            ) : base(authcontext, authorizationService, userManager, roleManager)
        {
            _db = db;
            ServiceProvider = serviceProvider;
            webHostEnvironment = WebHostEnvironment;

        }
        [BindProperty]
        public Showroom showroom { get; set; }

        public IEnumerable<Showroom> Showrooms { get; set; }


        public async Task OnGet(int id)
        {
            showroom = await _db.Hall.FindAsync(id);

        }

        public async Task<IActionResult> OnPost()
        {

            if (ModelState.IsValid)
            {
                var showr = await _db.Hall.FindAsync(showroom.ShowroomID);
                showr.ShowroomName = showroom.ShowroomName;

                await _db.SaveChangesAsync();
                return RedirectToPage("/management/Movies/AddShowroom");
            }
            else
            {
                return RedirectToPage();
            }
        }
    }
}
