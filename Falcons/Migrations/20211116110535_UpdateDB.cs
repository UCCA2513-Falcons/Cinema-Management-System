using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Falcons.Migrations
{
    public partial class UpdateDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Employee_EmployeesEmpID",
                table: "Employee");

            migrationBuilder.DropIndex(
                name: "IX_Employee_EmployeesEmpID",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "EmployeesEmpID",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "RoleID",
                table: "Booking");

            migrationBuilder.DropColumn(
                name: "bookingDate",
                table: "Booking");

            migrationBuilder.DropColumn(
                name: "bookingTime",
                table: "Booking");

            migrationBuilder.DropColumn(
                name: "paymentID",
                table: "Booking");

            migrationBuilder.RenameColumn(
                name: "bookingID",
                table: "Ticket",
                newName: "BID");

            migrationBuilder.RenameColumn(
                name: "showTime",
                table: "Booking",
                newName: "showDateTime");

            migrationBuilder.RenameColumn(
                name: "showDate",
                table: "Booking",
                newName: "bookingDateTime");

            migrationBuilder.RenameColumn(
                name: "BID",
                table: "Booking",
                newName: "ID");

            migrationBuilder.AddColumn<string>(
                name: "email",
                table: "Booking",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "movieName",
                table: "Booking",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    MovieID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MovieName = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    Duration = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Subtitle = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Language = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Genre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Director = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Category = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Synopsis = table.Column<string>(type: "ntext", maxLength: 2000, nullable: true),
                    Distributor = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Cast = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.MovieID);
                });

            migrationBuilder.CreateTable(
                name: "Showtime",
                columns: table => new
                {
                    ShowtimeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShowroomNo = table.Column<int>(type: "int", nullable: false),
                    StartDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MoviesMovieID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Showtime", x => x.ShowtimeID);
                    table.ForeignKey(
                        name: "FK_Showtime_Movies_MoviesMovieID",
                        column: x => x.MoviesMovieID,
                        principalTable: "Movies",
                        principalColumn: "MovieID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Showtime_MoviesMovieID",
                table: "Showtime",
                column: "MoviesMovieID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Showtime");

            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropColumn(
                name: "email",
                table: "Booking");

            migrationBuilder.DropColumn(
                name: "movieName",
                table: "Booking");

            migrationBuilder.RenameColumn(
                name: "BID",
                table: "Ticket",
                newName: "bookingID");

            migrationBuilder.RenameColumn(
                name: "showDateTime",
                table: "Booking",
                newName: "showTime");

            migrationBuilder.RenameColumn(
                name: "bookingDateTime",
                table: "Booking",
                newName: "showDate");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Booking",
                newName: "BID");

            migrationBuilder.AddColumn<int>(
                name: "EmployeesEmpID",
                table: "Employee",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RoleID",
                table: "Booking",
                type: "int",
                maxLength: 10,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "bookingDate",
                table: "Booking",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "bookingTime",
                table: "Booking",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "paymentID",
                table: "Booking",
                type: "int",
                maxLength: 10,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Employee_EmployeesEmpID",
                table: "Employee",
                column: "EmployeesEmpID");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Employee_EmployeesEmpID",
                table: "Employee",
                column: "EmployeesEmpID",
                principalTable: "Employee",
                principalColumn: "EmpID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
