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

namespace Falcons.Pages.management.HRM.Salaries
{
    [Authorize(Roles = "Admin, Manager, Staff")]
    public class PaySlipModel : DI_BasePageModel
    {
        private readonly FalconsDBContext _context;
        protected IServiceProvider ServiceProvider { get; }

        
        public Employee Employee;

        public List<Employee> EmployeeDetails;

        public PaySlipModel(FalconsDBContext context,
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

        public IActionResult OnGet(int? id)
        {
            if (id == null)
            {
                return Redirect("/FnB/Menu");
            }
            Employee = _context.Employees.Find(id);
            EmployeeDetails = _context.Employees.Where(pd => pd.EmpID == id).ToList();

            return Page();
        }
    }
}
