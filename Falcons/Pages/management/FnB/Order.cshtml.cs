using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Falcons.Code;
using Falcons.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Falcons.Pages.management.FnB
{
    [Authorize(Roles = "Admin, Manager, Staff")]
    public class OrderModel : DI_BasePageModel
    {
        public List<FnBOrder> FnBOrders;

        public readonly FalconsDBContext _context;
        protected IServiceProvider ServiceProvider { get; }
        public OrderModel(FalconsDBContext context,
            Data.ApplicationDbContext authcontext,
            IAuthorizationService authorizationService,
            UserManager<IdentityUser> userManager,
            RoleManager<IdentityRole> roleManager,
            IServiceProvider serviceProvider
        ) : base(authcontext, authorizationService, userManager, roleManager)
        {
            _context = context;
            ServiceProvider = serviceProvider;
        }

        public async Task OnGetAsync()
        {
            UserManager.SetUserNameAsync(await UserManager.GetUserAsync(User), "Reset Username");
            FnBOrders = await _context.FnBOrders.OrderByDescending(f => f.FnBOrderID).ToListAsync();
        }
    }
}
