using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Falcons.Migrations
{
    public partial class AddFnBOrderFnBOrderDetail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FnBOrder",
                columns: table => new
                {
                    FnBOrderID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserUID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FnBOrder", x => x.FnBOrderID);
                    table.ForeignKey(
                        name: "FK_FnBOrder_User_UserUID",
                        column: x => x.UserUID,
                        principalTable: "User",
                        principalColumn: "UID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Menu",
                columns: table => new
                {
                    MenuID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PackageName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Description = table.Column<string>(type: "ntext", maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menu", x => x.MenuID);
                });

            migrationBuilder.CreateTable(
                name: "FnBOrderDetail",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FnBOrderID = table.Column<int>(type: "int", nullable: true),
                    ProductID = table.Column<int>(type: "int", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    ProductPrice = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FnBOrderDetail", x => x.ID);
                    table.ForeignKey(
                        name: "FK_FnBOrderDetail_FnBOrder_FnBOrderID",
                        column: x => x.FnBOrderID,
                        principalTable: "FnBOrder",
                        principalColumn: "FnBOrderID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FnBOrderDetail_Product_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Product",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MenuItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MenuID = table.Column<int>(type: "int", nullable: false),
                    ProductID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MenuItem_Menu_MenuID",
                        column: x => x.MenuID,
                        principalTable: "Menu",
                        principalColumn: "MenuID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MenuItem_Product_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Product",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FnBOrder_UserUID",
                table: "FnBOrder",
                column: "UserUID");

            migrationBuilder.CreateIndex(
                name: "IX_FnBOrderDetail_FnBOrderID",
                table: "FnBOrderDetail",
                column: "FnBOrderID");

            migrationBuilder.CreateIndex(
                name: "IX_FnBOrderDetail_ProductID",
                table: "FnBOrderDetail",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_MenuItem_MenuID",
                table: "MenuItem",
                column: "MenuID");

            migrationBuilder.CreateIndex(
                name: "IX_MenuItem_ProductID",
                table: "MenuItem",
                column: "ProductID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FnBOrderDetail");

            migrationBuilder.DropTable(
                name: "MenuItem");

            migrationBuilder.DropTable(
                name: "FnBOrder");

            migrationBuilder.DropTable(
                name: "Menu");
        }
    }
}
