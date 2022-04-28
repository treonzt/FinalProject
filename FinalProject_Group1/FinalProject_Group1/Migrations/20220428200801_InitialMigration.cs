using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProject_Group1.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TeamInfo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fullName = table.Column<string>(nullable: true),
                    birthdate = table.Column<DateTime>(nullable: false),
                    collegeProgram = table.Column<string>(nullable: true),
                    yearInProgram = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamInfo", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "TeamInfo",
                columns: new[] { "Id", "birthdate", "collegeProgram", "fullName", "yearInProgram" },
                values: new object[] { 1, new DateTime(2002, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cybersecurity and Software Development", "Ishani Saxena", "sophomore" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TeamInfo");
        }
    }
}
