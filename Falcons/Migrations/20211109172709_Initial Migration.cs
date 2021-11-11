using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Falcons.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Booking",
                columns: table => new
                {
                    BID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    paymentID = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    UID = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    MID = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    bookingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    bookingTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Booking", x => x.BID);
                });

            migrationBuilder.CreateTable(
                name: "Ticket",
                columns: table => new
                {
                    TID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    movieName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    hallNo = table.Column<int>(type: "int", maxLength: 3, nullable: false),
                    seatNo = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    showDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    showTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    bookingID = table.Column<int>(type: "int", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ticket", x => x.TID);
                    table.ForeignKey(
                        name: "FK_Ticket_Booking_bookingID",
                        column: x => x.bookingID,
                        principalTable: "Booking",
                        principalColumn: "BID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_bookingID",
                table: "Ticket",
                column: "bookingID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ticket");

            migrationBuilder.DropTable(
                name: "Booking");
        }
    }
}
