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
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Falcons.Pages.management.FnB.Report
{
    [Authorize(Roles = "Admin, Manager")]
    public class IndexModel : DI_BasePageModel
    {
        public readonly FalconsDBContext _context;
        protected IServiceProvider ServiceProvider { get; }

        public List<FoodInventory> FoodInventories;

        public List<SelectListItem> YearAvailable;

        public double[] InventoryData;
        public double[] AnnualExpense;
        public double[] TotalEarning;

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

        public void OnGet(int? year)
        {

            int TargetYear = 0;
            if ((year < 2000 && year > 2099) || year == null)
            {
                TargetYear = DateTime.Now.Year;
            }
            else {
                TargetYear = (int)year;
            }

            FoodInventories = _context.FoodInventories.Where(fi=>fi.Date.Year == TargetYear).ToList();
            InventoryData = new double[12];
            AnnualExpense = new double[12];
            TotalEarning = new double[12];
            for (int i = 1; i <= 12; i++)
            {
                InventoryData[i - 1] = 0;
                AnnualExpense[i - 1] = 0;
                TotalEarning[i - 1] = 0;

                //make the invetory value became cumulative
                if (i > 1)
                {
                    InventoryData[i - 1] += InventoryData[i - 2];
                }

                foreach (var item in FoodInventories)
                {
                    Console.WriteLine(item.Date.ToString("M"));
                    if (int.Parse(item.Date.ToString("MM")) == i)
                    {
                        if (item.RecordType.Equals("Purchase"))
                        {
                            InventoryData[i - 1] += (double)item.Price;
                        }
                        else if (item.RecordType.Equals("Consume"))
                        {
                            InventoryData[i - 1] -= (double)item.Price;
                            AnnualExpense[i - 1] += (double)item.Price;
                        }
                        else
                        {
                            InventoryData[i - 1] -= (double)item.Price;
                        }
                    }
                }

                foreach (var item in _context.FnBOrders.Where(fo=>fo.OrderDate.Year == TargetYear).ToList()) {
                    if (int.Parse(item.OrderDate.ToString("MM")) == i) {
                        foreach (var detail in _context.FnBOrderDetails.Where(fo => fo.OrderID == item.FnBOrderID).ToList()) {
                            TotalEarning[i - 1] += (double)detail.ProductPrice;
                        }
                    }
                }
            }

            List<int> saleYear = _context.FnBOrders
                .Select(f => f.OrderDate.Year)
                .Distinct()
                .ToList();

            List<int> InventoryYear = _context.FoodInventories
                .Select(i => i.Date.Year)
                .Distinct()
                .ToList();

            YearAvailable = new List<SelectListItem>();

            foreach (var item in saleYear)
            {
                YearAvailable.Add(new SelectListItem { Text = item.ToString(), Value = item.ToString() });
            }

            foreach (var item in InventoryYear)
            {
                if (!saleYear.Contains(item))
                {
                    YearAvailable.Add(new SelectListItem { Text = item.ToString(), Value = item.ToString() });
                }
            }

            YearAvailable.OrderBy(x => x.Text);
            YearAvailable.Where(y => y.Text.Equals(TargetYear.ToString())).FirstOrDefault().Selected = true;
        }
    }
}
