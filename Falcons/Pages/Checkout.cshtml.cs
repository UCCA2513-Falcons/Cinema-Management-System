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
using Newtonsoft.Json;

namespace Falcons.Pages
{
    public class CheckoutModel : DI_BasePageModel
    {
        public List<ProductDetails> ProductDetails;
        public List<Menu> Menus;
        public List<Product> Products;

        private readonly FalconsDBContext _context;
        protected IServiceProvider ServiceProvider { get; }

        public CheckoutModel(
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
            //CheckoutJsonContainer OrderDetail = JsonConvert.DeserializeObject<CheckoutJsonContainer>(json);
            ProductDetails = await _context.ProductDetails.ToListAsync();
            Products = await _context.Products.ToListAsync();
            Menus = await _context.Menus.ToListAsync();
        }

        public async Task<IActionResult> OnPostAsync(string json)
        {
            CheckoutJsonContainer OrderDetail = JsonConvert.DeserializeObject<CheckoutJsonContainer>(json);

            FnBOrder fnBOrder = new FnBOrder();
            fnBOrder.OrderDate = DateTime.Now;
            fnBOrder.UID = UserManager.GetUserId(User);
            await _context.FnBOrders.AddAsync(fnBOrder);
            await _context.SaveChangesAsync();

            foreach(var item in OrderDetail.CheckoutMenus)
            {
                foreach(var product in item.ProductDetail)
                {
                    FnBOrderDetail OrderItem = new FnBOrderDetail();
                    OrderItem.OrderID = fnBOrder.FnBOrderID;
                    ProductDetails pd = _context.ProductDetails.Find(product.ProductDetailID);
                    OrderItem.ProductDetailID = pd.ProductDetailID;
                    OrderItem.ProductPrice = pd.ProductPrice;
                    OrderItem.Quantity = 1;

                    _context.FnBOrderDetails.Add(OrderItem);
                    _context.SaveChanges();
                }
            }

            foreach(var item in OrderDetail.Products)
            {
                FnBOrderDetail OrderItem = new FnBOrderDetail();
                OrderItem.OrderID = fnBOrder.FnBOrderID;
                ProductDetails pd = _context.ProductDetails.Find(item.ProductDetailID);
                OrderItem.ProductDetailID = pd.ProductDetailID;
                OrderItem.ProductPrice = pd.ProductPrice;
                OrderItem.Quantity = item.quantity;

                _context.FnBOrderDetails.Add(OrderItem);
                _context.SaveChanges();
            }

            //show order history after finish loaded to database
            return Redirect("/History");
        }
    }
}
