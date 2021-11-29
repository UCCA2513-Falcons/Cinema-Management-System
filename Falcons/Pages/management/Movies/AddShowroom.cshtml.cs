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

namespace Falcons.Pages.management.Movies
{
    [Authorize(Roles = "Admin, Manager")]

    public class AddShowroomModel : DI_BasePageModel
    {
        private readonly FalconsDBContext _db;
        protected IServiceProvider ServiceProvider { get; }

        public AddShowroomModel(FalconsDBContext db, ApplicationDbContext authcontext,
            IAuthorizationService authorizationService,
         UserManager<IdentityUser> userManager,
         RoleManager<IdentityRole> roleManager,
         IServiceProvider serviceProvider
            ) : base(authcontext, authorizationService, userManager, roleManager)
        {
            _db = db;

            ServiceProvider = serviceProvider;
        }

        [BindProperty]
        public Showroom showroom { get; set; }

        public IEnumerable<Showroom> Showrooms { get; set; }

        public async Task OnGet()
        {
            Showrooms = await _db.Hall.ToListAsync();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await _db.Hall.AddAsync(showroom);
            await _db.SaveChangesAsync();
            return RedirectToPage("/management/Movies/AddShowroom");
        }

        public async Task<IActionResult> OnPostDelete(int id)
        {
            var showroom = await _db.Hall.FindAsync(id);
            _db.Hall.Remove(showroom);
            await _db.SaveChangesAsync();
            return RedirectToPage("/management/Movies/AddShowroom");
   
        }
    }
}
