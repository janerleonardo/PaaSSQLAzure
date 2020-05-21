using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApiSQLAzure.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ContactSet",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Nombre = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    telefono = table.Column<string>(maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactSet", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContactSet");
        }
    }
}
