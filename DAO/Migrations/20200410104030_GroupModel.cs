using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAO.Migrations
{
    public partial class GroupModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_User_ReceivedUserId",
                table: "Posts");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_User_SentUserId",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Posts_ReceivedUserId",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Posts_SentUserId",
                table: "Posts");

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 9, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 10, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 11, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 12, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 13, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 14, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 15, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 16, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 17, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 18, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 19, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 20, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 21, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 22, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 23, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 24, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 25, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 26, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 27, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 28, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 29, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 30, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 31, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 32, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 33, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 34, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 35, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 36, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 37, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 38, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 39, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 40, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 41, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 42, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 43, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 44, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 45, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 46, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 47, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 48, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 49, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 50, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 51, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 52, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 53, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 54, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 55, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 56, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 57, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 58, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 59, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 60, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 61, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 62, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 63, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 64, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 65, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 66, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 67, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 68, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 69, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 70, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 71, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 72, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 73, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 74, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 75, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 76, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 77, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 78, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 79, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 80, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 81, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 82, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 83, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 84, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 85, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 86, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 87, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 88, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 89, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 90, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 91, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 92, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 93, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 94, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 95, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 96, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 97, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 98, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 99, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 100, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 101, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 102, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 103, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 104, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 105, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 106, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 107, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 108, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 109, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 110, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 111, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 112, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 113, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 114, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 115, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 116, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 117, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 118, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 119, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 120, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 121, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 122, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 123, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 124, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 125, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 126, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 127, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 128, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 129, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 130, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 131, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 132, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 133, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 134, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 135, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 136, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 137, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 138, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 139, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 140, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 141, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 142, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 143, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 144, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 145, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 146, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 147, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 148, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 149, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 150, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 151, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 152, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 153, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 154, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 155, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 156, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 157, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 158, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 159, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 160, 1 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 161, 1 });

            migrationBuilder.DropColumn(
                name: "ReceivedUserId",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "SentUserId",
                table: "Posts");

            migrationBuilder.AddColumn<int>(
                name: "CreatorId",
                table: "Posts",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GroupId",
                table: "Posts",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GroupId1",
                table: "Posts",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Posts",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FilmId = table.Column<int>(nullable: true),
                    CreatorId = table.Column<int>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Groups_User_CreatorId",
                        column: x => x.CreatorId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Groups_Film_FilmId",
                        column: x => x.FilmId,
                        principalTable: "Film",
                        principalColumn: "FilmId",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "GroupMembers",
                columns: table => new
                {
                    GroupId = table.Column<int>(nullable: false),
                    MemberId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupMembers", x => new { x.GroupId, x.MemberId });
                    table.ForeignKey(
                        name: "FK_GroupMembers_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GroupMembers_User_MemberId",
                        column: x => x.MemberId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 1,
                column: "Password",
                value: "AGx7hblJX0Pfec8h5z9uRelro39oY67Oq2rBF8Y+2HTSy9oESE7Ds8/627CToj7dQg==");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_CreatorId",
                table: "Posts",
                column: "CreatorId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_GroupId",
                table: "Posts",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_GroupId1",
                table: "Posts",
                column: "GroupId1");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_UserId",
                table: "Posts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupMembers_MemberId",
                table: "GroupMembers",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_Groups_CreatorId",
                table: "Groups",
                column: "CreatorId");

            migrationBuilder.CreateIndex(
                name: "IX_Groups_FilmId",
                table: "Groups",
                column: "FilmId");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_User_CreatorId",
                table: "Posts",
                column: "CreatorId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Groups_GroupId",
                table: "Posts",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Groups_GroupId1",
                table: "Posts",
                column: "GroupId1",
                principalTable: "Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_User_UserId",
                table: "Posts",
                column: "UserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_User_CreatorId",
                table: "Posts");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Groups_GroupId",
                table: "Posts");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Groups_GroupId1",
                table: "Posts");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_User_UserId",
                table: "Posts");

            migrationBuilder.DropTable(
                name: "GroupMembers");

            migrationBuilder.DropTable(
                name: "Groups");

            migrationBuilder.DropIndex(
                name: "IX_Posts_CreatorId",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Posts_GroupId",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Posts_GroupId1",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Posts_UserId",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "CreatorId",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "GroupId",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "GroupId1",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Posts");

            migrationBuilder.AddColumn<int>(
                name: "ReceivedUserId",
                table: "Posts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SentUserId",
                table: "Posts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "FilmData",
                columns: new[] { "Id", "FilmId", "Address", "Name", "RunTime", "ThumbnailAddress" },
                values: new object[,]
                {
                    { 9, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/009%20%20%20Sufferin%27%20Cats%21%20%5B1943%5D.mp4", "Sufferin' Cats!", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/009%20%20%20Sufferin%27%20Cats%21%20%5B1943%5D_000001.jpg" },
                    { 107, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/107%20%20%20Feedin%27%20the%20Kiddie%20%5B1957%5D.mp4", "Feedin' the Kiddie", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/107%20%20%20Feedin%27%20the%20Kiddie%20%5B1957%5D_000001.jpg" },
                    { 108, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/108%20%20%20Mucho%20Mouse%20%5B1957%5D.mp4", "Mucho Mouse", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/108%20%20%20Mucho%20Mouse%20%5B1957%5D_000001.jpg" },
                    { 109, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/109%20%20%20Tom%27s%20Photo%20Finish%20%5B1957%5D.mp4", "Tom's Photo Finish", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/109%20%20%20Tom%27s%20Photo%20Finish%20%5B1957%5D_000001.jpg" },
                    { 110, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/110%20%20%20Happy%20Go%20Ducky%20%5B1958%5D.mp4", "Happy Go Ducky", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/110%20%20%20Happy%20Go%20Ducky%20%5B1958%5D_000001.jpg" },
                    { 111, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/111%20%20%20Royal%20Cat%20Nap%20%5B1958%5D.mp4", "Royal Cat Nap", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/111%20%20%20Royal%20Cat%20Nap%20%5B1958%5D_000001.jpg" },
                    { 112, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/112%20%20%20The%20Vanishing%20Duck%20%5B1958%5D.mp4", "The Vanishing Duck", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/112%20%20%20The%20Vanishing%20Duck%20%5B1958%5D_000001.jpg" },
                    { 113, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/113%20%20%20Robin%20Hoodwinked%20%5B1958%5D.mp4", "Robin Hoodwinked", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/113%20%20%20Robin%20Hoodwinked%20%5B1958%5D_000001.jpg" },
                    { 114, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/114%20%20%20Tot%20Watchers%20%5B1958%5D.mp4", "Tot Watchers", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/114%20%20%20Tot%20Watchers%20%5B1958%5D_000001.jpg" },
                    { 115, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/115%20%20%20Switchin%27%20Kitten%20%5B1961%5D.mp4", "Switchin' Kitten", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/115%20%20%20Switchin%27%20Kitten%20%5B1961%5D_000001.jpg" },
                    { 116, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/116%20%20%20Down%20and%20Outing%20%5B1961%5D.mp4", "Down and Outing", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/116%20%20%20Down%20and%20Outing%20%5B1961%5D_000001.jpg" },
                    { 117, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/117%20%20%20It%27s%20Greek%20to%20Me%20ow%20%5B1961%5D.mp4", "It's Greek to Me ow", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/117%20%20%20It%27s%20Greek%20to%20Me%20ow%20%5B1961%5D_000001.jpg" },
                    { 118, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/118%20%20%20High%20Steaks%20%5B1962%5D.mp4", "High Steaks", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/118%20%20%20High%20Steaks%20%5B1962%5D_000001.jpg" },
                    { 119, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/119%20%20%20Mouse%20Into%20Space%20%5B1962%5D.mp4", "Mouse Into Space", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/119%20%20%20Mouse%20Into%20Space%20%5B1962%5D_000001.jpg" },
                    { 120, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/120%20%20%20Landing%20Stripling%20%5B1962%5D.mp4", "Landing Stripling", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/120%20%20%20Landing%20Stripling%20%5B1962%5D_000001.jpg" },
                    { 121, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/121%20%20%20Calypso%20Cat%20%5B1962%5D.mp4", "Calypso Cat", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/121%20%20%20Calypso%20Cat%20%5B1962%5D_000001.jpg" },
                    { 106, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/106%20%20%20Timid%20Tabby%20%5B1957%5D.mp4", "Timid Tabby", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/106%20%20%20Timid%20Tabby%20%5B1957%5D_000001.jpg" },
                    { 122, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/122%20%20%20Dicky%20Moe%20%5B1962%5D.mp4", "Dicky Moe", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/122%20%20%20Dicky%20Moe%20%5B1962%5D_000001.jpg" },
                    { 105, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/105%20%20%20Tops%20with%20Pops%20%5B1957%5D.mp4", "Tops with Pops", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/105%20%20%20Tops%20with%20Pops%20%5B1957%5D_000001.jpg" },
                    { 103, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/103%20%20%20Blue%20Cat%20Blues%20%5B1956%5D.mp4", "Blue Cat Blues", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/103%20%20%20Blue%20Cat%20Blues%20%5B1956%5D_000001.jpg" },
                    { 88, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/088%20%20%20Pet%20Peeve%20%5B1954%5D.mp4", "Pet Peeve", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/088%20%20%20Pet%20Peeve%20%5B1954%5D_000001.jpg" },
                    { 89, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/089%20%20%20Touch%C3%A9%2C%20Pussy%20Cat%21%20%5B1954%5D.mp4", "Touché, Pussy Cat!", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/089%20%20%20Touch%C3%A9%2C%20Pussy%20Cat%21%20%5B1954%5D_000001.jpg" },
                    { 90, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/090%20%20%20Southbound%20Duckling%20%5B1955%5D.mp4", "Southbound Duckling", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/090%20%20%20Southbound%20Duckling%20%5B1955%5D_000001.jpg" },
                    { 91, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/091%20%20%20Pup%20on%20a%20Picnic%20%5B1955%5D.mp4", "Pup on a Picnic", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/091%20%20%20Pup%20on%20a%20Picnic%20%5B1955%5D_000001.jpg" },
                    { 92, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/092%20%20%20Mouse%20for%20Sale%20%5B1955%5D.mp4", "Mouse for Sale", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/092%20%20%20Mouse%20for%20Sale%20%5B1955%5D_000001.jpg" },
                    { 93, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/093%20%20%20Designs%20on%20Jerry%20%5B1955%5D.mp4", "Designs on Jerry", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/093%20%20%20Designs%20on%20Jerry%20%5B1955%5D_000001.jpg" },
                    { 94, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/094%20%20%20Tom%20and%20Ch%C3%A9rie%20%5B1955%5D.mp4", "Tom and Chérie", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/094%20%20%20Tom%20and%20Ch%C3%A9rie%20%5B1955%5D_000001.jpg" },
                    { 95, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/095%20%20%20Smarty%20Cat%20%5B1955%5D.mp4", "Smarty Cat", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/095%20%20%20Smarty%20Cat%20%5B1955%5D_000001.jpg" },
                    { 96, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/096%20%20%20Pecos%20Pest%20%5B1955%5D.mp4", "Pecos Pest", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/096%20%20%20Pecos%20Pest%20%5B1955%5D_000001.jpg" },
                    { 97, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/097%20%20%20That%27s%20My%20Mommy%20%5B1955%5D.mp4", "That's My Mommy", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/097%20%20%20That%27s%20My%20Mommy%20%5B1955%5D_000001.jpg" },
                    { 98, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/098%20%20%20The%20Flying%20Sorceress%20%5B1956%5D.mp4", "The Flying Sorceress", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/098%20%20%20The%20Flying%20Sorceress%20%5B1956%5D_000001.jpg" },
                    { 99, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/099%20%20%20The%20Egg%20and%20Jerry%20%5B1956%5D.mp4", "The Egg and Jerry", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/099%20%20%20The%20Egg%20and%20Jerry%20%5B1956%5D_000001.jpg" },
                    { 100, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/100%20%20%20Busy%20Buddies%20%5B1956%5D.mp4", "Busy Buddies", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/100%20%20%20Busy%20Buddies%20%5B1956%5D_000001.jpg" },
                    { 101, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/101%20%20%20Muscle%20Beach%20Tom%20%5B1956%5D.mp4", "Muscle Beach Tom", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/101%20%20%20Muscle%20Beach%20Tom%20%5B1956%5D_000001.jpg" },
                    { 102, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/102%20%20%20Down%20Beat%20Bear%20%5B1956%5D.mp4", "Down Beat Bear", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/102%20%20%20Down%20Beat%20Bear%20%5B1956%5D_000001.jpg" },
                    { 104, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/104%20%20%20Barbecue%20Brawl%20%5B1956%5D.mp4", "Barbecue Brawl", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/104%20%20%20Barbecue%20Brawl%20%5B1956%5D_000001.jpg" },
                    { 123, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/123%20%20%20The%20Tom%20and%20Jerry%20Cartoon%20Kit%20%5B1962%5D.mp4", "The Tom and Jerry Cartoon Kit", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/123%20%20%20The%20Tom%20and%20Jerry%20Cartoon%20Kit%20%5B1962%5D_000001.jpg" },
                    { 124, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/124%20%20%20Tall%20in%20the%20Trap%20%5B1962%5D.mp4", "Tall in the Trap", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/124%20%20%20Tall%20in%20the%20Trap%20%5B1962%5D_000001.jpg" },
                    { 125, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/125%20%20%20Sorry%20Safari%20%5B1962%5D.mp4", "Sorry Safari", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/125%20%20%20Sorry%20Safari%20%5B1962%5D_000001.jpg" },
                    { 146, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/146%20%20%20Love%20Me%2C%20Love%20My%20Mouse%20%5B1966%5D.mp4", "Love Me, Love My Mouse", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/146%20%20%20Love%20Me%2C%20Love%20My%20Mouse%20%5B1966%5D_000001.jpg" },
                    { 147, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/147%20%20%20Puss%20%27n%27%20Boats%20%5B1966%5D.mp4", "Puss 'n' Boats", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/147%20%20%20Puss%20%27n%27%20Boats%20%5B1966%5D_000001.jpg" },
                    { 148, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/148%20%20%20Filet%20Meow%20%5B1966%5D.mp4", "Filet Meow", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/148%20%20%20Filet%20Meow%20%5B1966%5D_000001.jpg" },
                    { 149, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/149%20%20%20Matinee%20Mouse%20%5B1966%5D.mp4", "Matinee Mouse", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/149%20%20%20Matinee%20Mouse%20%5B1966%5D_000001.jpg" },
                    { 150, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/150%20%20%20The%20A%20Tom%20Inable%20Snowman%20%5B1966%5D.mp4", "The A Tom Inable Snowman", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/150%20%20%20The%20A%20Tom%20Inable%20Snowman%20%5B1966%5D_000001.jpg" },
                    { 151, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/151%20%20%20Catty%20Cornered%20%5B1966%5D.mp4", "Catty Cornered", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/151%20%20%20Catty%20Cornered%20%5B1966%5D_000001.jpg" },
                    { 152, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/152%20%20%20Cat%20and%20Dupli%20cat%20%5B1966%5D.mp4", "Cat and Dupli cat", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/152%20%20%20Cat%20and%20Dupli%20cat%20%5B1966%5D_000001.jpg" },
                    { 153, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/153%20%20%20O%20Solar%20Meow%20%5B1966%5D.mp4", "O Solar Meow", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/153%20%20%20O%20Solar%20Meow%20%5B1966%5D_000001.jpg" },
                    { 154, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/154%20%20%20Guided%20Mouse%20ille%20%5B1966%5D.mp4", "Guided Mouse ille", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/154%20%20%20Guided%20Mouse%20ille%20%5B1966%5D_000001.jpg" },
                    { 155, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/155%20%20%20Rock%20%27n%27%20Rodent%20%5B1967%5D.mp4", "Rock 'n' Rodent", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/155%20%20%20Rock%20%27n%27%20Rodent%20%5B1967%5D_000001.jpg" },
                    { 156, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/156%20%20%20Cannery%20Rodent%20%5B1967%5D.mp4", "Cannery Rodent", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/156%20%20%20Cannery%20Rodent%20%5B1967%5D_000001.jpg" },
                    { 157, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/157%20%20%20The%20Mouse%20from%20H.U.N.G.E.R.%20%5B1967%5D.mp4", "The Mouse from H.U.N.G.E.R.", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/157%20%20%20The%20Mouse%20from%20H.U.N.G.E.R.%20%5B1967%5D_000001.jpg" },
                    { 158, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/158%20%20%20Surf%20Bored%20Cat%20%5B1967%5D.mp4", "Surf Bored Cat", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/158%20%20%20Surf%20Bored%20Cat%20%5B1967%5D_000001.jpg" },
                    { 159, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/159%20%20%20Shutter%20Bugged%20Cat%20%5B1967%5D.mp4", "Shutter Bugged Cat", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/159%20%20%20Shutter%20Bugged%20Cat%20%5B1967%5D_000001.jpg" },
                    { 160, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/160%20%20%20Advance%20and%20Be%20Mechanized%20%5B1967%5D.mp4", "Advance and Be Mechanized", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/160%20%20%20Advance%20and%20Be%20Mechanized%20%5B1967%5D_000001.jpg" },
                    { 145, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/145%20%20%20Jerry%20Go%20Round%20%5B1966%5D.mp4", "Jerry Go Round", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/145%20%20%20Jerry%20Go%20Round%20%5B1966%5D_000001.jpg" },
                    { 144, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/144%20%20%20Jerry%2C%20Jerry%2C%20Quite%20Contrary%20%5B1966%5D.mp4", "Jerry, Jerry, Quite Contrary", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/144%20%20%20Jerry%2C%20Jerry%2C%20Quite%20Contrary%20%5B1966%5D_000001.jpg" },
                    { 143, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/143%20%20%20Duel%20Personality%20%5B1966%5D.mp4", "Duel Personality", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/143%20%20%20Duel%20Personality%20%5B1966%5D_000001.jpg" },
                    { 142, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/142%20%20%20The%20Cat%27s%20Me%20Ouch%20%5B1965%5D.mp4", "The Cat's Me Ouch", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/142%20%20%20The%20Cat%27s%20Me%20Ouch%20%5B1965%5D_000001.jpg" },
                    { 126, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/126%20%20%20Buddies%20Thicker%20Than%20Water%20%5B1962%5D.mp4", "Buddies Thicker Than Water", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/126%20%20%20Buddies%20Thicker%20Than%20Water%20%5B1962%5D_000001.jpg" },
                    { 127, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/127%20%20%20Carmen%20Get%20It%21%20%5B1962%5D.mp4", "Carmen Get It!", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/127%20%20%20Carmen%20Get%20It%21%20%5B1962%5D_000001.jpg" },
                    { 128, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/128%20%20%20Pent%20House%20Mouse%20%5B1963%5D.mp4", "Pent House Mouse", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/128%20%20%20Pent%20House%20Mouse%20%5B1963%5D_000001.jpg" },
                    { 129, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/129%20%20%20The%20Cat%20Above%20and%20the%20Mouse%20Below%20%5B1964%5D.mp4", "The Cat Above and the Mouse Below", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/129%20%20%20The%20Cat%20Above%20and%20the%20Mouse%20Below%20%5B1964%5D_000001.jpg" },
                    { 130, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/130%20%20%20Is%20There%20a%20Doctor%20in%20the%20Mouse%20%5B1964%5D.mp4", "Is There a Doctor in the Mouse", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/130%20%20%20Is%20There%20a%20Doctor%20in%20the%20Mouse%20%5B1964%5D_000001.jpg" },
                    { 131, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/131%20%20%20Much%20Ado%20About%20Mousing%20%5B1964%5D.mp4", "Much Ado About Mousing", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/131%20%20%20Much%20Ado%20About%20Mousing%20%5B1964%5D_000001.jpg" },
                    { 132, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/132%20%20%20Snowbody%20Loves%20Me%20%5B1964%5D.mp4", "Snowbody Loves Me", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/132%20%20%20Snowbody%20Loves%20Me%20%5B1964%5D_000001.jpg" },
                    { 87, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/087%20%20%20Downhearted%20Duckling%20%5B1954%5D.mp4", "Downhearted Duckling", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/087%20%20%20Downhearted%20Duckling%20%5B1954%5D_000001.jpg" },
                    { 133, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/133%20%20%20The%20Unshrinkable%20Jerry%20Mouse%20%5B1964%5D.mp4", "The Unshrinkable Jerry Mouse", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/133%20%20%20The%20Unshrinkable%20Jerry%20Mouse%20%5B1964%5D_000001.jpg" },
                    { 135, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/135%20%20%20Tom%20ic%20Energy%20%5B1965%5D.mp4", "Tom ic Energy", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/135%20%20%20Tom%20ic%20Energy%20%5B1965%5D_000001.jpg" },
                    { 136, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/136%20%20%20Bad%20Day%20at%20Cat%20Rock%20%5B1965%5D.mp4", "Bad Day at Cat Rock", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/136%20%20%20Bad%20Day%20at%20Cat%20Rock%20%5B1965%5D_000001.jpg" },
                    { 137, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/137%20%20%20The%20Brothers%20Carry%20Mouse%20Off%20%5B1965%5D.mp4", "The Brothers Carry Mouse Off", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/137%20%20%20The%20Brothers%20Carry%20Mouse%20Off%20%5B1965%5D_000001.jpg" },
                    { 138, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/138%20%20%20Haunted%20Mouse%20%5B1965%5D.mp4", "Haunted Mouse", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/138%20%20%20Haunted%20Mouse%20%5B1965%5D_000001.jpg" },
                    { 139, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/139%20%20%20I%27m%20Just%20Wild%20About%20Jerry%20%5B1965%5D.mp4", "I'm Just Wild About Jerry", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/139%20%20%20I%27m%20Just%20Wild%20About%20Jerry%20%5B1965%5D_000001.jpg" },
                    { 140, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/140%20%20%20Of%20Feline%20Bondage%20%5B1965%5D.mp4", "Of Feline Bondage", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/140%20%20%20Of%20Feline%20Bondage%20%5B1965%5D_000001.jpg" },
                    { 141, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/141%20%20%20The%20Year%20of%20the%20Mouse%20%5B1965%5D.mp4", "The Year of the Mouse", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/141%20%20%20The%20Year%20of%20the%20Mouse%20%5B1965%5D_000001.jpg" },
                    { 134, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/134%20%20%20Ah%2C%20Sweet%20Mouse%20Story%20of%20Life%20%5B1965%5D.mp4", "Ah, Sweet Mouse Story of Life", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/134%20%20%20Ah%2C%20Sweet%20Mouse%20Story%20of%20Life%20%5B1965%5D_000001.jpg" },
                    { 86, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/086%20%20%20Neapolitan%20Mouse%20%5B1954%5D.mp4", "Neapolitan Mouse", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/086%20%20%20Neapolitan%20Mouse%20%5B1954%5D_000001.jpg" },
                    { 85, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/085%20%20%20Mice%20Follies%20%5B1954%5D.mp4", "Mice Follies", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/085%20%20%20Mice%20Follies%20%5B1954%5D_000001.jpg" },
                    { 84, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/084%20%20%20Baby%20Butch%20%5B1954%5D.mp4", "Baby Butch", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/084%20%20%20Baby%20Butch%20%5B1954%5D_000001.jpg" },
                    { 30, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/030%20%20%20Dr.%20Jekyll%20and%20Mr.%20Mouse%20%5B1947%5D.mp4", "Dr. Jekyll and Mr. Mouse", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/030%20%20%20Dr.%20Jekyll%20and%20Mr.%20Mouse%20%5B1947%5D_000001.jpg" },
                    { 31, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/031%20%20%20Salt%20Water%20Tabby%20%5B1947%5D.mp4", "Salt Water Tabby", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/031%20%20%20Salt%20Water%20Tabby%20%5B1947%5D_000001.jpg" },
                    { 32, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/032%20%20%20A%20Mouse%20in%20the%20House%20%5B1947%5D.mp4", "A Mouse in the House", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/032%20%20%20A%20Mouse%20in%20the%20House%20%5B1947%5D_000001.jpg" },
                    { 33, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/033%20%20%20The%20Invisible%20Mouse%20%5B1947%5D.mp4", "The Invisible Mouse", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/033%20%20%20The%20Invisible%20Mouse%20%5B1947%5D_000001.jpg" },
                    { 34, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/034%20%20%20Kitty%20Foiled%20%5B1948%5D.mp4", "Kitty Foiled", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/034%20%20%20Kitty%20Foiled%20%5B1948%5D_000001.jpg" },
                    { 35, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/035%20%20%20The%20Truce%20Hurts%20%5B1948%5D.mp4", "The Truce Hurts", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/035%20%20%20The%20Truce%20Hurts%20%5B1948%5D_000001.jpg" },
                    { 36, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/036%20%20%20Old%20Rockin%27%20Chair%20Tom%20%5B1948%5D.mp4", "Old Rockin' Chair Tom", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/036%20%20%20Old%20Rockin%27%20Chair%20Tom%20%5B1948%5D_000001.jpg" },
                    { 37, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/037%20%20%20Professor%20Tom%20%5B1948%5D.mp4", "Professor Tom", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/037%20%20%20Professor%20Tom%20%5B1948%5D_000001.jpg" },
                    { 38, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/038%20%20%20Mouse%20Cleaning%20%5B1948%5D.mp4", "Mouse Cleaning", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/038%20%20%20Mouse%20Cleaning%20%5B1948%5D_000001.jpg" },
                    { 39, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/039%20%20%20Polka%20Dot%20Puss%20%5B1949%5D.mp4", "Polka Dot Puss", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/039%20%20%20Polka%20Dot%20Puss%20%5B1949%5D_000001.jpg" },
                    { 40, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/040%20%20%20The%20Little%20Orphan%20%5B1949%5D.mp4", "The Little Orphan", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/040%20%20%20The%20Little%20Orphan%20%5B1949%5D_000001.jpg" },
                    { 41, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/041%20%20%20Hatch%20Up%20Your%20Troubles%20%5B1949%5D.mp4", "Hatch Up Your Troubles", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/041%20%20%20Hatch%20Up%20Your%20Troubles%20%5B1949%5D_000001.jpg" },
                    { 42, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/042%20%20%20Heavenly%20Puss%20%5B1949%5D.mp4", "Heavenly Puss", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/042%20%20%20Heavenly%20Puss%20%5B1949%5D_000001.jpg" },
                    { 43, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/043%20%20%20The%20Cat%20and%20the%20Mermouse%20%5B1949%5D.mp4", "The Cat and the Mermouse", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/043%20%20%20The%20Cat%20and%20the%20Mermouse%20%5B1949%5D_000001.jpg" },
                    { 44, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/044%20%20%20Love%20That%20Pup%20%5B1949%5D.mp4", "Love That Pup", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/044%20%20%20Love%20That%20Pup%20%5B1949%5D_000001.jpg" },
                    { 29, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/029%20%20%20The%20Cat%20Concerto%20%5B1947%5D.mp4", "The Cat Concerto", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/029%20%20%20The%20Cat%20Concerto%20%5B1947%5D_000001.jpg" },
                    { 28, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/028%20%20%20Part%20Time%20Pal%20%5B1947%5D.mp4", "Part Time Pal", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/028%20%20%20Part%20Time%20Pal%20%5B1947%5D_000001.jpg" },
                    { 27, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/027%20%20%20Cat%20Fishin%27%20%5B1947%5D.mp4", "Cat Fishin'", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/027%20%20%20Cat%20Fishin%27%20%5B1947%5D_000001.jpg" },
                    { 26, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/026%20%20%20Solid%20Serenade%20%5B1946%5D.mp4", "Solid Serenade", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/026%20%20%20Solid%20Serenade%20%5B1946%5D_000001.jpg" },
                    { 10, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/010%20%20%20The%20Lonesome%20Mouse%20%5B1943%5D.mp4", "The Lonesome Mouse", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/010%20%20%20The%20Lonesome%20Mouse%20%5B1943%5D_000001.jpg" },
                    { 11, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/011%20%20%20The%20Yankee%20Doodle%20Mouse%20%5B1943%5D.mp4", "The Yankee Doodle Mouse", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/011%20%20%20The%20Yankee%20Doodle%20Mouse%20%5B1943%5D_000001.jpg" },
                    { 12, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/012%20%20%20Baby%20Puss%20%5B1943%5D.mp4", "Baby Puss", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/012%20%20%20Baby%20Puss%20%5B1943%5D_000001.jpg" },
                    { 13, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/013%20%20%20The%20Zoot%20Cat%20%5B1944%5D.mp4", "The Zoot Cat", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/013%20%20%20The%20Zoot%20Cat%20%5B1944%5D_000001.jpg" },
                    { 14, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/014%20%20%20The%20Million%20Dollar%20Cat%20%5B1944%5D.mp4", "The Million Dollar Cat", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/014%20%20%20The%20Million%20Dollar%20Cat%20%5B1944%5D_000001.jpg" },
                    { 15, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/015%20%20%20The%20Bodyguard%20%5B1944%5D.mp4", "The Bodyguard", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/015%20%20%20The%20Bodyguard%20%5B1944%5D_000001.jpg" },
                    { 16, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/016%20%20%20Puttin%27%20on%20the%20Dog%20%5B1944%5D.mp4", "Puttin' on the Dog", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/016%20%20%20Puttin%27%20on%20the%20Dog%20%5B1944%5D_000001.jpg" },
                    { 45, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/045%20%20%20Jerry%27s%20Diary%20%5B1949%5D.mp4", "Jerry's Diary", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/045%20%20%20Jerry%27s%20Diary%20%5B1949%5D_000001.jpg" },
                    { 17, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/017%20%20%20Mouse%20Trouble%20%5B1944%5D.mp4", "Mouse Trouble", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/017%20%20%20Mouse%20Trouble%20%5B1944%5D_000001.jpg" },
                    { 19, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/019%20%20%20Mouse%20in%20Manhattan%20%5B1945%5D.mp4", "Mouse in Manhattan", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/019%20%20%20Mouse%20in%20Manhattan%20%5B1945%5D_000001.jpg" },
                    { 20, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/020%20%20%20Tee%20for%20Two%20%5B1945%5D.mp4", "Tee for Two", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/020%20%20%20Tee%20for%20Two%20%5B1945%5D_000001.jpg" },
                    { 21, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/021%20%20%20Flirty%20Birdy%20%5B1945%5D.mp4", "Flirty Birdy", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/021%20%20%20Flirty%20Birdy%20%5B1945%5D_000001.jpg" },
                    { 22, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/022%20%20%20Quiet%20Please%21%20%5B1945%5D.mp4", "Quiet Please!", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/022%20%20%20Quiet%20Please%21%20%5B1945%5D_000001.jpg" },
                    { 23, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/023%20%20%20Springtime%20for%20Thomas%20%5B1946%5D.mp4", "Springtime for Thomas", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/023%20%20%20Springtime%20for%20Thomas%20%5B1946%5D_000001.jpg" },
                    { 24, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/024%20%20%20The%20Milky%20Waif%20%5B1946%5D.mp4", "The Milky Waif", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/024%20%20%20The%20Milky%20Waif%20%5B1946%5D_000001.jpg" },
                    { 25, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/025%20%20%20Trap%20Happy%20%5B1946%5D.mp4", "Trap Happy", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/025%20%20%20Trap%20Happy%20%5B1946%5D_000001.jpg" },
                    { 18, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/018%20%20%20The%20Mouse%20Comes%20to%20Dinner%20%5B1945%5D.mp4", "The Mouse Comes to Dinner", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/018%20%20%20The%20Mouse%20Comes%20to%20Dinner%20%5B1945%5D_000001.jpg" },
                    { 161, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/161%20%20%20Purr%20Chance%20to%20Dream%20%5B1967%5D.mp4", "Purr Chance to Dream", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/161%20%20%20Purr%20Chance%20to%20Dream%20%5B1967%5D_000001.jpg" },
                    { 46, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/046%20%20%20Tennis%20Chumps%20%5B1949%5D.mp4", "Tennis Chumps", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/046%20%20%20Tennis%20Chumps%20%5B1949%5D_000001.jpg" },
                    { 48, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/048%20%20%20Saturday%20Evening%20Puss%20%5B1950%5D.mp4", "Saturday Evening Puss", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/048%20%20%20Saturday%20Evening%20Puss%20%5B1950%5D_000001.jpg" },
                    { 69, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/069%20%20%20Fit%20to%20be%20Tied%20%5B1952%5D.mp4", "Fit to be Tied", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/069%20%20%20Fit%20to%20be%20Tied%20%5B1952%5D_000001.jpg" },
                    { 70, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/070%20%20%20Push%20Button%20Kitty%20%5B1952%5D.mp4", "Push Button Kitty", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/070%20%20%20Push%20Button%20Kitty%20%5B1952%5D_000001.jpg" },
                    { 71, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/071%20%20%20Cruise%20Cat%20%5B1952%5D.mp4", "Cruise Cat", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/071%20%20%20Cruise%20Cat%20%5B1952%5D_000001.jpg" },
                    { 72, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/072%20%20%20The%20Dog%20House%20%5B1952%5D.mp4", "The Dog House", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/072%20%20%20The%20Dog%20House%20%5B1952%5D_000001.jpg" },
                    { 73, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/073%20%20%20The%20Missing%20Mouse%20%5B1953%5D.mp4", "The Missing Mouse", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/073%20%20%20The%20Missing%20Mouse%20%5B1953%5D_000001.jpg" },
                    { 74, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/074%20%20%20Jerry%20and%20Jumbo%20%5B1953%5D.mp4", "Jerry and Jumbo", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/074%20%20%20Jerry%20and%20Jumbo%20%5B1953%5D_000001.jpg" },
                    { 75, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/075%20%20%20Johann%20Mouse%20%5B1953%5D.mp4", "Johann Mouse", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/075%20%20%20Johann%20Mouse%20%5B1953%5D_000001.jpg" },
                    { 76, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/076%20%20%20That%27s%20My%20Pup%21%20%5B1953%5D.mp4", "That's My Pup!", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/076%20%20%20That%27s%20My%20Pup%21%20%5B1953%5D_000001.jpg" },
                    { 77, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/077%20%20%20Just%20Ducky%20%5B1953%5D.mp4", "Just Ducky", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/077%20%20%20Just%20Ducky%20%5B1953%5D_000001.jpg" },
                    { 78, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/078%20%20%20Two%20Little%20Indians%20%5B1953%5D.mp4", "Two Little Indians", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/078%20%20%20Two%20Little%20Indians%20%5B1953%5D_000001.jpg" },
                    { 79, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/079%20%20%20Life%20with%20Tom%20%5B1953%5D.mp4", "Life with Tom", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/079%20%20%20Life%20with%20Tom%20%5B1953%5D_000001.jpg" },
                    { 80, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/080%20%20%20Puppy%20Tale%20%5B1954%5D.mp4", "Puppy Tale", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/080%20%20%20Puppy%20Tale%20%5B1954%5D_000001.jpg" },
                    { 81, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/081%20%20%20Posse%20Cat%20%5B1954%5D.mp4", "Posse Cat", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/081%20%20%20Posse%20Cat%20%5B1954%5D_000001.jpg" },
                    { 82, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/082%20%20%20Hic%20cup%20Pup%20%5B1954%5D.mp4", "Hic cup Pup", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/082%20%20%20Hic%20cup%20Pup%20%5B1954%5D_000001.jpg" },
                    { 83, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/083%20%20%20Little%20School%20Mouse%20%5B1954%5D.mp4", "Little School Mouse", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/083%20%20%20Little%20School%20Mouse%20%5B1954%5D_000001.jpg" },
                    { 68, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/068%20%20%20Little%20Runaway%20%5B1952%5D.mp4", "Little Runaway", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/068%20%20%20Little%20Runaway%20%5B1952%5D_000001.jpg" },
                    { 67, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/067%20%20%20Triplet%20Trouble%20%5B1952%5D.mp4", "Triplet Trouble", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/067%20%20%20Triplet%20Trouble%20%5B1952%5D_000001.jpg" },
                    { 66, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/066%20%20%20Smitten%20Kitten%20%5B1952%5D.mp4", "Smitten Kitten", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/066%20%20%20Smitten%20Kitten%20%5B1952%5D_000001.jpg" },
                    { 65, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/065%20%20%20The%20Two%20Mouseketeers%20%5B1952%5D.mp4", "The Two Mouseketeers", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/065%20%20%20The%20Two%20Mouseketeers%20%5B1952%5D_000001.jpg" },
                    { 49, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/049%20%20%20Texas%20Tom%20%5B1950%5D.mp4", "Texas Tom", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/049%20%20%20Texas%20Tom%20%5B1950%5D_000001.jpg" },
                    { 50, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/050%20%20%20Jerry%20and%20the%20Lion%20%5B1950%5D.mp4", "Jerry and the Lion", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/050%20%20%20Jerry%20and%20the%20Lion%20%5B1950%5D_000001.jpg" },
                    { 51, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/051%20%20%20Safety%20Second%20%5B1950%5D.mp4", "Safety Second", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/051%20%20%20Safety%20Second%20%5B1950%5D_000001.jpg" },
                    { 52, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/052%20%20%20The%20Hollywood%20Bowl%20%5B1950%5D.mp4", "The Hollywood Bowl", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/052%20%20%20The%20Hollywood%20Bowl%20%5B1950%5D_000001.jpg" },
                    { 53, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/053%20%20%20The%20Framed%20Cat%20%5B1950%5D.mp4", "The Framed Cat", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/053%20%20%20The%20Framed%20Cat%20%5B1950%5D_000001.jpg" },
                    { 54, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/054%20%20%20Cue%20Ball%20Cat%20%5B1950%5D.mp4", "Cue Ball Cat", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/054%20%20%20Cue%20Ball%20Cat%20%5B1950%5D_000001.jpg" },
                    { 55, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/055%20%20%20Casanova%20Cat%20%5B1951%5D.mp4", "Casanova Cat", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/055%20%20%20Casanova%20Cat%20%5B1951%5D_000001.jpg" },
                    { 47, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/047%20%20%20Little%20Quacker%20%5B1950%5D.mp4", "Little Quacker", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/047%20%20%20Little%20Quacker%20%5B1950%5D_000001.jpg" },
                    { 56, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/056%20%20%20Jerry%20and%20the%20Goldfish%20%5B1951%5D.mp4", "Jerry and the Goldfish", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/056%20%20%20Jerry%20and%20the%20Goldfish%20%5B1951%5D_000001.jpg" },
                    { 58, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/058%20%20%20Sleepy%20Time%20Tom%20%5B1951%5D.mp4", "Sleepy Time Tom", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/058%20%20%20Sleepy%20Time%20Tom%20%5B1951%5D_000001.jpg" },
                    { 59, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/059%20%20%20His%20Mouse%20Friday%20%5B1951%5D.mp4", "His Mouse Friday", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/059%20%20%20His%20Mouse%20Friday%20%5B1951%5D_000001.jpg" },
                    { 60, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/060%20%20%20Slicked%20up%20Pup%20%5B1951%5D.mp4", "Slicked up Pup", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/060%20%20%20Slicked%20up%20Pup%20%5B1951%5D_000001.jpg" },
                    { 61, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/061%20%20%20Nit%20Witty%20Kitty%20%5B1951%5D.mp4", "Nit Witty Kitty", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/061%20%20%20Nit%20Witty%20Kitty%20%5B1951%5D_000001.jpg" },
                    { 62, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/062%20%20%20Cat%20Napping%20%5B1951%5D.mp4", "Cat Napping", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/062%20%20%20Cat%20Napping%20%5B1951%5D_000001.jpg" },
                    { 63, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/063%20%20%20The%20Flying%20Cat%20%5B1952%5D.mp4", "The Flying Cat", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/063%20%20%20The%20Flying%20Cat%20%5B1952%5D_000001.jpg" },
                    { 64, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/064%20%20%20The%20Duck%20Doctor%20%5B1952%5D.mp4", "The Duck Doctor", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/064%20%20%20The%20Duck%20Doctor%20%5B1952%5D_000001.jpg" },
                    { 57, 1, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/057%20%20%20Jerry%27s%20Cousin%20%5B1951%5D.mp4", "Jerry's Cousin", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/057%20%20%20Jerry%27s%20Cousin%20%5B1951%5D_000001.jpg" }
                });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 1,
                column: "Password",
                value: "AAmiinSbDjbCXzJnHILGaOEB/dlE59F6B7AiY15plu4+Gwr8tTtlYO90VpK2Pr+07g==");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_ReceivedUserId",
                table: "Posts",
                column: "ReceivedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_SentUserId",
                table: "Posts",
                column: "SentUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_User_ReceivedUserId",
                table: "Posts",
                column: "ReceivedUserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_User_SentUserId",
                table: "Posts",
                column: "SentUserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
