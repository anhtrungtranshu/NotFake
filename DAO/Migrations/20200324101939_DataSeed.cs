using Microsoft.EntityFrameworkCore.Migrations;

namespace DAO.Migrations
{
    public partial class DataSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Film_Genre_GenreId",
                table: "Film");

            migrationBuilder.AlterColumn<string>(
                name: "ThumbnailAddress",
                table: "Film",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "GenreId",
                table: "Film",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Genre",
                columns: new[] { "GenreId", "Name" },
                values: new object[] { 1, "Comedies" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 1,
                column: "Password",
                value: "APPVwpd/Tr4SRfJPU+8iupNtBDr7wpXtN463r5v9GuDvAg/w2iycGO07fogrg6V9Rg==");

            migrationBuilder.InsertData(
                table: "Film",
                columns: new[] { "FilmId", "FilmAddress", "GenreId", "Name", "RunTime", "ThumbnailAddress" },
                values: new object[] { 1, "", 1, "Balloon", 100, "../../NotFake/wwwroot/Thumbnails/Balloon.PNG" });

            migrationBuilder.AddForeignKey(
                name: "FK_Film_Genre_GenreId",
                table: "Film",
                column: "GenreId",
                principalTable: "Genre",
                principalColumn: "GenreId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Film_Genre_GenreId",
                table: "Film");

            migrationBuilder.DeleteData(
                table: "Film",
                keyColumn: "FilmId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "GenreId",
                keyValue: 1);

            migrationBuilder.AlterColumn<string>(
                name: "ThumbnailAddress",
                table: "Film",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<int>(
                name: "GenreId",
                table: "Film",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 1,
                column: "Password",
                value: "@123456Xx");

            migrationBuilder.AddForeignKey(
                name: "FK_Film_Genre_GenreId",
                table: "Film",
                column: "GenreId",
                principalTable: "Genre",
                principalColumn: "GenreId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
