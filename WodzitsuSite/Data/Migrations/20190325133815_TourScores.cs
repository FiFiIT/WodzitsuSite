using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WodzitsuSite.Migrations
{
    public partial class TourScores : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Organizator",
                table: "Tours",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Opis",
                table: "Tours",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Tours",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TourScoreId",
                table: "Tours",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TourScoreId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Scores",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Score = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Scores", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tours_TourScoreId",
                table: "Tours",
                column: "TourScoreId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_TourScoreId",
                table: "AspNetUsers",
                column: "TourScoreId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Scores_TourScoreId",
                table: "AspNetUsers",
                column: "TourScoreId",
                principalTable: "Scores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tours_Scores_TourScoreId",
                table: "Tours",
                column: "TourScoreId",
                principalTable: "Scores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Scores_TourScoreId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Tours_Scores_TourScoreId",
                table: "Tours");

            migrationBuilder.DropTable(
                name: "Scores");

            migrationBuilder.DropIndex(
                name: "IX_Tours_TourScoreId",
                table: "Tours");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_TourScoreId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "TourScoreId",
                table: "Tours");

            migrationBuilder.DropColumn(
                name: "TourScoreId",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<string>(
                name: "Organizator",
                table: "Tours",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Opis",
                table: "Tours",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Tours",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
