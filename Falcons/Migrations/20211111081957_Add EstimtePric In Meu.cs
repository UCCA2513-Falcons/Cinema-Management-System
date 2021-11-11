using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Falcons.Migrations
{
    public partial class AddEstimtePricInMeu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ticket_Booking_bookingID",
                table: "Ticket");

            migrationBuilder.DropIndex(
                name: "IX_Ticket_bookingID",
                table: "Ticket");

            migrationBuilder.DropColumn(
                name: "MID",
                table: "Ticket");

            migrationBuilder.DropColumn(
                name: "hallNo",
                table: "Ticket");

            migrationBuilder.DropColumn(
                name: "movieName",
                table: "Ticket");

            migrationBuilder.DropColumn(
                name: "seatNo",
                table: "Ticket");

            migrationBuilder.DropColumn(
                name: "showDate",
                table: "Ticket");

            migrationBuilder.DropColumn(
                name: "showTime",
                table: "Ticket");

            migrationBuilder.RenameColumn(
                name: "UID",
                table: "Booking",
                newName: "RoleID");

            migrationBuilder.AddColumn<double>(
                name: "amount",
                table: "Ticket",
                type: "float",
                maxLength: 10,
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "BookingBID",
                table: "Role",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "EstimatePrice",
                table: "Menus",
                type: "decimal(6,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<double>(
                name: "amount",
                table: "Booking",
                type: "float",
                maxLength: 10,
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<DateTime>(
                name: "showDate",
                table: "Booking",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "showTime",
                table: "Booking",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "ticketTID",
                table: "Booking",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Role_BookingBID",
                table: "Role",
                column: "BookingBID");

            migrationBuilder.CreateIndex(
                name: "IX_Booking_ticketTID",
                table: "Booking",
                column: "ticketTID");

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_Ticket_ticketTID",
                table: "Booking",
                column: "ticketTID",
                principalTable: "Ticket",
                principalColumn: "TID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Role_Booking_BookingBID",
                table: "Role",
                column: "BookingBID",
                principalTable: "Booking",
                principalColumn: "BID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Booking_Ticket_ticketTID",
                table: "Booking");

            migrationBuilder.DropForeignKey(
                name: "FK_Role_Booking_BookingBID",
                table: "Role");

            migrationBuilder.DropIndex(
                name: "IX_Role_BookingBID",
                table: "Role");

            migrationBuilder.DropIndex(
                name: "IX_Booking_ticketTID",
                table: "Booking");

            migrationBuilder.DropColumn(
                name: "amount",
                table: "Ticket");

            migrationBuilder.DropColumn(
                name: "BookingBID",
                table: "Role");

            migrationBuilder.DropColumn(
                name: "EstimatePrice",
                table: "Menus");

            migrationBuilder.DropColumn(
                name: "amount",
                table: "Booking");

            migrationBuilder.DropColumn(
                name: "showDate",
                table: "Booking");

            migrationBuilder.DropColumn(
                name: "showTime",
                table: "Booking");

            migrationBuilder.DropColumn(
                name: "ticketTID",
                table: "Booking");

            migrationBuilder.RenameColumn(
                name: "RoleID",
                table: "Booking",
                newName: "UID");

            migrationBuilder.AddColumn<string>(
                name: "MID",
                table: "Ticket",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "hallNo",
                table: "Ticket",
                type: "int",
                maxLength: 3,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "movieName",
                table: "Ticket",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "seatNo",
                table: "Ticket",
                type: "nvarchar(5)",
                maxLength: 5,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "showDate",
                table: "Ticket",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "showTime",
                table: "Ticket",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_bookingID",
                table: "Ticket",
                column: "bookingID");

            migrationBuilder.AddForeignKey(
                name: "FK_Ticket_Booking_bookingID",
                table: "Ticket",
                column: "bookingID",
                principalTable: "Booking",
                principalColumn: "BID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
