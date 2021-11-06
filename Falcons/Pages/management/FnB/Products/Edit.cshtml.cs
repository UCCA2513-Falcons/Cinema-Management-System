using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Falcons.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Falcons.Pages.management.FnB.Products
{
    public class EditModel : PageModel
    {
        private readonly FalconsDBContext _context;

        public List<SelectListItem> CategoryOptions { get; set; }

        [BindProperty]
        public Product Product { get; set; }

        [BindProperty]
        public IFormFileCollection Photo { get; set; }

        private IWebHostEnvironment webHostEnvironment;

        public EditModel(FalconsDBContext context, IWebHostEnvironment WebHostEnvironment)
        {
            _context = context;
            webHostEnvironment = WebHostEnvironment;
        }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }

            CategoryOptions = await _context.ProductCategories.Select(c =>
                                    new SelectListItem
                                    {
                                        Value = c.CategoryID.ToString(),
                                        Text = c.CategoryName.ToString()
                                    }).ToListAsync();

            Product = await _context.Products.FindAsync(id);

            if(Product == null)
            {
                return NotFound();
            }

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            //image upload
            string UniqueFileName = null;
            if(Photo != null)
            {
                //System.DateTime CurrentTime = new DateTime();
                //string DateFolder = CurrentTime.Year + "-" + CurrentTime.Month;

                string UploadFolder = webHostEnvironment.WebRootPath + "\\assets\\img\\";

                /*
                //create the folder if not exist
                if (!(Directory.Exists(UploadFolder)))
                {
                    Directory.CreateDirectory(UploadFolder);
                }

                
                UniqueFileName = Guid.NewGuid().ToString() + "_" + Photo[0];
                string FilePath = Path.Combine(UploadFolder, UniqueFileName);
                using(var FileStream = new FileStream(FilePath, FileMode.Create))
                {
                    Photo[0].CopyTo(FileStream);
                }*/

                List<string> URLList = new List<string>();

                foreach(var item in Photo)
                {
                    UniqueFileName = Guid.NewGuid().ToString() + "_" + item;
                    string FilePath = Path.Combine(UploadFolder, UniqueFileName);
                    using (var FileStream = new FileStream(FilePath, FileMode.Create))
                    {
                        await item.CopyToAsync(FileStream);
                        await FileStream.FlushAsync();
                    }

                    //direct assign if the img url is the first one
                    URLList.Add(FilePath);
                }

                Product.ImageURL = String.Join(",",URLList);
            }

            _context.Attach(Product).State = EntityState.Modified;
            //ProductCategory pcEdit = await _context.ProductCategories.FindAsync(pc.CategoryID);

            try
            {
                await _context.SaveChangesAsync();
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

            return RedirectToPage("./Index");
        }
    }
}
