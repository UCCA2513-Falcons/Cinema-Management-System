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

        public List<ProductCategory> GetAllProductCategory() {
            return _context.ProductCategory.ToList();
        }

        public ProductCategory GetProductCategory(int? id) {
            if(id != null)
            {
                return _context.ProductCategory.Find(id);
            }else
            {
                return null;
            }
        }

        public void CreateProductCategory(string name) {
            ProductCategory pc = new ProductCategory();
            pc.CategoryName = name;
            _context.ProductCategory.Add(pc);
            _context.SaveChanges();
        }

        public void UpdateProductCategory(int id, string name) {
            ProductCategory pc = _context.ProductCategory.Find(id);
            pc.CategoryName = name;
            _context.ProductCategory.Update(pc);
            _context.SaveChanges();
        }

        public void DeleteProductCategory(int id) {
            ProductCategory pc = _context.ProductCategory.Find(id);
            if (pc == null) {
            } else
            {
                _context.ProductCategory.Remove(pc);
                _context.SaveChanges();
            }
        }

        public List<Product> GetAllProduct() {
            return _context.Product.ToList();
        }

        public Product GetProduct(int? id) {
            if(id != null)
            {
                return _context.Product.Find(id);
            }else
            {
                return null;
            }
        }

        public void CreateProduct(string title, decimal price, string description, int categoryId) {
            Product product = new Product();
            product.ProductTitle = title;
            product.ProductPrice = price;
            product.ProductDescription = description;

            product.ProductCategory = _context.ProductCategory.Find(categoryId);

            _context.Product.Add(product);
            _context.SaveChanges();
        }

        public void UpdateProduct(int id,string title, decimal price, string description, int categoryId) {
            Product product = _context.Product.Find(id);
            product.ProductTitle = title;
            product.ProductPrice = price;
            product.ProductDescription = description;
            product.ProductCategory = _context.ProductCategory.Find(categoryId);

            _context.Product.Update(product);
            _context.SaveChanges();
        }

        public void DeleteProduct(int? id) {
            if(id != null)
            {
                _context.Product.Remove(_context.Product.Find(id));
                _context.SaveChanges();
            }else
            {
                return;
            }
        }

        public List<Menu> GetAllMenu() {
            return _context.Menu.ToList();
        }

        public Menu GetMenu(int? id)
        {
            if(id != null)
            {
                return _context.Menu.Find(id);
            }
            else
            {
                return null;
            }
        }

        public void CreateMenu(string name, string description) {
            Menu mn = new Menu
            {
                PackageName = name,
                Description = description
            };
            _context.Menu.Add(mn);
            _context.SaveChanges();
        }

        public void UpdateMenu(int? id, string name, string description)
        {
            if(id!= null)
            {
                Menu mn = _context.Menu.Find(id);

                mn.PackageName = name;
                mn.Description = description;

                _context.Menu.Update(mn);
                _context.SaveChanges();
            }
            else
            {
                return;
            }
        }

        public void DeleteMenu(int? id)
        {
            if(id != null)
            {
                _context.Menu.Remove(_context.Menu.Find(id));
            }
            else
            {
                return;
            }
        }

        public List<MenuItem> GetAllMenuItem() {
            return _context.MenuItem.ToList();
        }

        public MenuItem GetMenuItem(int? id)
        {
            if(id != null)
            {
                return _context.MenuItem.Find(id);
            }else
            {
                return null;
            }
        }

        public void CreateMenuItem(int menuId, int productId) {
            MenuItem mi = new MenuItem
            {
                Menu = _context.Menu.Find(menuId),
                Product = _context.Product.Find(productId)
            };

            _context.MenuItem.Add(mi);
        }

        public void UpdateMenuItem(int menuId, int productId, int newProductId) {
            var result = from m in _context.MenuItem where m.Menu.MenuID.Equals(menuId) && m.Product.ProductID.Equals(productId) select m;

            MenuItem mi = (MenuItem)result;
            mi.Product = _context.Product.Find(newProductId);
            _context.MenuItem.Update(mi);
            _context.SaveChanges();
        }

        public void DeleteMenuItem(int menuId, int productId) {
            var result = from m in _context.MenuItem where m.Menu.MenuID.Equals(menuId) && m.Product.ProductID.Equals(productId) select m;

            MenuItem mi = (MenuItem)result;
            _context.MenuItem.Remove(mi);
            _context.SaveChanges();
        }

        public List<FnBOrder> GetAllFnBOrder() {
            return _context.FnBOrder.ToList();
        }

        public FnBOrder GetFnBOrder(int? id)
        {
            if(id != null)
            {
                return _context.FnBOrder.Find(id);
            }
            else
            {
                return null;
            }
        }

        public void CreateFnBOrder(DateTime date, int id)
        {
            FnBOrder fnb = new FnBOrder()
            {
                OrderDate = date,
                User = _context.User.Find(id)
            };
            _context.FnBOrder.Add(fnb);
            _context.SaveChanges();
        }

        public void UpdateFnBOrder(int id, DateTime orderDate)
        {
            FnBOrder fnb = _context.FnBOrder.Find(id);
            fnb.OrderDate = orderDate;
            _context.FnBOrder.Update(fnb);
            _context.SaveChanges();
        }

        public void DeleteFnBOrder(int? id)
        {
            if(id != null)
            {
                _context.FnBOrder.Remove(_context.FnBOrder.Find(id));
                _context.SaveChanges();
            }
            else
            {
                return;
            }
        }

        public List<FoodType> GetAllFoodType() {
            return _context.FoodType.ToList();
        }

        public FoodType GetFoodType(int? id) {
            if(id == null)
            {
                return null;
            }else
            {
                return _context.FoodType.Find(id);
            }
        }

        public void CreateFoodType(string title, string type) {
            FoodType ft = new FoodType();
            ft.Title = title;
            ft.Type = type;

            _context.FoodType.Add(ft);
            _context.SaveChanges();
        }

        public void UpdateFoodType(int? id, string title, string type) {
            if(id != null)
            {
                FoodType ft = _context.FoodType.Find(id);
                ft.Title = title;
                ft.Type = type;

                _context.FoodType.Update(ft);
                _context.SaveChanges();
            }else
            {
                return;
            }
        }

        public void DeleteFoodType(int? id) {
            if (id != null) {
                _context.FoodType.Remove(_context.FoodType.Find(id));
                _context.SaveChanges();
            }
            else
            {
                return;
            }
        }

        public List<FoodInventory> GetAllFoodInventories() {
            return _context.FoodInventory.ToList();
        }

        public FoodInventory GetFoodInventory(int? id) {
            if(id != null)
            {
                return _context.FoodInventory.Find(id);
            }
            else
            {
                return null;
            }
        }

        public void CreateFoodInventory(decimal quantity, DateTime date, string description, decimal price, string recordType, int footTypeId) {
            FoodInventory fi = new FoodInventory
            {
                Quantity = quantity,
                Date = date,
                Description = description,
                Price = price,
                RecordType = recordType,
                FoodType = _context.FoodType.Find(footTypeId)
            };

            _context.FoodInventory.Add(fi);
            _context.SaveChanges();
        }

        public void UpdateFoodInventory(int id, decimal quantity, DateTime date, string description, decimal price, string recordType, int footTypeId) {
            FoodInventory fi = _context.FoodInventory.Find(id);
            fi.Quantity = quantity;
            fi.Date = date;
            fi.Description = description;
            fi.Price = price;
            fi.RecordType = recordType;
            fi.FoodType = _context.FoodType.Find(footTypeId);

            _context.FoodInventory.Update(fi);
            _context.SaveChanges();
        }

        public void DeleteFoodInventory(int id)
        {
            _context.FoodInventory.Remove(_context.FoodInventory.Find(id));
            _context.SaveChanges();
        }
    }
}
