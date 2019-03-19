using Microsoft.EntityFrameworkCore.Migrations;

namespace WodzitsuSite.Migrations
{
    public partial class NewColumnOpis : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Opis",
                table: "Tours",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Opis",
                table: "Tours");
        }
    }
}
