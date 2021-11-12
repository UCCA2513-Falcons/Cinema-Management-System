using Microsoft.EntityFrameworkCore.Migrations;

namespace Falcons.Migrations
{
    public partial class ModifyDBProductTable4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropIndex(
                name: "IX_FnBOrderDetails_FnBOrderID",
                table: "FnBOrderDetails");

            migrationBuilder.DropColumn(
                name: "FnBOrderID",
                table: "FnBOrderDetails");

            migrationBuilder.RenameColumn(
                name: "FoodTypeFID",
                table: "FoodInventories",
                newName: "FID");

            migrationBuilder.RenameIndex(
                name: "IX_FoodInventories_FoodTypeFID",
                table: "FoodInventories",
                newName: "IX_FoodInventories_FID");

            migrationBuilder.RenameColumn(
                name: "UserUID",
                table: "FnBOrders",
                newName: "UID");

            migrationBuilder.RenameIndex(
                name: "IX_FnBOrders_UserUID",
                table: "FnBOrders",
                newName: "IX_FnBOrders_UID");

            migrationBuilder.AlterColumn<int>(
                name: "ProductID",
                table: "FnBOrderDetails",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OrderID",
                table: "FnBOrderDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_FnBOrderDetails_OrderID",
                table: "FnBOrderDetails",
                column: "OrderID");

            migrationBuilder.AddForeignKey(
                name: "FK_FnBOrderDetails_FnBOrders_OrderID",
                table: "FnBOrderDetails",
                column: "OrderID",
                principalTable: "FnBOrders",
                principalColumn: "FnBOrderID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FnBOrderDetails_Products_ProductID",
                table: "FnBOrderDetails",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "ProductID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FnBOrders_User_UID",
                table: "FnBOrders",
                column: "UID",
                principalTable: "User",
                principalColumn: "UID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FoodInventories_FoodTypes_FID",
                table: "FoodInventories",
                column: "FID",
                principalTable: "FoodTypes",
                principalColumn: "FID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FnBOrderDetails_FnBOrders_OrderID",
                table: "FnBOrderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_FnBOrderDetails_Products_ProductID",
                table: "FnBOrderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_FnBOrders_User_UID",
                table: "FnBOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_FoodInventories_FoodTypes_FID",
                table: "FoodInventories");

            migrationBuilder.DropIndex(
                name: "IX_FnBOrderDetails_OrderID",
                table: "FnBOrderDetails");

            migrationBuilder.DropColumn(
                name: "OrderID",
                table: "FnBOrderDetails");

            migrationBuilder.RenameColumn(
                name: "FID",
                table: "FoodInventories",
                newName: "FoodTypeFID");

            migrationBuilder.RenameIndex(
                name: "IX_FoodInventories_FID",
                table: "FoodInventories",
                newName: "IX_FoodInventories_FoodTypeFID");

            migrationBuilder.RenameColumn(
                name: "UID",
                table: "FnBOrders",
                newName: "UserUID");

            migrationBuilder.RenameIndex(
                name: "IX_FnBOrders_UID",
                table: "FnBOrders",
                newName: "IX_FnBOrders_UserUID");

            migrationBuilder.AlterColumn<int>(
                name: "ProductID",
                table: "FnBOrderDetails",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "FnBOrderID",
                table: "FnBOrderDetails",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_FnBOrderDetails_FnBOrderID",
                table: "FnBOrderDetails",
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
        }
    }
}
