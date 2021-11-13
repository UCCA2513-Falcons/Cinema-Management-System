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

namespace Falcons.Pages.management.FnB.Products
{
    [Authorize(Roles = "Admin, Manager")]
    public class IndexModel : DI_BasePageModel
    {
        public readonly FalconsDBContext _context;
        protected IServiceProvider ServiceProvider { get; }
        public List<SelectListItem> CategoryOptions { get; set; }

        [BindProperty]
        public Product Product { get; set; }

        public List<Product> AllProduct { get; set; }

        public List<Menu> Menus;
        [BindProperty]
        public Menu Menu { get; set; }

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
            CategoryOptions = await _context.ProductCategories.Select(c =>
                                    new SelectListItem { 
                                        Value = c.CategoryID.ToString(),
                                        Text = c.CategoryName.ToString()
                                    }).ToListAsync();

            AllProduct = await _context.Products.ToListAsync();

            Menus = await _context.Menus.ToListAsync();

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {

            // Product.ProductCategory = await _context.ProductCategories.FindAsync(Product.CategoryID);

            Product.ImageURL = "";
            await _context.Products.AddAsync(Product);

            await _context.SaveChangesAsync();

            AllProduct = await _context.Products.ToListAsync();

            Menus = await _context.Menus.ToListAsync();

            CategoryOptions = await _context.ProductCategories.Select(c =>
                                    new SelectListItem
                                    {
                                        Value = c.CategoryID.ToString(),
                                        Text = c.CategoryName.ToString()
                                    }).ToListAsync();

            return Page();
        }

        public IActionResult OnPostCreateMenu()
        {
            if (Menu != null)
            {
                _context.Menus.Add(Menu);
                _context.SaveChanges();
            }

            AllProduct = _context.Products.ToList();

            CategoryOptions = _context.ProductCategories.Select(c =>
                                    new SelectListItem
                                    {
                                        Value = c.CategoryID.ToString(),
                                        Text = c.CategoryName.ToString()
                                    }).ToList();

            Menus = _context.Menus.ToList();

            return Page();
        }
    }
}
