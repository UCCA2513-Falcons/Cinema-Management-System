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

namespace Falcons.Pages
{
    public class CartModel : DI_BasePageModel
    {
        public List<ProductDetails> ProductDetails;
        public List<Menu> Menus;
        public List<Product> Products;

        private readonly FalconsDBContext _context;
        protected IServiceProvider ServiceProvider { get; }
        public CartModel(
            FalconsDBContext context,
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

        public async Task OnGetAsync()
        {
            ProductDetails = await _context.ProductDetails.ToListAsync();
            Products = await _context.Products.ToListAsync();
            Menus = await _context.Menus.ToListAsync();
        }
    }
}
