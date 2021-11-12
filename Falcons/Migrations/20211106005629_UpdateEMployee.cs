using Microsoft.EntityFrameworkCore.Migrations;

namespace Falcons.Migrations
{
    public partial class UpdateEMployee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FnBOrder_User_UserUID",
                table: "FnBOrder");

            migrationBuilder.DropForeignKey(
                name: "FK_FnBOrderDetail_FnBOrder_FnBOrderID",
                table: "FnBOrderDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_FnBOrderDetail_Product_ProductID",
                table: "FnBOrderDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_FoodInventory_FoodType_FoodTypeFID",
                table: "FoodInventory");

            migrationBuilder.DropForeignKey(
                name: "FK_MenuItem_Menu_MenuID",
                table: "MenuItem");

            migrationBuilder.DropForeignKey(
                name: "FK_MenuItem_Product_ProductID",
                table: "MenuItem");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_ProductCategory_ProductCategoryCategoryID",
                table: "Product");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductCategory",
                table: "ProductCategory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Product",
                table: "Product");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MenuItem",
                table: "MenuItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Menu",
                table: "Menu");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FoodType",
                table: "FoodType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FoodInventory",
                table: "FoodInventory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FnBOrderDetail",
                table: "FnBOrderDetail");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FnBOrder",
                table: "FnBOrder");

            migrationBuilder.RenameTable(
                name: "ProductCategory",
                newName: "ProductCategories");

            migrationBuilder.RenameTable(
                name: "Product",
                newName: "Products");

            migrationBuilder.RenameTable(
                name: "MenuItem",
                newName: "MenuItems");

            migrationBuilder.RenameTable(
                name: "Menu",
                newName: "Menus");

            migrationBuilder.RenameTable(
                name: "FoodType",
                newName: "FoodTypes");

            migrationBuilder.RenameTable(
                name: "FoodInventory",
                newName: "FoodInventories");

            migrationBuilder.RenameTable(
                name: "FnBOrderDetail",
                newName: "FnBOrderDetails");

            migrationBuilder.RenameTable(
                name: "FnBOrder",
                newName: "FnBOrders");

            migrationBuilder.RenameIndex(
                name: "IX_Product_ProductCategoryCategoryID",
                table: "Products",
                newName: "IX_Products_ProductCategoryCategoryID");

            migrationBuilder.RenameIndex(
                name: "IX_MenuItem_ProductID",
                table: "MenuItems",
                newName: "IX_MenuItems_ProductID");

            migrationBuilder.RenameIndex(
                name: "IX_MenuItem_MenuID",
                table: "MenuItems",
                newName: "IX_MenuItems_MenuID");

            migrationBuilder.RenameIndex(
                name: "IX_FoodInventory_FoodTypeFID",
                table: "FoodInventories",
                newName: "IX_FoodInventories_FoodTypeFID");

            migrationBuilder.RenameIndex(
                name: "IX_FnBOrderDetail_ProductID",
                table: "FnBOrderDetails",
                newName: "IX_FnBOrderDetails_ProductID");

            migrationBuilder.RenameIndex(
                name: "IX_FnBOrderDetail_FnBOrderID",
                table: "FnBOrderDetails",
                newName: "IX_FnBOrderDetails_FnBOrderID");

            migrationBuilder.RenameIndex(
                name: "IX_FnBOrder_UserUID",
                table: "FnBOrders",
                newName: "IX_FnBOrders_UserUID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductCategories",
                table: "ProductCategories",
                column: "CategoryID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "ProductID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MenuItems",
                table: "MenuItems",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Menus",
                table: "Menus",
                column: "MenuID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FoodTypes",
                table: "FoodTypes",
                column: "FID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FoodInventories",
                table: "FoodInventories",
                column: "RecordID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FnBOrderDetails",
                table: "FnBOrderDetails",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FnBOrders",
                table: "FnBOrders",
                column: "FnBOrderID");

            migrationBuilder.AddForeignKey(
                name: "FK_FnBOrderDetails_FnBOrders_FnBOrderID",
                table: "FnBOrderDetails",
                column: "FnBOrderID",
                principalTable: "FnBOrders",
                principalColumn: "FnBOrderID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FnBOrderDetails_Products_ProductID",
                table: "FnBOrderDetails",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "ProductID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FnBOrders_User_UserUID",
                table: "FnBOrders",
                column: "UserUID",
                principalTable: "User",
                principalColumn: "UID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FoodInventories_FoodTypes_FoodTypeFID",
                table: "FoodInventories",
                column: "FoodTypeFID",
                principalTable: "FoodTypes",
                principalColumn: "FID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MenuItems_Menus_MenuID",
                table: "MenuItems",
                column: "MenuID",
                principalTable: "Menus",
                principalColumn: "MenuID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MenuItems_Products_ProductID",
                table: "MenuItems",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "ProductID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductCategories_ProductCategoryCategoryID",
                table: "Products",
                column: "ProductCategoryCategoryID",
                principalTable: "ProductCategories",
                principalColumn: "CategoryID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FnBOrderDetails_FnBOrders_FnBOrderID",
                table: "FnBOrderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_FnBOrderDetails_Products_ProductID",
                table: "FnBOrderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_FnBOrders_User_UserUID",
                table: "FnBOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_FoodInventories_FoodTypes_FoodTypeFID",
                table: "FoodInventories");

            migrationBuilder.DropForeignKey(
                name: "FK_MenuItems_Menus_MenuID",
                table: "MenuItems");

            migrationBuilder.DropForeignKey(
                name: "FK_MenuItems_Products_ProductID",
                table: "MenuItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductCategories_ProductCategoryCategoryID",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductCategories",
                table: "ProductCategories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Menus",
                table: "Menus");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MenuItems",
                table: "MenuItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FoodTypes",
                table: "FoodTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FoodInventories",
                table: "FoodInventories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FnBOrders",
                table: "FnBOrders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FnBOrderDetails",
                table: "FnBOrderDetails");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "Product");

            migrationBuilder.RenameTable(
                name: "ProductCategories",
                newName: "ProductCategory");

            migrationBuilder.RenameTable(
                name: "Menus",
                newName: "Menu");

            migrationBuilder.RenameTable(
                name: "MenuItems",
                newName: "MenuItem");

            migrationBuilder.RenameTable(
                name: "FoodTypes",
                newName: "FoodType");

            migrationBuilder.RenameTable(
                name: "FoodInventories",
                newName: "FoodInventory");

            migrationBuilder.RenameTable(
                name: "FnBOrders",
                newName: "FnBOrder");

            migrationBuilder.RenameTable(
                name: "FnBOrderDetails",
                newName: "FnBOrderDetail");

            migrationBuilder.RenameIndex(
                name: "IX_Products_ProductCategoryCategoryID",
                table: "Product",
                newName: "IX_Product_ProductCategoryCategoryID");

            migrationBuilder.RenameIndex(
                name: "IX_MenuItems_ProductID",
                table: "MenuItem",
                newName: "IX_MenuItem_ProductID");

            migrationBuilder.RenameIndex(
                name: "IX_MenuItems_MenuID",
                table: "MenuItem",
                newName: "IX_MenuItem_MenuID");

            migrationBuilder.RenameIndex(
                name: "IX_FoodInventories_FoodTypeFID",
                table: "FoodInventory",
                newName: "IX_FoodInventory_FoodTypeFID");

            migrationBuilder.RenameIndex(
                name: "IX_FnBOrders_UserUID",
                table: "FnBOrder",
                newName: "IX_FnBOrder_UserUID");

            migrationBuilder.RenameIndex(
                name: "IX_FnBOrderDetails_ProductID",
                table: "FnBOrderDetail",
                newName: "IX_FnBOrderDetail_ProductID");

            migrationBuilder.RenameIndex(
                name: "IX_FnBOrderDetails_FnBOrderID",
                table: "FnBOrderDetail",
                newName: "IX_FnBOrderDetail_FnBOrderID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Product",
                table: "Product",
                column: "ProductID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductCategory",
                table: "ProductCategory",
                column: "CategoryID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Menu",
                table: "Menu",
                column: "MenuID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MenuItem",
                table: "MenuItem",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FoodType",
                table: "FoodType",
                column: "FID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FoodInventory",
                table: "FoodInventory",
                column: "RecordID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FnBOrder",
                table: "FnBOrder",
                column: "FnBOrderID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FnBOrderDetail",
                table: "FnBOrderDetail",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_FnBOrder_User_UserUID",
                table: "FnBOrder",
                column: "UserUID",
                principalTable: "User",
                principalColumn: "UID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FnBOrderDetail_FnBOrder_FnBOrderID",
                table: "FnBOrderDetail",
                column: "FnBOrderID",
                principalTable: "FnBOrder",
                principalColumn: "FnBOrderID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FnBOrderDetail_Product_ProductID",
                table: "FnBOrderDetail",
                column: "ProductID",
                principalTable: "Product",
                principalColumn: "ProductID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FoodInventory_FoodType_FoodTypeFID",
                table: "FoodInventory",
                column: "FoodTypeFID",
                principalTable: "FoodType",
                principalColumn: "FID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MenuItem_Menu_MenuID",
                table: "MenuItem",
                column: "MenuID",
                principalTable: "Menu",
                principalColumn: "MenuID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MenuItem_Product_ProductID",
                table: "MenuItem",
                column: "ProductID",
                principalTable: "Product",
                principalColumn: "ProductID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_ProductCategory_ProductCategoryCategoryID",
                table: "Product",
                column: "ProductCategoryCategoryID",
                principalTable: "ProductCategory",
                principalColumn: "CategoryID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
