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
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
namespace Falcons.Pages.management.HRM
{
    [Authorize(Roles = "Admin, Manager")]
    public class IndexModel : DI_BasePageModel
    {
        public readonly FalconsDBContext _context;
        protected IServiceProvider ServiceProvider { get; }
        public List<SelectListItem> EmployeeOption { get; set; }

        [BindProperty]
        public Employee Employee { get; set; }

        public List<Employee> Allemployee { get; set; }

        public List<EmployeeLeave> EmployeeLeaves;
        [BindProperty]
        public EmployeeLeave EmployeeLeave { get; set; }

        public IndexModel(FalconsDBContext context,
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
        public async Task<IActionResult> OnGetAsync()
        {
            EmployeeOption = await _context.Employees.Select(c =>
                                    new SelectListItem
                                    {
                                        Value = c.EmpID.ToString(),
                                        Text = c.FName.ToString() + " " + c.LName.ToString()
                                    }).ToListAsync();

            Allemployee = await _context.Employees.ToListAsync();

            EmployeeLeaves = await _context.EmployeeLeaves.ToListAsync();

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {

            await _context.Employees.AddAsync(Employee);

            await _context.SaveChangesAsync();

            Allemployee = await _context.Employees.ToListAsync();

            EmployeeLeaves = await _context.EmployeeLeaves.ToListAsync();

            EmployeeOption = await _context.Employees.Select(c =>
                                    new SelectListItem
                                    {
                                        Value = c.EmpID.ToString(),
                                        Text = c.FName.ToString() + " " + c.LName.ToString()
                                    }).ToListAsync();

            return Page();
        }

        public async Task<IActionResult> OnPostEditLeaveAsync()
        {
            if (EmployeeLeave != null)
            {
                _context.EmployeeLeaves.Add(EmployeeLeave);
                _context.SaveChanges();
            }

            Allemployee = _context.Employees.ToList();

            EmployeeOption = await _context.Employees.Select(c =>
                                    new SelectListItem
                                    {
                                        Value = c.EmpID.ToString(),
                                        Text = c.FName.ToString() + " " + c.LName.ToString()
                                    }).ToListAsync();

            EmployeeLeaves = _context.EmployeeLeaves.ToList();

            return Page();
        }
    }
}
