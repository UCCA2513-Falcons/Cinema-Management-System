using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Falcons.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Falcons.Pages.management.FnB.Products
{
    public class EditPackageMenuModel : PageModel
    {
        public readonly FalconsDBContext _context;

        [BindProperty]
        public Menu Menu { get; set; }

        [BindProperty]
        public MenuItem MenuItem { get; set; }

        public List<MenuItem> MenuItems;

        public List<SelectListItem> ProductOptions;

        [BindProperty]
        public int MenuItemID { get; set; }

        public EditPackageMenuModel(FalconsDBContext context)
        {
            _context = context;
        }

        public IActionResult OnGet(int? id)
        {
            if(id == null)
            {
                return Redirect("/management/FnB/Products/Index");
            }

            ProductOptions = _context.Products.Select(p => new SelectListItem { Value = p.ProductID.ToString(), Text = p.ProductTitle.ToString()}).ToList();

            Menu = _context.Menus.Find(id);

            MenuItems = _context.MenuItems.Where(mi => mi.MenuID == Menu.MenuID).ToList();

            return Page();
        }

        public IActionResult OnPost(int? id)
        {
            if (id == null)
            {
                return Redirect("/management/FnB/Products/Index");
            }

            ProductOptions = _context.Products.Select(p => new SelectListItem { Value = p.ProductID.ToString(), Text = p.ProductTitle.ToString() }).ToList();

            MenuItems = _context.MenuItems.Where(mi => mi.MenuID == id).ToList();

            //Menu = _context.Menus.Find(id);
            if(Menu != null)
            {
                _context.Attach(Menu).State = EntityState.Modified;
                _context.SaveChanges();
            }

            return Page();
        }

        public IActionResult OnPostCreateMenuItem()
        {
            int? id = MenuItem.MenuID;
            if (id == null)
            {
                return Redirect("/management/FnB/Products/Index");
            }

            ProductOptions = _context.Products.Select(p => new SelectListItem { Value = p.ProductID.ToString(), Text = p.ProductTitle.ToString() }).ToList();

            MenuItems = _context.MenuItems.Where(mi => mi.MenuID == id).ToList();

            Menu = _context.Menus.Find(id);

            if(MenuItem != null)
            {
                _context.MenuItems.Add(MenuItem);
                _context.SaveChanges();
            }

            return Redirect("/management/FnB/Products/EditPackageMenu?id="+id);
        }

        public IActionResult OnPostDeleteMenuItem()
        {
            //Menu ID
            int? id = _context.MenuItems.Find(MenuItemID).MenuID;
            if (id == null)
            {
                return Redirect("/management/FnB/Products/Index");
            }

            if (id == null)
            {
                return Redirect("/management/FnB/Products/Index");
            }

            //remove MenuItem
            MenuItem menuItem1 = _context.MenuItems.Find(MenuItemID);

            if (menuItem1 != null)
            {
                _context.MenuItems.Remove(menuItem1);
                _context.SaveChanges();
            }


            //fetch the item need to display
            ProductOptions = _context.Products.Select(p => new SelectListItem { Value = p.ProductID.ToString(), Text = p.ProductTitle.ToString() }).ToList();

            MenuItems = _context.MenuItems.Where(mi => mi.MenuID == id).ToList();

            Menu = _context.Menus.Find(id);

            return Page();
        }
    }
}
