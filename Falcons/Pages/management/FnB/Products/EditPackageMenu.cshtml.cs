using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Falcons.Code;
using Falcons.Data;
using Falcons.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Falcons.Pages.management.FnB.Products
{
    [Authorize(Roles = "Admin, Manager")]
    public class EditPackageMenuModel : DI_BasePageModel
    {
        public readonly FalconsDBContext _context;
        protected IServiceProvider ServiceProvider { get; }

        [BindProperty]
        public Menu Menu { get; set; }

        [BindProperty]
        public MenuItem MenuItem { get; set; }

        public List<MenuItem> MenuItems;

        public List<SelectListItem> ProductOptions;

        [BindProperty]
        public int MenuItemID { get; set; }

        public List<string> ImgList { get; set; }

        [BindProperty]
        public List<IFormFile> Photo { get; set; }

        //for delete image use
        [BindProperty]
        public string ImgURL { get; set; }
        [BindProperty]
        public int MenuID { get; set; }

        private IWebHostEnvironment webHostEnvironment;

        public EditPackageMenuModel(FalconsDBContext context,
         IWebHostEnvironment WebHostEnvironment,
         ApplicationDbContext authcontext,
         IAuthorizationService authorizationService,
         UserManager<IdentityUser> userManager,
         RoleManager<IdentityRole> roleManager,
         IServiceProvider serviceProvider
            ) : base(authcontext, authorizationService, userManager, roleManager)
        {
            _context = context;
            ServiceProvider = serviceProvider;
            webHostEnvironment = WebHostEnvironment;
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

            if (!String.IsNullOrWhiteSpace(_context.Menus.Find(id).ImageURL))
            {
                ImgList = _context.Menus.Find(id).ImageURL.Split(",").ToList();
            }
            

            return Page();
        }

        public IActionResult OnPost(int? id)
        {
            if (id == null)
            {
                return Redirect("/management/FnB/Products/Index");
            }

            //fetch the menu to edit 
            Menu EditMenu = _context.Menus.Find(Menu.MenuID);

            //image upload
            string UniqueFileName = null;
            if (Photo.Count > 0)
            {
                string UploadFolder = Path.Combine(webHostEnvironment.WebRootPath, "assets\\img\\menus");

                List<string> URLList = new List<string>();
                int ImgListCount = 0;

                foreach (IFormFile item in Photo)
                {
                    UniqueFileName = Guid.NewGuid().ToString() + "_" + item.FileName;
                    string FilePath = Path.Combine(UploadFolder, UniqueFileName);
                    using (var FileStream = new FileStream(FilePath, FileMode.Create))
                    {
                        item.CopyTo(FileStream);
                        FileStream.Flush();
                    }
                    URLList.Add(UniqueFileName);
                    ImgListCount++;
                }

                string JoinURL = "";
                //string SrcImgURL = EditProduct.ImageURL;
                
                if (!String.IsNullOrWhiteSpace(EditMenu.ImageURL))
                {
                    JoinURL = EditMenu.ImageURL + "," + String.Join(",", URLList);
                }
                else
                {
                    if (ImgListCount > 1)
                    {
                        JoinURL = String.Join(",", URLList);
                    }
                    else
                    {
                        //error cannot fetch and assign the URLList[0], URLList.ElementAt()
                        JoinURL = URLList.First();
                    }
                }

                EditMenu.ImageURL = JoinURL;
            }

            EditMenu.PackageName = Menu.PackageName;
            EditMenu.Description = Menu.Description;

            //save the edited menu
            if (EditMenu != null)
            {
                _context.Attach(EditMenu).State = EntityState.Modified;
                _context.SaveChanges();
            }

            //fetch basic data
            ProductOptions = _context.Products.Select(p => new SelectListItem { Value = p.ProductID.ToString(), Text = p.ProductTitle.ToString() }).ToList();

            MenuItems = _context.MenuItems.Where(mi => mi.MenuID == id).ToList();

            if (!String.IsNullOrWhiteSpace(_context.Menus.Find(id).ImageURL))
            {
                ImgList = _context.Menus.Find(id).ImageURL.Split(",").ToList();
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

            if (!String.IsNullOrWhiteSpace(_context.Menus.Find(id).ImageURL))
            {
                ImgList = _context.Menus.Find(id).ImageURL.Split(",").ToList();
            }

            if (MenuItem != null)
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

            if (!String.IsNullOrWhiteSpace(_context.Menus.Find(id).ImageURL))
            {
                ImgList = _context.Menus.Find(id).ImageURL.Split(",").ToList();
            }

            return Page();
        }

        public IActionResult OnPostDeleteImage()
        {
            if(!String.IsNullOrWhiteSpace(ImgURL) && MenuID != 0)
            {
                Menu TargetMenu = _context.Menus.Find(MenuID);
                List<string> ImageURLList = TargetMenu.ImageURL.Split(",").ToList();

                //ImageURLList.Find(s => s.Contains(ImgURL));
                ImageURLList.Remove(ImageURLList.Find(s => s.Contains(ImgURL)));

                string JoinURL = String.Join(",", ImageURLList);

                TargetMenu.ImageURL = JoinURL;

                _context.Menus.Update(TargetMenu);
                _context.SaveChanges();

                //folder path to image
                string UploadFolder = Path.Combine(webHostEnvironment.WebRootPath, "assets\\img\\menus");

                //delete the image file if exists
                if (System.IO.File.Exists(UploadFolder + "\\" + ImgURL))
                {
                    System.IO.File.Delete(UploadFolder + "\\" + ImgURL);
                }
            }


            return Redirect("/management/FnB/Products/EditPackageMenu?id=" + MenuID);
        }
    }
}
