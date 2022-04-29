using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProject_Group1.Migrations
{
    public partial class FavoriteFoodsMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FavoriteFoods",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    favBreakfast = table.Column<string>(nullable: true),
                    favLunch = table.Column<string>(nullable: false),
                    FavDinner = table.Column<string>(nullable: true),
                    FavDessert = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FavoriteFoods", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "FavoriteFoods",
                columns: new[] { "Id", "favBreakfast", "favLunch", "favDinner", "favDessert" },
                values: new object[] { 1, "Biscuits and Gravy", "Tacos, any kind!", "Steak and Potatoes", "Cheesecake" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FavoriteFoods");
        }
    }
}
