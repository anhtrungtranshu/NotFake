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
                    ThumbnailAddress = table.Column<string>(nullable: false),
                    FilmAddress = table.Column<string>(nullable: false),
                    GenreId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Film", x => x.FilmId);
                    table.ForeignKey(
                        name: "FK_Film_Genre_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genre",
                        principalColumn: "GenreId",
                        onDelete: ReferentialAction.Cascade);
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
                table: "Genre",
                columns: new[] { "GenreId", "Name" },
                values: new object[] { 1, "Cartoons" });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "UserId", "Email", "Fullname", "Password", "Role" },
                values: new object[] { 1, "admin@demo.com", "admin", "AACG9LA7vAhCJLdaapTFWIUDKpCclLlbz6kqyXF4NIMIeZAQApMrQXT//TeBNDdO7g==", 1 });

            migrationBuilder.InsertData(
                table: "Film",
                columns: new[] { "FilmId", "FilmAddress", "GenreId", "Name", "RunTime", "ThumbnailAddress" },
                values: new object[,]
                {
                    { 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/001%20%20%20Puss%20Gets%20the%20Boot%20%5B1940%5D.mp4", 1, "Puss Gets the Boot", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/001%20%20%20Puss%20Gets%20the%20Boot%20%5B1940%5D_000001.jpg" },
                    { 103, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/103%20%20%20Blue%20Cat%20Blues%20%5B1956%5D.mp4", 1, "Blue Cat Blues", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/103%20%20%20Blue%20Cat%20Blues%20%5B1956%5D_000001.jpg" },
                    { 104, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/104%20%20%20Barbecue%20Brawl%20%5B1956%5D.mp4", 1, "Barbecue Brawl", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/104%20%20%20Barbecue%20Brawl%20%5B1956%5D_000001.jpg" },
                    { 105, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/105%20%20%20Tops%20with%20Pops%20%5B1957%5D.mp4", 1, "Tops with Pops", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/105%20%20%20Tops%20with%20Pops%20%5B1957%5D_000001.jpg" },
                    { 106, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/106%20%20%20Timid%20Tabby%20%5B1957%5D.mp4", 1, "Timid Tabby", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/106%20%20%20Timid%20Tabby%20%5B1957%5D_000001.jpg" },
                    { 107, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/107%20%20%20Feedin%27%20the%20Kiddie%20%5B1957%5D.mp4", 1, "Feedin' the Kiddie", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/107%20%20%20Feedin%27%20the%20Kiddie%20%5B1957%5D_000001.jpg" },
                    { 108, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/108%20%20%20Mucho%20Mouse%20%5B1957%5D.mp4", 1, "Mucho Mouse", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/108%20%20%20Mucho%20Mouse%20%5B1957%5D_000001.jpg" },
                    { 109, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/109%20%20%20Tom%27s%20Photo%20Finish%20%5B1957%5D.mp4", 1, "Tom's Photo Finish", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/109%20%20%20Tom%27s%20Photo%20Finish%20%5B1957%5D_000001.jpg" },
                    { 102, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/102%20%20%20Down%20Beat%20Bear%20%5B1956%5D.mp4", 1, "Down Beat Bear", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/102%20%20%20Down%20Beat%20Bear%20%5B1956%5D_000001.jpg" },
                    { 110, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/110%20%20%20Happy%20Go%20Ducky%20%5B1958%5D.mp4", 1, "Happy Go Ducky", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/110%20%20%20Happy%20Go%20Ducky%20%5B1958%5D_000001.jpg" },
                    { 112, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/112%20%20%20The%20Vanishing%20Duck%20%5B1958%5D.mp4", 1, "The Vanishing Duck", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/112%20%20%20The%20Vanishing%20Duck%20%5B1958%5D_000001.jpg" },
                    { 113, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/113%20%20%20Robin%20Hoodwinked%20%5B1958%5D.mp4", 1, "Robin Hoodwinked", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/113%20%20%20Robin%20Hoodwinked%20%5B1958%5D_000001.jpg" },
                    { 114, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/114%20%20%20Tot%20Watchers%20%5B1958%5D.mp4", 1, "Tot Watchers", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/114%20%20%20Tot%20Watchers%20%5B1958%5D_000001.jpg" },
                    { 115, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/115%20%20%20Switchin%27%20Kitten%20%5B1961%5D.mp4", 1, "Switchin' Kitten", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/115%20%20%20Switchin%27%20Kitten%20%5B1961%5D_000001.jpg" },
                    { 116, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/116%20%20%20Down%20and%20Outing%20%5B1961%5D.mp4", 1, "Down and Outing", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/116%20%20%20Down%20and%20Outing%20%5B1961%5D_000001.jpg" },
                    { 117, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/117%20%20%20It%27s%20Greek%20to%20Me%20ow%20%5B1961%5D.mp4", 1, "It's Greek to Me ow", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/117%20%20%20It%27s%20Greek%20to%20Me%20ow%20%5B1961%5D_000001.jpg" },
                    { 118, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/118%20%20%20High%20Steaks%20%5B1962%5D.mp4", 1, "High Steaks", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/118%20%20%20High%20Steaks%20%5B1962%5D_000001.jpg" },
                    { 111, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/111%20%20%20Royal%20Cat%20Nap%20%5B1958%5D.mp4", 1, "Royal Cat Nap", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/111%20%20%20Royal%20Cat%20Nap%20%5B1958%5D_000001.jpg" },
                    { 119, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/119%20%20%20Mouse%20Into%20Space%20%5B1962%5D.mp4", 1, "Mouse Into Space", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/119%20%20%20Mouse%20Into%20Space%20%5B1962%5D_000001.jpg" },
                    { 101, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/101%20%20%20Muscle%20Beach%20Tom%20%5B1956%5D.mp4", 1, "Muscle Beach Tom", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/101%20%20%20Muscle%20Beach%20Tom%20%5B1956%5D_000001.jpg" },
                    { 99, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/099%20%20%20The%20Egg%20and%20Jerry%20%5B1956%5D.mp4", 1, "The Egg and Jerry", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/099%20%20%20The%20Egg%20and%20Jerry%20%5B1956%5D_000001.jpg" },
                    { 83, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/083%20%20%20Little%20School%20Mouse%20%5B1954%5D.mp4", 1, "Little School Mouse", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/083%20%20%20Little%20School%20Mouse%20%5B1954%5D_000001.jpg" },
                    { 84, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/084%20%20%20Baby%20Butch%20%5B1954%5D.mp4", 1, "Baby Butch", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/084%20%20%20Baby%20Butch%20%5B1954%5D_000001.jpg" },
                    { 85, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/085%20%20%20Mice%20Follies%20%5B1954%5D.mp4", 1, "Mice Follies", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/085%20%20%20Mice%20Follies%20%5B1954%5D_000001.jpg" },
                    { 86, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/086%20%20%20Neapolitan%20Mouse%20%5B1954%5D.mp4", 1, "Neapolitan Mouse", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/086%20%20%20Neapolitan%20Mouse%20%5B1954%5D_000001.jpg" },
                    { 87, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/087%20%20%20Downhearted%20Duckling%20%5B1954%5D.mp4", 1, "Downhearted Duckling", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/087%20%20%20Downhearted%20Duckling%20%5B1954%5D_000001.jpg" },
                    { 88, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/088%20%20%20Pet%20Peeve%20%5B1954%5D.mp4", 1, "Pet Peeve", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/088%20%20%20Pet%20Peeve%20%5B1954%5D_000001.jpg" },
                    { 89, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/089%20%20%20Touch%C3%A9%2C%20Pussy%20Cat%21%20%5B1954%5D.mp4", 1, "Touché, Pussy Cat!", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/089%20%20%20Touch%C3%A9%2C%20Pussy%20Cat%21%20%5B1954%5D_000001.jpg" },
                    { 100, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/100%20%20%20Busy%20Buddies%20%5B1956%5D.mp4", 1, "Busy Buddies", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/100%20%20%20Busy%20Buddies%20%5B1956%5D_000001.jpg" },
                    { 90, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/090%20%20%20Southbound%20Duckling%20%5B1955%5D.mp4", 1, "Southbound Duckling", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/090%20%20%20Southbound%20Duckling%20%5B1955%5D_000001.jpg" },
                    { 92, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/092%20%20%20Mouse%20for%20Sale%20%5B1955%5D.mp4", 1, "Mouse for Sale", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/092%20%20%20Mouse%20for%20Sale%20%5B1955%5D_000001.jpg" },
                    { 93, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/093%20%20%20Designs%20on%20Jerry%20%5B1955%5D.mp4", 1, "Designs on Jerry", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/093%20%20%20Designs%20on%20Jerry%20%5B1955%5D_000001.jpg" },
                    { 94, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/094%20%20%20Tom%20and%20Ch%C3%A9rie%20%5B1955%5D.mp4", 1, "Tom and Chérie", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/094%20%20%20Tom%20and%20Ch%C3%A9rie%20%5B1955%5D_000001.jpg" },
                    { 95, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/095%20%20%20Smarty%20Cat%20%5B1955%5D.mp4", 1, "Smarty Cat", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/095%20%20%20Smarty%20Cat%20%5B1955%5D_000001.jpg" },
                    { 96, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/096%20%20%20Pecos%20Pest%20%5B1955%5D.mp4", 1, "Pecos Pest", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/096%20%20%20Pecos%20Pest%20%5B1955%5D_000001.jpg" },
                    { 97, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/097%20%20%20That%27s%20My%20Mommy%20%5B1955%5D.mp4", 1, "That's My Mommy", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/097%20%20%20That%27s%20My%20Mommy%20%5B1955%5D_000001.jpg" },
                    { 98, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/098%20%20%20The%20Flying%20Sorceress%20%5B1956%5D.mp4", 1, "The Flying Sorceress", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/098%20%20%20The%20Flying%20Sorceress%20%5B1956%5D_000001.jpg" },
                    { 91, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/091%20%20%20Pup%20on%20a%20Picnic%20%5B1955%5D.mp4", 1, "Pup on a Picnic", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/091%20%20%20Pup%20on%20a%20Picnic%20%5B1955%5D_000001.jpg" },
                    { 120, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/120%20%20%20Landing%20Stripling%20%5B1962%5D.mp4", 1, "Landing Stripling", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/120%20%20%20Landing%20Stripling%20%5B1962%5D_000001.jpg" },
                    { 121, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/121%20%20%20Calypso%20Cat%20%5B1962%5D.mp4", 1, "Calypso Cat", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/121%20%20%20Calypso%20Cat%20%5B1962%5D_000001.jpg" },
                    { 122, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/122%20%20%20Dicky%20Moe%20%5B1962%5D.mp4", 1, "Dicky Moe", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/122%20%20%20Dicky%20Moe%20%5B1962%5D_000001.jpg" },
                    { 144, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/144%20%20%20Jerry%2C%20Jerry%2C%20Quite%20Contrary%20%5B1966%5D.mp4", 1, "Jerry, Jerry, Quite Contrary", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/144%20%20%20Jerry%2C%20Jerry%2C%20Quite%20Contrary%20%5B1966%5D_000001.jpg" },
                    { 145, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/145%20%20%20Jerry%20Go%20Round%20%5B1966%5D.mp4", 1, "Jerry Go Round", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/145%20%20%20Jerry%20Go%20Round%20%5B1966%5D_000001.jpg" },
                    { 146, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/146%20%20%20Love%20Me%2C%20Love%20My%20Mouse%20%5B1966%5D.mp4", 1, "Love Me, Love My Mouse", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/146%20%20%20Love%20Me%2C%20Love%20My%20Mouse%20%5B1966%5D_000001.jpg" },
                    { 147, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/147%20%20%20Puss%20%27n%27%20Boats%20%5B1966%5D.mp4", 1, "Puss 'n' Boats", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/147%20%20%20Puss%20%27n%27%20Boats%20%5B1966%5D_000001.jpg" },
                    { 148, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/148%20%20%20Filet%20Meow%20%5B1966%5D.mp4", 1, "Filet Meow", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/148%20%20%20Filet%20Meow%20%5B1966%5D_000001.jpg" },
                    { 149, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/149%20%20%20Matinee%20Mouse%20%5B1966%5D.mp4", 1, "Matinee Mouse", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/149%20%20%20Matinee%20Mouse%20%5B1966%5D_000001.jpg" },
                    { 150, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/150%20%20%20The%20A%20Tom%20Inable%20Snowman%20%5B1966%5D.mp4", 1, "The A Tom Inable Snowman", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/150%20%20%20The%20A%20Tom%20Inable%20Snowman%20%5B1966%5D_000001.jpg" },
                    { 143, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/143%20%20%20Duel%20Personality%20%5B1966%5D.mp4", 1, "Duel Personality", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/143%20%20%20Duel%20Personality%20%5B1966%5D_000001.jpg" },
                    { 151, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/151%20%20%20Catty%20Cornered%20%5B1966%5D.mp4", 1, "Catty Cornered", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/151%20%20%20Catty%20Cornered%20%5B1966%5D_000001.jpg" },
                    { 153, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/153%20%20%20O%20Solar%20Meow%20%5B1966%5D.mp4", 1, "O Solar Meow", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/153%20%20%20O%20Solar%20Meow%20%5B1966%5D_000001.jpg" },
                    { 154, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/154%20%20%20Guided%20Mouse%20ille%20%5B1966%5D.mp4", 1, "Guided Mouse ille", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/154%20%20%20Guided%20Mouse%20ille%20%5B1966%5D_000001.jpg" },
                    { 155, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/155%20%20%20Rock%20%27n%27%20Rodent%20%5B1967%5D.mp4", 1, "Rock 'n' Rodent", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/155%20%20%20Rock%20%27n%27%20Rodent%20%5B1967%5D_000001.jpg" },
                    { 156, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/156%20%20%20Cannery%20Rodent%20%5B1967%5D.mp4", 1, "Cannery Rodent", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/156%20%20%20Cannery%20Rodent%20%5B1967%5D_000001.jpg" },
                    { 157, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/157%20%20%20The%20Mouse%20from%20H.U.N.G.E.R.%20%5B1967%5D.mp4", 1, "The Mouse from H.U.N.G.E.R.", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/157%20%20%20The%20Mouse%20from%20H.U.N.G.E.R.%20%5B1967%5D_000001.jpg" },
                    { 158, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/158%20%20%20Surf%20Bored%20Cat%20%5B1967%5D.mp4", 1, "Surf Bored Cat", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/158%20%20%20Surf%20Bored%20Cat%20%5B1967%5D_000001.jpg" },
                    { 159, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/159%20%20%20Shutter%20Bugged%20Cat%20%5B1967%5D.mp4", 1, "Shutter Bugged Cat", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/159%20%20%20Shutter%20Bugged%20Cat%20%5B1967%5D_000001.jpg" },
                    { 152, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/152%20%20%20Cat%20and%20Dupli%20cat%20%5B1966%5D.mp4", 1, "Cat and Dupli cat", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/152%20%20%20Cat%20and%20Dupli%20cat%20%5B1966%5D_000001.jpg" },
                    { 142, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/142%20%20%20The%20Cat%27s%20Me%20Ouch%20%5B1965%5D.mp4", 1, "The Cat's Me Ouch", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/142%20%20%20The%20Cat%27s%20Me%20Ouch%20%5B1965%5D_000001.jpg" },
                    { 141, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/141%20%20%20The%20Year%20of%20the%20Mouse%20%5B1965%5D.mp4", 1, "The Year of the Mouse", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/141%20%20%20The%20Year%20of%20the%20Mouse%20%5B1965%5D_000001.jpg" },
                    { 140, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/140%20%20%20Of%20Feline%20Bondage%20%5B1965%5D.mp4", 1, "Of Feline Bondage", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/140%20%20%20Of%20Feline%20Bondage%20%5B1965%5D_000001.jpg" },
                    { 123, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/123%20%20%20The%20Tom%20and%20Jerry%20Cartoon%20Kit%20%5B1962%5D.mp4", 1, "The Tom and Jerry Cartoon Kit", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/123%20%20%20The%20Tom%20and%20Jerry%20Cartoon%20Kit%20%5B1962%5D_000001.jpg" },
                    { 124, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/124%20%20%20Tall%20in%20the%20Trap%20%5B1962%5D.mp4", 1, "Tall in the Trap", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/124%20%20%20Tall%20in%20the%20Trap%20%5B1962%5D_000001.jpg" },
                    { 125, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/125%20%20%20Sorry%20Safari%20%5B1962%5D.mp4", 1, "Sorry Safari", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/125%20%20%20Sorry%20Safari%20%5B1962%5D_000001.jpg" },
                    { 126, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/126%20%20%20Buddies%20Thicker%20Than%20Water%20%5B1962%5D.mp4", 1, "Buddies Thicker Than Water", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/126%20%20%20Buddies%20Thicker%20Than%20Water%20%5B1962%5D_000001.jpg" },
                    { 127, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/127%20%20%20Carmen%20Get%20It%21%20%5B1962%5D.mp4", 1, "Carmen Get It!", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/127%20%20%20Carmen%20Get%20It%21%20%5B1962%5D_000001.jpg" },
                    { 128, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/128%20%20%20Pent%20House%20Mouse%20%5B1963%5D.mp4", 1, "Pent House Mouse", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/128%20%20%20Pent%20House%20Mouse%20%5B1963%5D_000001.jpg" },
                    { 129, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/129%20%20%20The%20Cat%20Above%20and%20the%20Mouse%20Below%20%5B1964%5D.mp4", 1, "The Cat Above and the Mouse Below", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/129%20%20%20The%20Cat%20Above%20and%20the%20Mouse%20Below%20%5B1964%5D_000001.jpg" },
                    { 130, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/130%20%20%20Is%20There%20a%20Doctor%20in%20the%20Mouse%20%5B1964%5D.mp4", 1, "Is There a Doctor in the Mouse", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/130%20%20%20Is%20There%20a%20Doctor%20in%20the%20Mouse%20%5B1964%5D_000001.jpg" },
                    { 131, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/131%20%20%20Much%20Ado%20About%20Mousing%20%5B1964%5D.mp4", 1, "Much Ado About Mousing", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/131%20%20%20Much%20Ado%20About%20Mousing%20%5B1964%5D_000001.jpg" },
                    { 132, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/132%20%20%20Snowbody%20Loves%20Me%20%5B1964%5D.mp4", 1, "Snowbody Loves Me", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/132%20%20%20Snowbody%20Loves%20Me%20%5B1964%5D_000001.jpg" },
                    { 133, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/133%20%20%20The%20Unshrinkable%20Jerry%20Mouse%20%5B1964%5D.mp4", 1, "The Unshrinkable Jerry Mouse", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/133%20%20%20The%20Unshrinkable%20Jerry%20Mouse%20%5B1964%5D_000001.jpg" },
                    { 134, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/134%20%20%20Ah%2C%20Sweet%20Mouse%20Story%20of%20Life%20%5B1965%5D.mp4", 1, "Ah, Sweet Mouse Story of Life", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/134%20%20%20Ah%2C%20Sweet%20Mouse%20Story%20of%20Life%20%5B1965%5D_000001.jpg" },
                    { 135, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/135%20%20%20Tom%20ic%20Energy%20%5B1965%5D.mp4", 1, "Tom ic Energy", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/135%20%20%20Tom%20ic%20Energy%20%5B1965%5D_000001.jpg" },
                    { 136, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/136%20%20%20Bad%20Day%20at%20Cat%20Rock%20%5B1965%5D.mp4", 1, "Bad Day at Cat Rock", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/136%20%20%20Bad%20Day%20at%20Cat%20Rock%20%5B1965%5D_000001.jpg" },
                    { 137, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/137%20%20%20The%20Brothers%20Carry%20Mouse%20Off%20%5B1965%5D.mp4", 1, "The Brothers Carry Mouse Off", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/137%20%20%20The%20Brothers%20Carry%20Mouse%20Off%20%5B1965%5D_000001.jpg" },
                    { 138, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/138%20%20%20Haunted%20Mouse%20%5B1965%5D.mp4", 1, "Haunted Mouse", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/138%20%20%20Haunted%20Mouse%20%5B1965%5D_000001.jpg" },
                    { 139, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/139%20%20%20I%27m%20Just%20Wild%20About%20Jerry%20%5B1965%5D.mp4", 1, "I'm Just Wild About Jerry", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/139%20%20%20I%27m%20Just%20Wild%20About%20Jerry%20%5B1965%5D_000001.jpg" },
                    { 82, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/082%20%20%20Hic%20cup%20Pup%20%5B1954%5D.mp4", 1, "Hic cup Pup", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/082%20%20%20Hic%20cup%20Pup%20%5B1954%5D_000001.jpg" },
                    { 160, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/160%20%20%20Advance%20and%20Be%20Mechanized%20%5B1967%5D.mp4", 1, "Advance and Be Mechanized", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/160%20%20%20Advance%20and%20Be%20Mechanized%20%5B1967%5D_000001.jpg" },
                    { 81, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/081%20%20%20Posse%20Cat%20%5B1954%5D.mp4", 1, "Posse Cat", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/081%20%20%20Posse%20Cat%20%5B1954%5D_000001.jpg" },
                    { 79, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/079%20%20%20Life%20with%20Tom%20%5B1953%5D.mp4", 1, "Life with Tom", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/079%20%20%20Life%20with%20Tom%20%5B1953%5D_000001.jpg" },
                    { 22, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/022%20%20%20Quiet%20Please%21%20%5B1945%5D.mp4", 1, "Quiet Please!", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/022%20%20%20Quiet%20Please%21%20%5B1945%5D_000001.jpg" },
                    { 23, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/023%20%20%20Springtime%20for%20Thomas%20%5B1946%5D.mp4", 1, "Springtime for Thomas", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/023%20%20%20Springtime%20for%20Thomas%20%5B1946%5D_000001.jpg" },
                    { 24, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/024%20%20%20The%20Milky%20Waif%20%5B1946%5D.mp4", 1, "The Milky Waif", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/024%20%20%20The%20Milky%20Waif%20%5B1946%5D_000001.jpg" },
                    { 25, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/025%20%20%20Trap%20Happy%20%5B1946%5D.mp4", 1, "Trap Happy", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/025%20%20%20Trap%20Happy%20%5B1946%5D_000001.jpg" },
                    { 26, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/026%20%20%20Solid%20Serenade%20%5B1946%5D.mp4", 1, "Solid Serenade", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/026%20%20%20Solid%20Serenade%20%5B1946%5D_000001.jpg" },
                    { 27, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/027%20%20%20Cat%20Fishin%27%20%5B1947%5D.mp4", 1, "Cat Fishin'", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/027%20%20%20Cat%20Fishin%27%20%5B1947%5D_000001.jpg" },
                    { 28, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/028%20%20%20Part%20Time%20Pal%20%5B1947%5D.mp4", 1, "Part Time Pal", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/028%20%20%20Part%20Time%20Pal%20%5B1947%5D_000001.jpg" },
                    { 21, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/021%20%20%20Flirty%20Birdy%20%5B1945%5D.mp4", 1, "Flirty Birdy", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/021%20%20%20Flirty%20Birdy%20%5B1945%5D_000001.jpg" },
                    { 29, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/029%20%20%20The%20Cat%20Concerto%20%5B1947%5D.mp4", 1, "The Cat Concerto", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/029%20%20%20The%20Cat%20Concerto%20%5B1947%5D_000001.jpg" },
                    { 31, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/031%20%20%20Salt%20Water%20Tabby%20%5B1947%5D.mp4", 1, "Salt Water Tabby", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/031%20%20%20Salt%20Water%20Tabby%20%5B1947%5D_000001.jpg" },
                    { 32, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/032%20%20%20A%20Mouse%20in%20the%20House%20%5B1947%5D.mp4", 1, "A Mouse in the House", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/032%20%20%20A%20Mouse%20in%20the%20House%20%5B1947%5D_000001.jpg" },
                    { 33, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/033%20%20%20The%20Invisible%20Mouse%20%5B1947%5D.mp4", 1, "The Invisible Mouse", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/033%20%20%20The%20Invisible%20Mouse%20%5B1947%5D_000001.jpg" },
                    { 34, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/034%20%20%20Kitty%20Foiled%20%5B1948%5D.mp4", 1, "Kitty Foiled", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/034%20%20%20Kitty%20Foiled%20%5B1948%5D_000001.jpg" },
                    { 35, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/035%20%20%20The%20Truce%20Hurts%20%5B1948%5D.mp4", 1, "The Truce Hurts", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/035%20%20%20The%20Truce%20Hurts%20%5B1948%5D_000001.jpg" },
                    { 36, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/036%20%20%20Old%20Rockin%27%20Chair%20Tom%20%5B1948%5D.mp4", 1, "Old Rockin' Chair Tom", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/036%20%20%20Old%20Rockin%27%20Chair%20Tom%20%5B1948%5D_000001.jpg" },
                    { 37, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/037%20%20%20Professor%20Tom%20%5B1948%5D.mp4", 1, "Professor Tom", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/037%20%20%20Professor%20Tom%20%5B1948%5D_000001.jpg" },
                    { 30, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/030%20%20%20Dr.%20Jekyll%20and%20Mr.%20Mouse%20%5B1947%5D.mp4", 1, "Dr. Jekyll and Mr. Mouse", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/030%20%20%20Dr.%20Jekyll%20and%20Mr.%20Mouse%20%5B1947%5D_000001.jpg" },
                    { 38, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/038%20%20%20Mouse%20Cleaning%20%5B1948%5D.mp4", 1, "Mouse Cleaning", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/038%20%20%20Mouse%20Cleaning%20%5B1948%5D_000001.jpg" },
                    { 20, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/020%20%20%20Tee%20for%20Two%20%5B1945%5D.mp4", 1, "Tee for Two", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/020%20%20%20Tee%20for%20Two%20%5B1945%5D_000001.jpg" },
                    { 18, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/018%20%20%20The%20Mouse%20Comes%20to%20Dinner%20%5B1945%5D.mp4", 1, "The Mouse Comes to Dinner", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/018%20%20%20The%20Mouse%20Comes%20to%20Dinner%20%5B1945%5D_000001.jpg" },
                    { 2, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/002%20%20%20The%20Midnight%20Snack%20%5B1941%5D.mp4", 1, "The Midnight Snack", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/002%20%20%20The%20Midnight%20Snack%20%5B1941%5D_000001.jpg" },
                    { 3, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/003%20%20%20The%20Night%20Before%20Christmas%20%5B1941%5D.mp4", 1, "The Night Before Christmas", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/003%20%20%20The%20Night%20Before%20Christmas%20%5B1941%5D_000001.jpg" },
                    { 4, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/004%20%20%20Fraidy%20Cat%20%5B1942%5D.mp4", 1, "Fraidy Cat", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/004%20%20%20Fraidy%20Cat%20%5B1942%5D_000001.jpg" },
                    { 5, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/005%20%20%20Dog%20Trouble%20%5B1942%5D.mp4", 1, "Dog Trouble", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/005%20%20%20Dog%20Trouble%20%5B1942%5D_000001.jpg" },
                    { 6, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/006%20%20%20Puss%20n%27%20Toots%20%5B1942%5D.mp4", 1, "Puss n' Toots", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/006%20%20%20Puss%20n%27%20Toots%20%5B1942%5D_000001.jpg" },
                    { 7, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/007%20%20%20The%20Bowling%20Alley%20Cat%20%5B1942%5D.mp4", 1, "The Bowling Alley Cat", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/007%20%20%20The%20Bowling%20Alley%20Cat%20%5B1942%5D_000001.jpg" },
                    { 8, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/008%20%20%20Fine%20Feathered%20Friend%20%5B1942%5D.mp4", 1, "Fine Feathered Friend", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/008%20%20%20Fine%20Feathered%20Friend%20%5B1942%5D_000001.jpg" },
                    { 19, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/019%20%20%20Mouse%20in%20Manhattan%20%5B1945%5D.mp4", 1, "Mouse in Manhattan", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/019%20%20%20Mouse%20in%20Manhattan%20%5B1945%5D_000001.jpg" },
                    { 9, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/009%20%20%20Sufferin%27%20Cats%21%20%5B1943%5D.mp4", 1, "Sufferin' Cats!", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/009%20%20%20Sufferin%27%20Cats%21%20%5B1943%5D_000001.jpg" },
                    { 11, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/011%20%20%20The%20Yankee%20Doodle%20Mouse%20%5B1943%5D.mp4", 1, "The Yankee Doodle Mouse", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/011%20%20%20The%20Yankee%20Doodle%20Mouse%20%5B1943%5D_000001.jpg" },
                    { 12, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/012%20%20%20Baby%20Puss%20%5B1943%5D.mp4", 1, "Baby Puss", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/012%20%20%20Baby%20Puss%20%5B1943%5D_000001.jpg" },
                    { 13, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/013%20%20%20The%20Zoot%20Cat%20%5B1944%5D.mp4", 1, "The Zoot Cat", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/013%20%20%20The%20Zoot%20Cat%20%5B1944%5D_000001.jpg" },
                    { 14, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/014%20%20%20The%20Million%20Dollar%20Cat%20%5B1944%5D.mp4", 1, "The Million Dollar Cat", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/014%20%20%20The%20Million%20Dollar%20Cat%20%5B1944%5D_000001.jpg" },
                    { 15, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/015%20%20%20The%20Bodyguard%20%5B1944%5D.mp4", 1, "The Bodyguard", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/015%20%20%20The%20Bodyguard%20%5B1944%5D_000001.jpg" },
                    { 16, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/016%20%20%20Puttin%27%20on%20the%20Dog%20%5B1944%5D.mp4", 1, "Puttin' on the Dog", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/016%20%20%20Puttin%27%20on%20the%20Dog%20%5B1944%5D_000001.jpg" },
                    { 17, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/017%20%20%20Mouse%20Trouble%20%5B1944%5D.mp4", 1, "Mouse Trouble", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/017%20%20%20Mouse%20Trouble%20%5B1944%5D_000001.jpg" },
                    { 10, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/010%20%20%20The%20Lonesome%20Mouse%20%5B1943%5D.mp4", 1, "The Lonesome Mouse", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/010%20%20%20The%20Lonesome%20Mouse%20%5B1943%5D_000001.jpg" },
                    { 39, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/039%20%20%20Polka%20Dot%20Puss%20%5B1949%5D.mp4", 1, "Polka Dot Puss", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/039%20%20%20Polka%20Dot%20Puss%20%5B1949%5D_000001.jpg" },
                    { 40, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/040%20%20%20The%20Little%20Orphan%20%5B1949%5D.mp4", 1, "The Little Orphan", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/040%20%20%20The%20Little%20Orphan%20%5B1949%5D_000001.jpg" },
                    { 41, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/041%20%20%20Hatch%20Up%20Your%20Troubles%20%5B1949%5D.mp4", 1, "Hatch Up Your Troubles", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/041%20%20%20Hatch%20Up%20Your%20Troubles%20%5B1949%5D_000001.jpg" },
                    { 63, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/063%20%20%20The%20Flying%20Cat%20%5B1952%5D.mp4", 1, "The Flying Cat", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/063%20%20%20The%20Flying%20Cat%20%5B1952%5D_000001.jpg" },
                    { 64, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/064%20%20%20The%20Duck%20Doctor%20%5B1952%5D.mp4", 1, "The Duck Doctor", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/064%20%20%20The%20Duck%20Doctor%20%5B1952%5D_000001.jpg" },
                    { 65, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/065%20%20%20The%20Two%20Mouseketeers%20%5B1952%5D.mp4", 1, "The Two Mouseketeers", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/065%20%20%20The%20Two%20Mouseketeers%20%5B1952%5D_000001.jpg" },
                    { 66, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/066%20%20%20Smitten%20Kitten%20%5B1952%5D.mp4", 1, "Smitten Kitten", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/066%20%20%20Smitten%20Kitten%20%5B1952%5D_000001.jpg" },
                    { 67, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/067%20%20%20Triplet%20Trouble%20%5B1952%5D.mp4", 1, "Triplet Trouble", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/067%20%20%20Triplet%20Trouble%20%5B1952%5D_000001.jpg" },
                    { 68, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/068%20%20%20Little%20Runaway%20%5B1952%5D.mp4", 1, "Little Runaway", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/068%20%20%20Little%20Runaway%20%5B1952%5D_000001.jpg" },
                    { 69, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/069%20%20%20Fit%20to%20be%20Tied%20%5B1952%5D.mp4", 1, "Fit to be Tied", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/069%20%20%20Fit%20to%20be%20Tied%20%5B1952%5D_000001.jpg" },
                    { 62, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/062%20%20%20Cat%20Napping%20%5B1951%5D.mp4", 1, "Cat Napping", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/062%20%20%20Cat%20Napping%20%5B1951%5D_000001.jpg" },
                    { 70, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/070%20%20%20Push%20Button%20Kitty%20%5B1952%5D.mp4", 1, "Push Button Kitty", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/070%20%20%20Push%20Button%20Kitty%20%5B1952%5D_000001.jpg" },
                    { 72, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/072%20%20%20The%20Dog%20House%20%5B1952%5D.mp4", 1, "The Dog House", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/072%20%20%20The%20Dog%20House%20%5B1952%5D_000001.jpg" },
                    { 73, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/073%20%20%20The%20Missing%20Mouse%20%5B1953%5D.mp4", 1, "The Missing Mouse", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/073%20%20%20The%20Missing%20Mouse%20%5B1953%5D_000001.jpg" },
                    { 74, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/074%20%20%20Jerry%20and%20Jumbo%20%5B1953%5D.mp4", 1, "Jerry and Jumbo", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/074%20%20%20Jerry%20and%20Jumbo%20%5B1953%5D_000001.jpg" },
                    { 75, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/075%20%20%20Johann%20Mouse%20%5B1953%5D.mp4", 1, "Johann Mouse", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/075%20%20%20Johann%20Mouse%20%5B1953%5D_000001.jpg" },
                    { 76, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/076%20%20%20That%27s%20My%20Pup%21%20%5B1953%5D.mp4", 1, "That's My Pup!", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/076%20%20%20That%27s%20My%20Pup%21%20%5B1953%5D_000001.jpg" },
                    { 77, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/077%20%20%20Just%20Ducky%20%5B1953%5D.mp4", 1, "Just Ducky", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/077%20%20%20Just%20Ducky%20%5B1953%5D_000001.jpg" },
                    { 78, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/078%20%20%20Two%20Little%20Indians%20%5B1953%5D.mp4", 1, "Two Little Indians", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/078%20%20%20Two%20Little%20Indians%20%5B1953%5D_000001.jpg" },
                    { 71, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/071%20%20%20Cruise%20Cat%20%5B1952%5D.mp4", 1, "Cruise Cat", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/071%20%20%20Cruise%20Cat%20%5B1952%5D_000001.jpg" },
                    { 61, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/061%20%20%20Nit%20Witty%20Kitty%20%5B1951%5D.mp4", 1, "Nit Witty Kitty", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/061%20%20%20Nit%20Witty%20Kitty%20%5B1951%5D_000001.jpg" },
                    { 60, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/060%20%20%20Slicked%20up%20Pup%20%5B1951%5D.mp4", 1, "Slicked up Pup", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/060%20%20%20Slicked%20up%20Pup%20%5B1951%5D_000001.jpg" },
                    { 59, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/059%20%20%20His%20Mouse%20Friday%20%5B1951%5D.mp4", 1, "His Mouse Friday", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/059%20%20%20His%20Mouse%20Friday%20%5B1951%5D_000001.jpg" },
                    { 42, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/042%20%20%20Heavenly%20Puss%20%5B1949%5D.mp4", 1, "Heavenly Puss", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/042%20%20%20Heavenly%20Puss%20%5B1949%5D_000001.jpg" },
                    { 43, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/043%20%20%20The%20Cat%20and%20the%20Mermouse%20%5B1949%5D.mp4", 1, "The Cat and the Mermouse", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/043%20%20%20The%20Cat%20and%20the%20Mermouse%20%5B1949%5D_000001.jpg" },
                    { 44, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/044%20%20%20Love%20That%20Pup%20%5B1949%5D.mp4", 1, "Love That Pup", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/044%20%20%20Love%20That%20Pup%20%5B1949%5D_000001.jpg" },
                    { 45, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/045%20%20%20Jerry%27s%20Diary%20%5B1949%5D.mp4", 1, "Jerry's Diary", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/045%20%20%20Jerry%27s%20Diary%20%5B1949%5D_000001.jpg" },
                    { 46, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/046%20%20%20Tennis%20Chumps%20%5B1949%5D.mp4", 1, "Tennis Chumps", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/046%20%20%20Tennis%20Chumps%20%5B1949%5D_000001.jpg" },
                    { 47, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/047%20%20%20Little%20Quacker%20%5B1950%5D.mp4", 1, "Little Quacker", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/047%20%20%20Little%20Quacker%20%5B1950%5D_000001.jpg" },
                    { 48, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/048%20%20%20Saturday%20Evening%20Puss%20%5B1950%5D.mp4", 1, "Saturday Evening Puss", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/048%20%20%20Saturday%20Evening%20Puss%20%5B1950%5D_000001.jpg" },
                    { 49, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/049%20%20%20Texas%20Tom%20%5B1950%5D.mp4", 1, "Texas Tom", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/049%20%20%20Texas%20Tom%20%5B1950%5D_000001.jpg" },
                    { 50, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/050%20%20%20Jerry%20and%20the%20Lion%20%5B1950%5D.mp4", 1, "Jerry and the Lion", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/050%20%20%20Jerry%20and%20the%20Lion%20%5B1950%5D_000001.jpg" },
                    { 51, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/051%20%20%20Safety%20Second%20%5B1950%5D.mp4", 1, "Safety Second", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/051%20%20%20Safety%20Second%20%5B1950%5D_000001.jpg" },
                    { 52, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/052%20%20%20The%20Hollywood%20Bowl%20%5B1950%5D.mp4", 1, "The Hollywood Bowl", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/052%20%20%20The%20Hollywood%20Bowl%20%5B1950%5D_000001.jpg" },
                    { 53, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/053%20%20%20The%20Framed%20Cat%20%5B1950%5D.mp4", 1, "The Framed Cat", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/053%20%20%20The%20Framed%20Cat%20%5B1950%5D_000001.jpg" },
                    { 54, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/054%20%20%20Cue%20Ball%20Cat%20%5B1950%5D.mp4", 1, "Cue Ball Cat", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/054%20%20%20Cue%20Ball%20Cat%20%5B1950%5D_000001.jpg" },
                    { 55, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/055%20%20%20Casanova%20Cat%20%5B1951%5D.mp4", 1, "Casanova Cat", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/055%20%20%20Casanova%20Cat%20%5B1951%5D_000001.jpg" },
                    { 56, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/056%20%20%20Jerry%20and%20the%20Goldfish%20%5B1951%5D.mp4", 1, "Jerry and the Goldfish", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/056%20%20%20Jerry%20and%20the%20Goldfish%20%5B1951%5D_000001.jpg" },
                    { 57, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/057%20%20%20Jerry%27s%20Cousin%20%5B1951%5D.mp4", 1, "Jerry's Cousin", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/057%20%20%20Jerry%27s%20Cousin%20%5B1951%5D_000001.jpg" },
                    { 58, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/058%20%20%20Sleepy%20Time%20Tom%20%5B1951%5D.mp4", 1, "Sleepy Time Tom", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/058%20%20%20Sleepy%20Time%20Tom%20%5B1951%5D_000001.jpg" },
                    { 80, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/080%20%20%20Puppy%20Tale%20%5B1954%5D.mp4", 1, "Puppy Tale", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/080%20%20%20Puppy%20Tale%20%5B1954%5D_000001.jpg" },
                    { 161, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/161%20%20%20Purr%20Chance%20to%20Dream%20%5B1967%5D.mp4", 1, "Purr Chance to Dream", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/161%20%20%20Purr%20Chance%20to%20Dream%20%5B1967%5D_000001.jpg" }
                });

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
