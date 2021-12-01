using Falcons.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Falcons.Data
{
    public class DbInitializer
    {
        public static void Initialize(FalconsDBContext context) {
            //check dproduct category table
            if (!context.ProductCategories.Any()) {
                var ProductCategory = new List<ProductCategory>()
                {
                    new ProductCategory() { 
                        CategoryName = "Burger",
                    },

                    new ProductCategory() {
                        CategoryName = "Tea",
                    },

                    new ProductCategory() {
                        CategoryName = "Juice",
                    },

                    new ProductCategory() {
                        CategoryName = "Carbonate Drink",
                    },

                    new ProductCategory() {
                        CategoryName = "Sides",
                    }
                };

                context.AddRange(ProductCategory);
                context.SaveChanges();
            }

            //check for product
            if (!context.Products.Any())
            {
                var Products = new List<Product>()
                {
                    new Product(){
                        ProductTitle = "Korean Chicken Burger",
                        CategoryID = 1,
                        ProductDescription = "Discover the idolicious taste of Korea with a  choice of Spicy Korean Beef Burger or Spicy Korean Chicken Burger. With its  show-stopping combination of a  kimchi-seasoned grilled beef or a crispy chicken patty covered in spicy Korean sauce, just one bite will make you a stan forever!",
                        ImageURL = "f4137e7e-f27a-4c91-99ed-e347bd88c7b3_burger.png"
                    },

                    new Product(){
                        ProductTitle = "French Fries",
                        CategoryID = 5,
                        ProductDescription = "A thin strip of potato, usually cut 3 to 4 inches in length and about 1/4 to 3/8 inches square that are deep fried until they are golden brown and crisp textured on the outside while remaining white and soft on the inside. French fries are not French in origin.",
                        ImageURL = "db797c2d-f259-489b-bfde-d3567f7a3d56_fries.png"
                    },

                    new Product(){
                        ProductTitle = "Coca Cola",
                        CategoryID = 4,
                        ProductDescription = "Coca-Cola is the most popular and biggest-selling soft drink in history, as well as one of the most recognizable brands in the world.",
                        ImageURL = "ed9fcc48-566f-48d1-976c-1b52881a9143_CocaCola.webp"
                    }
                };

                context.AddRange(Products);
                context.SaveChanges();
            }

            //check for product details
            if (!context.ProductDetails.Any())
            {
                var ProductsDetails = new List<ProductDetails>()
                {
                    new ProductDetails { ProductID = 1, Size = "Small", ProductPrice = 8 },
                    new ProductDetails { ProductID = 1, Size = "Medium", ProductPrice = 10 },
                    new ProductDetails { ProductID = 1, Size = "Large", ProductPrice = 12 },
                    new ProductDetails { ProductID = 2, Size = "Small", ProductPrice = 4 },
                    new ProductDetails { ProductID = 2, Size = "Medium", ProductPrice = 5 },
                    new ProductDetails { ProductID = 2, Size = "Large", ProductPrice = 6 },
                    new ProductDetails { ProductID = 3, Size = "Small", ProductPrice = 2 },
                    new ProductDetails { ProductID = 3, Size = "Medium", ProductPrice = 3 },
                    new ProductDetails { ProductID = 3, Size = "Large", ProductPrice = 4 }
                };

                context.AddRange(ProductsDetails);
                context.SaveChanges();
            }

            //check for product package
            if (!context.Menus.Any())
            {
                var Menus = new List<Menu>()
                {
                    new Menu
                    {
                        PackageName = "Korean Spicy Chicken Package",
                        Description = "The best Korean Chicken Burger - crispy coated buttermilk chicken burger smothered in a spicy Korean-inspired gochujang sauce. The sauce is so rich, flavourful and complex and it comes together very easily - just throw all the ingredients in a pan and bubble it up. We love to eat this with rice, noodles, or my personal favourite - stuffed into bao buns!",
                        ImageURL = "410ac126-26e2-4b26-917a-4e48f6f75d01_maxresdefault.jpg"
                    }
                };

                context.AddRange(Menus);
                context.SaveChanges();
            }

            //check for menu item
            if (!context.MenuItems.Any())
            {
                var AllMenuItem = new List<MenuItem>()
                {
                    new MenuItem{ MenuID = 1, ProductID = 1 },
                    new MenuItem{ MenuID = 1, ProductID = 2 },
                    new MenuItem{ MenuID = 1, ProductID = 3 }
                };

                context.AddRange(AllMenuItem);
                context.SaveChanges();
            }

            //check for inventory item
            if (!context.FoodTypes.Any())
            {
                var inventoryItems = new List<FoodType>()
                {
                    new FoodType{ Title = "Coca Cola", Type = "Carbonated Drink" },
                    new FoodType{ Title = "Chicken Burger Meal", Type = "Burger Meal" },
                    new FoodType{ Title = "Beef Burger Meal", Type = "Burger Meal" },
                    new FoodType{ Title = "Ice Lemon Tea", Type = "Tea" },
                    new FoodType{ Title = "Korean Burger Bun", Type = "Burger Bun" },
                    new FoodType{ Title = "Tomato Sauce", Type = "Sauce" },
                    new FoodType{ Title = "Chilli Sauce", Type = "Sauce" },
                    new FoodType{ Title = "Salt", Type = "Condiment" }
                };

                context.AddRange(inventoryItems);
                context.SaveChanges();
            }

            //check for food inventories
            if (!context.FoodInventories.Any())
            {
                var FoodIventories = new List<FoodInventory>()
                {
                    new FoodInventory { Quantity = 10, Date = new DateTime(2021,11,01), Description = "buy salt", Price = 8, RecordType = "Purchase", FID = context.FoodTypes.Where(f=>f.Title.Contains("Salt")).FirstOrDefault().FID },
                    new FoodInventory { Quantity = 50, Date = new DateTime(2021,9,5), Description = "buy chicken burger meal from ayamas sdn bhd", Price = 120, RecordType = "Purchase", FID = context.FoodTypes.Where(f=>f.Title.Contains("Chicken Burger Meal")).FirstOrDefault().FID },
                    new FoodInventory { Quantity = 50, Date = new DateTime(2021,9,5), Description = "buy beef burger meal from ayamas sdn bhd", Price = 120, RecordType = "Purchase", FID = context.FoodTypes.Where(f=>f.Title.Contains("Beef Burger Meal")).FirstOrDefault().FID},
                    new FoodInventory { Quantity = 15, Date = new DateTime(2021,10,17), Description = "take stock from warehouse - beef burger meal from ayamas sdn bhd", Price = 40, RecordType = "Consume", FID = context.FoodTypes.Where(f=>f.Title.Contains("Beef Burger Meal")).FirstOrDefault().FID},
                    new FoodInventory { Quantity = 10, Date = new DateTime(2021,9,5), Description = "return burger meal due to expired meal", Price = 30, RecordType = "Return", FID = context.FoodTypes.Where(f=>f.Title.Contains("Beef Burger Meal")).FirstOrDefault().FID},
                    new FoodInventory { Quantity = 50, Date = new DateTime(2021,10,01), Description = "buy coca cola from Coca Cola Sdn Bhd", Price = 75, RecordType = "Purchase", FID = context.FoodTypes.Where(f=>f.Title.Contains("Coca Cola")).FirstOrDefault().FID}
                };

                context.AddRange(FoodIventories);
                context.SaveChanges();
            }
        }
    }
}
