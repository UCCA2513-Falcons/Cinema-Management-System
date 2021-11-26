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
using Microsoft.Extensions.DependencyInjection;

namespace Falcons.Pages.management.HRM.Leaves
{
    [Authorize(Roles = "Admin")]
    public class DeleteModel : DI_BasePageModel
    {
        private readonly FalconsDBContext _context;

        [BindProperty]

        public EmployeeLeave EmployeeLeave { get; set; }
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

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            EmployeeLeave = await _context.EmployeeLeaves.FirstOrDefaultAsync(m => m.EmpLeaveID == id);

            if (EmployeeLeave == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            EmployeeLeave = await _context.EmployeeLeaves.FindAsync(id);

            if (EmployeeLeave != null)
            {
                _context.EmployeeLeaves.Remove(EmployeeLeave);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
