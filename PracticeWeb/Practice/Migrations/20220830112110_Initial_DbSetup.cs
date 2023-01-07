using Microsoft.EntityFrameworkCore.Migrations;

namespace Practice.Migrations
{
    public partial class Initial_DbSetup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    empno = table.Column<string>(nullable: false),
                    birthdate = table.Column<string>(nullable: true),
                    firts_name = table.Column<string>(nullable: true),
                    last_name = table.Column<string>(nullable: true),
                    gender = table.Column<string>(nullable: true),
                    hire_date = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.empno);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
