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

namespace Falcons.Pages.management.HRM.Employees
{
    [Authorize(Roles = "Admin, Manager")]
    public class IndexModel : DI_BasePageModel
    {
        [BindProperty]
        public Employee NewEmployee { get; set; }

        public readonly FalconsDBContext _context;

        public List<SelectListItem> AllUser { get; set; }

        public List<Employee> EmployeeList;

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




        public async Task OnGet()
        {

            EmployeeList = _context.Employees.ToList();

            AllUser = new List<SelectListItem>();

            List<IdentityUser> users = UserManager.Users.ToList();

            foreach (var user in users)
            {
                IList<string> TheUser = await UserManager.GetRolesAsync(user);
                //insert the users have the role only
                if (TheUser.Contains("Admin") || TheUser.Contains("Manager") || TheUser.Contains("Staff"))
                {
                    //check if the user already in employee table
                    if (_context.Employees.Where(e => e.UID.Equals(user.Id)).FirstOrDefault() == null)
                    {
                        SelectListItem item = new SelectListItem { Text = user.Email, Value = user.Id };
                        AllUser.Add(item);
                    }
                }
            }
        }



        public IActionResult OnPostAddNewEmp()
        {

            if (NewEmployee.UID != null)
            {
                _context.Employees.Add(NewEmployee);
                _context.SaveChanges();
                return RedirectToPage("./Index");
            }


            EmployeeList = _context.Employees.ToList();
            return Page();
        }
    }
}
