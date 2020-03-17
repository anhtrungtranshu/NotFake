using Microsoft.EntityFrameworkCore.Migrations;

namespace DAO.Migrations
{
    public partial class UserFilmUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "UserFilm",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserFilm_UserId",
                table: "UserFilm",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserFilm_User_UserId",
                table: "UserFilm",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserFilm_User_UserId",
                table: "UserFilm");

            migrationBuilder.DropIndex(
                name: "IX_UserFilm_UserId",
                table: "UserFilm");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "UserFilm");
        }
    }
}
