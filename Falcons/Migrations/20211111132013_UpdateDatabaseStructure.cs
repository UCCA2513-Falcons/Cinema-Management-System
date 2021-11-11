using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Falcons.Migrations
{
    public partial class UpdateDatabaseStructure : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FnBOrders_User_UID",
                table: "FnBOrders");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropIndex(
                name: "IX_FnBOrders_UID",
                table: "FnBOrders");

            migrationBuilder.DropColumn(
                name: "EstimatePrice",
                table: "Menus");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "EstimatePrice",
                table: "Menus",
                type: "decimal(6,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    RoleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookingBID = table.Column<int>(type: "int", nullable: true),
                    Position = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    RoleTitle = table.Column<string>(type: "ntext", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.RoleID);
                    table.ForeignKey(
                        name: "FK_Role_Booking_BookingBID",
                        column: x => x.BookingBID,
                        principalTable: "Booking",
                        principalColumn: "BID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApprovalStatus = table.Column<bool>(type: "bit", nullable: false),
                    BlockSuspicious = table.Column<bool>(type: "bit", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    PhoneNo = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    RoleID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UID);
                    table.ForeignKey(
                        name: "FK_User_Role_RoleID",
                        column: x => x.RoleID,
                        principalTable: "Role",
                        principalColumn: "RoleID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FnBOrders_UID",
                table: "FnBOrders",
                column: "UID");

            migrationBuilder.CreateIndex(
                name: "IX_Role_BookingBID",
                table: "Role",
                column: "BookingBID");

            migrationBuilder.CreateIndex(
                name: "IX_User_RoleID",
                table: "User",
                column: "RoleID");

            migrationBuilder.AddForeignKey(
                name: "FK_FnBOrders_User_UID",
                table: "FnBOrders",
                column: "UID",
                principalTable: "User",
                principalColumn: "UID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
