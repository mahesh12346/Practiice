using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Practice.Migrations
{
    public partial class AddComapnyToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Componies",
                columns: table => new
                {
                    comapny_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    comapny_name = table.Column<string>(nullable: true),
                    company_founded_on = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Componies", x => x.comapny_id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Componies");
        }
    }
}
