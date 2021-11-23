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

namespace Falcons.Pages
{
    public class HistoryModel : DI_BasePageModel
    {
        public List<FnBOrder> FnBOrders;
        public List<FnBOrderDetail> FnBOrderDetails;

        public readonly FalconsDBContext _context;
        protected IServiceProvider ServiceProvider { get; }
        public HistoryModel(
            FalconsDBContext context,
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

        public void OnGet()
        {
            //get all the order
            FnBOrders = _context.FnBOrders.Where(fnb => fnb.UID == UserManager.GetUserId(User)).OrderByDescending(fnb => fnb.FnBOrderID).ToList();
        }
    }
}
