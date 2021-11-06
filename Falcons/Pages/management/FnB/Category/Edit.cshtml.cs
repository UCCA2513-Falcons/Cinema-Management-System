using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Falcons.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Falcons.Pages.management.FnB.Category
{
    public class EditModel : PageModel
    {
        private readonly FalconsDBContext _context;
        
        [BindProperty]
        public ProductCategory PC { get; set; }

        public EditModel(FalconsDBContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            PC = await _context.ProductCategories.FindAsync(id);

            if(PC == null)
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

            _context.Attach(PC).State = EntityState.Modified;
            //ProductCategory pcEdit = await _context.ProductCategories.FindAsync(pc.CategoryID);

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.ProductCategories.Any(e => e.CategoryID == PC.CategoryID))
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
