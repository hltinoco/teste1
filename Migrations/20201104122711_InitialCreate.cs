using Microsoft.EntityFrameworkCore.Migrations;

namespace YClient_htinoco2.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Valorestab",
                columns: table => new
                {
                    NumeId = table.Column<int>(nullable: false),
                    Ndecimal = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Valorestab");
        }
    }
}
