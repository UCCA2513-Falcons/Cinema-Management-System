using Microsoft.EntityFrameworkCore.Migrations;

namespace Falcons.Migrations
{
    public partial class RequiredforFoodInventorytohaveFoodType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FoodInventory_FoodType_FoodTypeFID",
                table: "FoodInventory");

            migrationBuilder.AlterColumn<int>(
                name: "FoodTypeFID",
                table: "FoodInventory",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_FoodInventory_FoodType_FoodTypeFID",
                table: "FoodInventory",
                column: "FoodTypeFID",
                principalTable: "FoodType",
                principalColumn: "FID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FoodInventory_FoodType_FoodTypeFID",
                table: "FoodInventory");

            migrationBuilder.AlterColumn<int>(
                name: "FoodTypeFID",
                table: "FoodInventory",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_FoodInventory_FoodType_FoodTypeFID",
                table: "FoodInventory",
                column: "FoodTypeFID",
                principalTable: "FoodType",
                principalColumn: "FID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
