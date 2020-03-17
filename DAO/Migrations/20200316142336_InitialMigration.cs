using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAO.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Film",
                columns: table => new
                {
                    FilmId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    RunTime = table.Column<int>(nullable: false),
                    FilmAddress = table.Column<string>(nullable: true),
                    GenreID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Film", x => x.FilmId);
                });

            migrationBuilder.CreateTable(
                name: "Genre",
                columns: table => new
                {
                    GenreId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genre", x => x.GenreId);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    User1ID = table.Column<int>(nullable: false),
                    User2ID = table.Column<int>(nullable: false),
                    Content = table.Column<string>(nullable: false),
                    Created = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => new { x.User1ID, x.User2ID });
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Email = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Role = table.Column<int>(nullable: false),
                    Fullname = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserFilm",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false),
                    FilmId = table.Column<int>(nullable: false),
                    SecondsWatched = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserFilm", x => new { x.UserId, x.FilmId });
                });

            migrationBuilder.CreateTable(
                name: "UserFilmInvites",
                columns: table => new
                {
                    User1ID = table.Column<int>(nullable: false),
                    User2ID = table.Column<int>(nullable: false),
                    FilmID = table.Column<int>(nullable: false),
                    WatchDate = table.Column<DateTime>(nullable: false),
                    Created = table.Column<DateTime>(nullable: false),
                    isAccepted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserFilmInvites", x => new { x.User1ID, x.User2ID, x.FilmID, x.WatchDate });
                });

            migrationBuilder.CreateTable(
                name: "Friendships",
                columns: table => new
                {
                    User1Id = table.Column<int>(nullable: false),
                    User2Id = table.Column<int>(nullable: false),
                    status = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Friendships", x => new { x.User1Id, x.User2Id });
                    table.ForeignKey(
                        name: "FK_Friendships_User_User1Id",
                        column: x => x.User1Id,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Friendships_User_User2Id",
                        column: x => x.User2Id,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Email", "Fullname", "Password", "Role" },
                values: new object[] { 1, "admin@demo.com", "admin", "@123456Xx", 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Friendships_User2Id",
                table: "Friendships",
                column: "User2Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Film");

            migrationBuilder.DropTable(
                name: "Friendships");

            migrationBuilder.DropTable(
                name: "Genre");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "UserFilm");

            migrationBuilder.DropTable(
                name: "UserFilmInvites");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
