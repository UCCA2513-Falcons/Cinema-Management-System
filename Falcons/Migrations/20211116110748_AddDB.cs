using Microsoft.EntityFrameworkCore.Migrations;

namespace Falcons.Migrations
{
    public partial class AddDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SeatSID",
                table: "Booking",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Seat",
                columns: table => new
                {
                    SID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HID = table.Column<int>(type: "int", nullable: false),
                    BID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seat", x => x.SID);
                });

            migrationBuilder.CreateTable(
                name: "Hall",
                columns: table => new
                {
                    HID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    seatSID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hall", x => x.HID);
                    table.ForeignKey(
                        name: "FK_Hall_Seat_seatSID",
                        column: x => x.seatSID,
                        principalTable: "Seat",
                        principalColumn: "SID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Booking_SeatSID",
                table: "Booking",
                column: "SeatSID");

            migrationBuilder.CreateIndex(
                name: "IX_Hall_seatSID",
                table: "Hall",
                column: "seatSID");

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_Seat_SeatSID",
                table: "Booking",
                column: "SeatSID",
                principalTable: "Seat",
                principalColumn: "SID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Booking_Seat_SeatSID",
                table: "Booking");

            migrationBuilder.DropTable(
                name: "Hall");

            migrationBuilder.DropTable(
                name: "Seat");

            migrationBuilder.DropIndex(
                name: "IX_Booking_SeatSID",
                table: "Booking");

            migrationBuilder.DropColumn(
                name: "SeatSID",
                table: "Booking");
        }
    }
}
