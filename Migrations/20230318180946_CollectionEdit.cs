using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LampStore.Migrations
{
    public partial class CollectionEdit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_CollectionLights_CollectionLightID",
                table: "Products");

            migrationBuilder.AlterColumn<int>(
                name: "CollectionLightID",
                table: "Products",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_CollectionLights_CollectionLightID",
                table: "Products",
                column: "CollectionLightID",
                principalTable: "CollectionLights",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_CollectionLights_CollectionLightID",
                table: "Products");

            migrationBuilder.AlterColumn<int>(
                name: "CollectionLightID",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_CollectionLights_CollectionLightID",
                table: "Products",
                column: "CollectionLightID",
                principalTable: "CollectionLights",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
