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
    [Authorize(Roles = "Admin, Manager")]
    public class IndexModel : DI_BasePageModel
    {
        [BindProperty]
        public Employee NewEmployee { get; set; }

        public readonly FalconsDBContext _context;

        protected IServiceProvider ServiceProvider { get; }

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

        public List<Employee> EmployeeList;

        public async Task OnGet()
        {
            EmployeeList = _context.Employees.ToList();

        }

        public void OnPost()
        {
            

            EmployeeList = _context.Employees.ToList();
        }
    }
}
