using Microsoft.EntityFrameworkCore.Migrations;

namespace WodzitsuSite.Migrations
{
    public partial class TourScores2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Scores_TourScoreId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Tours_Scores_TourScoreId",
                table: "Tours");

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

            migrationBuilder.AddColumn<int>(
                name: "TourID",
                table: "Scores",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Scores",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TourID",
                table: "Scores");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Scores");

            migrationBuilder.AddColumn<int>(
                name: "TourScoreId",
                table: "Tours",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TourScoreId",
                table: "AspNetUsers",
                nullable: true);

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
    }
}
