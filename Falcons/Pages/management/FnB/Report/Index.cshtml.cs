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

namespace Falcons.Pages.management.FnB.Report
{
    [Authorize(Roles = "Admin, Manager")]
    public class IndexModel : DI_BasePageModel
    {
        public readonly FalconsDBContext _context;
        protected IServiceProvider ServiceProvider { get; }

        public List<FoodInventory> FoodInventories;

        public double[] InventoryData;

        public IndexModel(FalconsDBContext context,
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
            FoodInventories = _context.FoodInventories.ToList();
            InventoryData = new double[12];
            for (int i = 1; i <= 12; i++)
            {
                InventoryData[i - 1] = 0;
                foreach (var item in FoodInventories)
                {
                    Console.WriteLine(item.Date.ToString("M"));
                    if (Int32.Parse(item.Date.ToString("MM")) == i)
                    {
                        if (item.RecordType.Equals("Purchase"))
                        {
                            InventoryData[i - 1] += (double)item.Price;
                        }
                        else if (item.RecordType.Equals("Consume"))
                        {
                            InventoryData[i - 1] -= (double)item.Price;
                        }
                        else
                        {
                            InventoryData[i - 1] -= (double)item.Price;
                        }
                    }
                }
            }
        }
    }
}
