using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAO.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "User",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Email = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false),
                    Role = table.Column<int>(nullable: false),
                    Fullname = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Film",
                columns: table => new
                {
                    FilmId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    RunTime = table.Column<int>(nullable: false),
                    FilmAddress = table.Column<string>(nullable: false),
                    GenreId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Film", x => x.FilmId);
                    table.ForeignKey(
                        name: "FK_Film_Genre_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genre",
                        principalColumn: "GenreId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Friendships",
                columns: table => new
                {
                    InvitingUserId = table.Column<int>(nullable: false),
                    InvitedUserId = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Friendships", x => new { x.InvitedUserId, x.InvitingUserId });
                    table.ForeignKey(
                        name: "FK_Friendships_User_InvitedUserId",
                        column: x => x.InvitedUserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Friendships_User_InvitingUserId",
                        column: x => x.InvitingUserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    PostID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Content = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    SentUserId = table.Column<int>(nullable: false),
                    ReceivedUserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.PostID);
                    table.ForeignKey(
                        name: "FK_Posts_User_ReceivedUserId",
                        column: x => x.ReceivedUserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Posts_User_SentUserId",
                        column: x => x.SentUserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserFilm",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false),
                    FilmId = table.Column<int>(nullable: false),
                    SecondsWatched = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserFilm", x => new { x.UserId, x.FilmId });
                    table.ForeignKey(
                        name: "FK_UserFilm_Film_FilmId",
                        column: x => x.FilmId,
                        principalTable: "Film",
                        principalColumn: "FilmId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserFilm_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserFilmInvites",
                columns: table => new
                {
                    InvitingUserId = table.Column<int>(nullable: false),
                    InvitedUserId = table.Column<int>(nullable: false),
                    FilmId = table.Column<int>(nullable: false),
                    WatchDate = table.Column<DateTime>(nullable: false),
                    Created = table.Column<DateTime>(nullable: false),
                    isAccepted = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserFilmInvites", x => new { x.InvitedUserId, x.InvitingUserId, x.FilmId });
                    table.ForeignKey(
                        name: "FK_UserFilmInvites_Film_FilmId",
                        column: x => x.FilmId,
                        principalTable: "Film",
                        principalColumn: "FilmId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserFilmInvites_User_InvitedUserId",
                        column: x => x.InvitedUserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserFilmInvites_User_InvitingUserId",
                        column: x => x.InvitingUserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "UserId", "Email", "Fullname", "Password", "Role" },
                values: new object[] { 1, "admin@demo.com", "admin", "@123456Xx", 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Film_GenreId",
                table: "Film",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_Friendships_InvitingUserId",
                table: "Friendships",
                column: "InvitingUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_ReceivedUserId",
                table: "Posts",
                column: "ReceivedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_SentUserId",
                table: "Posts",
                column: "SentUserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserFilm_FilmId",
                table: "UserFilm",
                column: "FilmId");

            migrationBuilder.CreateIndex(
                name: "IX_UserFilmInvites_FilmId",
                table: "UserFilmInvites",
                column: "FilmId");

            migrationBuilder.CreateIndex(
                name: "IX_UserFilmInvites_InvitingUserId",
                table: "UserFilmInvites",
                column: "InvitingUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Friendships");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "UserFilm");

            migrationBuilder.DropTable(
                name: "UserFilmInvites");

            migrationBuilder.DropTable(
                name: "Film");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Genre");
        }
    }
}
