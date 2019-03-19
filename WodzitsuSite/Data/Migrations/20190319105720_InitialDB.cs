using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WodzitsuSite.Migrations
{
    public partial class InitialDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tours",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    TerminOd = table.Column<DateTime>(nullable: false),
                    TerminDo = table.Column<DateTime>(nullable: false),
                    SamolotFirma = table.Column<string>(nullable: true),
                    SamolotCena = table.Column<decimal>(nullable: false),
                    Hotel = table.Column<string>(nullable: true),
                    HotelCena = table.Column<decimal>(nullable: false),
                    Organizator = table.Column<string>(nullable: true),
                    Zdjecie = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tours", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tours");
        }
    }
}
