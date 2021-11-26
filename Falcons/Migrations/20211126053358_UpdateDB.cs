using Microsoft.EntityFrameworkCore.Migrations;

namespace Falcons.Migrations
{
    public partial class UpdateDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Distributor",
                table: "Movies");

            migrationBuilder.RenameColumn(
                name: "ShowroomNo",
                table: "Showtime",
                newName: "ShowroomID");

            migrationBuilder.AddColumn<int>(
                name: "MovieID",
                table: "Showtime",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "MoviesImgURL",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Hall",
                columns: table => new
                {
                    ShowroomID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShowroomName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hall", x => x.ShowroomID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Showtime_ShowroomID",
                table: "Showtime",
                column: "ShowroomID");

            migrationBuilder.AddForeignKey(
                name: "FK_Showtime_Hall_ShowroomID",
                table: "Showtime",
                column: "ShowroomID",
                principalTable: "Hall",
                principalColumn: "ShowroomID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Showtime_Hall_ShowroomID",
                table: "Showtime");

            migrationBuilder.DropTable(
                name: "Hall");

            migrationBuilder.DropIndex(
                name: "IX_Showtime_ShowroomID",
                table: "Showtime");

            migrationBuilder.DropColumn(
                name: "MovieID",
                table: "Showtime");

            migrationBuilder.DropColumn(
                name: "MoviesImgURL",
                table: "Movies");

            migrationBuilder.RenameColumn(
                name: "ShowroomID",
                table: "Showtime",
                newName: "ShowroomNo");

            migrationBuilder.AddColumn<string>(
                name: "Distributor",
                table: "Movies",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");
        }
    }
}
