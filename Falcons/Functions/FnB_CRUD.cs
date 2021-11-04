using Falcons.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Falcons.Functions
{
    public class FnB_CRUD
    {
        private readonly FalconsDBContext _context;

        public FnB_CRUD(FalconsDBContext context)
        {
            _context = context;
        }

        /*public List<ProductCategory> getAllProductCategory() {
            _context.ProductCategory.All
        }*/

        public void CreateProductCategory(string name) {
            ProductCategory pc = new ProductCategory();
            pc.CategoryName = name;
            _context.ProductCategory.Add(pc);
        }

        public void UpdateProductCategory(int id, string name) {
            ProductCategory pc = _context.ProductCategory.Find(id);
            pc.CategoryName = name;
            _context.ProductCategory.Update(pc);
        }

        public void DeleteProductCategory(int id) {
            ProductCategory pc = _context.ProductCategory.Find(id);
            if (pc == null) {
            } else
            {
                _context.ProductCategory.Remove(pc);
            }
        }
    }
}
