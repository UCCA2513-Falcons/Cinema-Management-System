using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    public class EditModel : DI_BasePageModel
    {
        private readonly FalconsDBContext _context;
        protected IServiceProvider ServiceProvider { get; }

        public List<SelectListItem> CategoryOptions { get; set; }

        public List<string> imgList { get; set; }

        [BindProperty]
        public string ImgURL { get; set; }

        [BindProperty]
        public int ProductID { get; set; }

        public int count { get; set; }

        [BindProperty]
        public List<ProductDetails> ProductDetails { get; set; }

        [BindProperty]
        public ProductDetails ProductDetail { get; set; }

        [BindProperty]
        public Product Product { get; set; }

        [BindProperty]
        public List<IFormFile> Photo { get; set; }

        private IWebHostEnvironment webHostEnvironment;

        public List<SelectListItem> ProductOptions { get; set; }

        public EditModel(FalconsDBContext context,
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

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if(id == null)
            {
                //return NotFound();
                return RedirectToPage("./Index");
            }

            CategoryOptions = await _context.ProductCategories.Select(c =>
                                    new SelectListItem
                                    {
                                        Value = c.CategoryID.ToString(),
                                        Text = c.CategoryName.ToString()
                                    }).ToListAsync();

            ProductOptions = await _context.Products.Select(c => 
                                        new SelectListItem { 
                                            Value = c.ProductID.ToString(),
                                            Text = c.ProductTitle.ToString()
                                        }).ToListAsync();

            Product = await _context.Products.FindAsync(id);

            imgList = new List<string>();

            if (!String.IsNullOrWhiteSpace(Product.ImageURL))
            {
                if (Product.ImageURL.Contains(","))
                {
                    imgList = Product.ImageURL.Split(",").ToList();
                }
                else
                {
                    imgList.Add(Product.ImageURL);
                }
            }

            ProductDetails = _context.ProductDetails.Where(pd => pd.ProductID == id).ToList();

            if (Product == null)
            {
                return NotFound();
            }

            return Page();
        }

        public IActionResult OnPost()
        {
            /*if (!ModelState.IsValid)
            {
                return Page();
            }*/

            CategoryOptions = _context.ProductCategories.Select(c =>
                                    new SelectListItem
                                    {
                                        Value = c.CategoryID.ToString(),
                                        Text = c.CategoryName.ToString()
                                    }).ToList();

            ProductOptions = _context.Products.Select(c =>
                                        new SelectListItem
                                        {
                                            Value = c.ProductID.ToString(),
                                            Text = c.ProductTitle.ToString()
                                        }).ToList();

            Product EditProduct = _context.Products.Find(Product.ProductID);

            //Product.ImageURL = EditProduct.ImageURL;

            //image upload
            string UniqueFileName = null;
            if(Photo.Count > 0)
            {
                string UploadFolder = Path.Combine(webHostEnvironment.WebRootPath ,"assets\\img\\products");

                List<string> URLList = new List<string>();
                int ImgListCount = 0;

                foreach(IFormFile item in Photo)
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
                if (!String.IsNullOrWhiteSpace(EditProduct.ImageURL))
                {
                    JoinURL = EditProduct.ImageURL + ","+ String.Join(",", URLList);
                }
                else
                {
                    if(ImgListCount > 1)
                    {
                        JoinURL = String.Join(",", URLList);
                    }
                    else
                    {
                        //error cannot fetch and assign the URLList[0], URLList.ElementAt()
                        JoinURL = URLList.First();
                    }
                }

                EditProduct.ImageURL = JoinURL;
            }
            
            EditProduct.ProductTitle = Product.ProductTitle;
            EditProduct.ProductDescription = Product.ProductDescription;
            EditProduct.CategoryID = Product.CategoryID;

            _context.Attach(EditProduct).State = EntityState.Modified;

            try
            {
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.Products.Any(e => e.ProductID == Product.ProductID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            /*if (EditProduct.ImageURL != null)
           {
               imgList = EditProduct.ImageURL.Split(",").ToList();
           }*/
            imgList = new List<string>();
            if (!String.IsNullOrWhiteSpace(EditProduct.ImageURL))
            {
                if (EditProduct.ImageURL.Contains(","))
                {
                    imgList = EditProduct.ImageURL.Split(",").ToList();
                }
                else
                {
                    imgList.Add(EditProduct.ImageURL);
                }
            }

            ProductDetails = _context.ProductDetails.Where(pd => pd.ProductID == EditProduct.ProductID).ToList();

            //ProductCategory pcEdit = await _context.ProductCategories.FindAsync(pc.CategoryID);

            //return RedirectToPage("./Index");
            return Redirect("Edit?id=" + EditProduct.ProductID);
            //return Page();
        }

        public IActionResult OnPostAddProductDetails(ProductDetails ProductDetail)
        {
            CategoryOptions = _context.ProductCategories.Select(c =>
                                    new SelectListItem
                                    {
                                        Value = c.CategoryID.ToString(),
                                        Text = c.CategoryName.ToString()
                                    }).ToList();

            ProductOptions = _context.Products.Select(c =>
                                        new SelectListItem
                                        {
                                            Value = c.ProductID.ToString(),
                                            Text = c.ProductTitle.ToString()
                                        }).ToList();

            Product EditProduct = _context.Products.Find(ProductDetail.ProductID);
            imgList = new List<string>();

            if (!String.IsNullOrWhiteSpace(EditProduct.ImageURL))
            {
                /*if (EditProduct.ImageURL != null)
                {
                    imgList = EditProduct.ImageURL.Split(",").ToList();
                }*/

                if (EditProduct.ImageURL.Contains(","))
                {
                    imgList = EditProduct.ImageURL.Split(",").ToList();
                }
                else
                {
                    imgList.Add(Product.ImageURL);
                }
            }

            _context.ProductDetails.Add(ProductDetail);
            _context.SaveChanges();

            ProductDetails = _context.ProductDetails.Where(pd => pd.ProductID == ProductDetail.ProductID).ToList();

            //return Page();
            return Redirect("Edit?id=" + ProductDetail.ProductID);
        }

        public IActionResult OnPostDeleteProductDetails(ProductDetails ProductDetail)
        {
            int pageId = _context.ProductDetails.Find(ProductDetail.ProductDetailID).ProductID;

            _context.ProductDetails.Remove(_context.ProductDetails.Find(ProductDetail.ProductDetailID));
            _context.SaveChanges();

            return Redirect("Edit?id=" + pageId);
        }

        public IActionResult OnPostDeleteImage(string ImgURL, int ProductID)
        {
            Product Product = _context.Products.Find(ProductID);
            string ImageURLOrigin = Product.ImageURL;

            if(!String.IsNullOrWhiteSpace(ImageURLOrigin))
            {
                List<string> ImageURLList = ImageURLOrigin.Split(",").ToList();

                //ImageURLList.Find(s => s.Contains(ImgURL));
                ImageURLList.Remove(ImageURLList.Find(s => s.Contains(ImgURL)));

                string JoinURL = String.Join(",",ImageURLList);

                Product.ImageURL = JoinURL;

                _context.Products.Update(Product);
                _context.SaveChanges();

                //folder path to image
                string UploadFolder = Path.Combine(webHostEnvironment.WebRootPath, "assets\\img\\products");

                //delete the image file if exists
                if (System.IO.File.Exists(UploadFolder + "\\" + ImgURL))
                {
                    System.IO.File.Delete(UploadFolder + "\\" + ImgURL);
                }
            }

            return Redirect("Edit?id=" + ProductID);
            //return Page();
        }
    }
}
