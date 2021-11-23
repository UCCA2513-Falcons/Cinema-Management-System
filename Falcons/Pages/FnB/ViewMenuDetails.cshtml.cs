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

namespace Falcons.Pages.FnB
{
    public class ViewMenuDetailsModel : DI_BasePageModel
    {
        public readonly FalconsDBContext _context;
        protected IServiceProvider ServiceProvider { get; }

        public List<ProductDetails> ProductDetails;
        public List<Product> Products { get; set; }
        public List<MenuItem> MenuItems;
        public Menu Menu;

        public ViewMenuDetailsModel(FalconsDBContext context,
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
            //redirect if id is not provided
            if (id == null)
            {
                return Redirect("/FnB/Menu");
            }

            Menu = _context.Menus.Find(id);
            if (Menu != null)
            {
                MenuItems = _context.MenuItems.Where(mi => mi.MenuID == Menu.MenuID).ToList();
                if (MenuItems.Count < 1)
                {
                    //nothing to output for the MenuItem
                }
                else
                {

                    Products = new List<Product>();
                    ProductDetails = new List<ProductDetails>();

                    //adding one by one product that listed in menu item
                    foreach (var item in MenuItems)
                    {
                        Products.Add(_context.Products.Where(pd => pd.ProductID == item.ProductID).First());
                        List<ProductDetails> productDetails = _context.ProductDetails.Where(pd => pd.ProductID == item.ProductID).ToList();
                        ProductDetails.AddRange(productDetails);
                    }
                }
            }
            else
            {
                //redirect if the menu not exist
                //return Redirect("/FnB/Menu");
            }

            return Page();
        }
    }
}
