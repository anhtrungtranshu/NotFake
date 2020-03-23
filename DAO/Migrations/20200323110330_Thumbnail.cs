using Microsoft.EntityFrameworkCore.Migrations;

namespace DAO.Migrations
{
    public partial class Thumbnail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ThumbnailAddress",
                table: "Film",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ThumbnailAddress",
                table: "Film");
        }
    }
}
