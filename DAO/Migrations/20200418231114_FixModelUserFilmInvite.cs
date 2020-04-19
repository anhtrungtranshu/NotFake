using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAO.Migrations
{
    public partial class FixModelUserFilmInvite : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserFilmInvites_Film_FilmId",
                table: "UserFilmInvites");

            migrationBuilder.DropForeignKey(
                name: "FK_UserFilmInvites_User_InvitingUserId",
                table: "UserFilmInvites");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserFilmInvites",
                table: "UserFilmInvites");

            migrationBuilder.DropIndex(
                name: "IX_UserFilmInvites_InvitingUserId",
                table: "UserFilmInvites");

            migrationBuilder.DropColumn(
                name: "InvitingUserId",
                table: "UserFilmInvites");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "UserFilmInvites");

            migrationBuilder.DropColumn(
                name: "WatchDate",
                table: "UserFilmInvites");

            migrationBuilder.RenameColumn(
                name: "FilmId",
                table: "UserFilmInvites",
                newName: "GroupId");

            migrationBuilder.RenameIndex(
                name: "IX_UserFilmInvites_FilmId",
                table: "UserFilmInvites",
                newName: "IX_UserFilmInvites_GroupId");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "UserFilmInvites",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserFilmInvites",
                table: "UserFilmInvites",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 1,
                column: "Password",
                value: "AANSrwW7CFvk6iR0tjFzDrIdOyE6v0PEEhK1Z10swjtddsh93ZFf8mubsV/7sPGlwA==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 2,
                column: "Password",
                value: "AGVKMcu3wiING4pzFUTub4LCUPTHj8dxWFxfwKtlr3y59mxwXbCpHiWahxqwtZLISA==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 3,
                column: "Password",
                value: "AHcVY6t0uC+OI1l5/9FYn7p8RE8DuvXWqYzDfbxfKnw9nrrs1mwHuk2ec2S+e+ltBQ==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 4,
                column: "Password",
                value: "ABzkxRSA4Artvzut39ekiFigLC3+YNnjo0redIwEe7GULb0oSGRcthy8Eqdc8DD2TQ==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 5,
                column: "Password",
                value: "AJI2+/Paxp8UJQqkI9j70rH7exF3Jc6Wqu5sIaBfbwOR1KNhZ32vljf0GrQxmzQSEg==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 6,
                column: "Password",
                value: "AJqgtIQ6d9tlpe0gECR4Gditi2HJ8DE2RLkHvFv9KzWlSTnO+mSDGDhQ5Jn9ZqVmeg==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 7,
                column: "Password",
                value: "ALQj6RjQZ8kIvDxONM6SZSSokGyxDaePP0xRoBvcn9YAIfqL5NRaePnfq9Mq+QwUGQ==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 8,
                column: "Password",
                value: "AONdDLWn5ZLkLPJwRedPav7ldV9+YfFCKS4jujCFmMULv0KPiP6EUJC6PnoixTVhug==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 9,
                column: "Password",
                value: "ANGtaH9ZzxWwfgGfzaPF9G0Q/lmwr24y/ehSR/+F6LB9DBP0nG2a60V14O8sy22X2A==");

            migrationBuilder.CreateIndex(
                name: "IX_UserFilmInvites_InvitedUserId",
                table: "UserFilmInvites",
                column: "InvitedUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserFilmInvites_Groups_GroupId",
                table: "UserFilmInvites",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserFilmInvites_Groups_GroupId",
                table: "UserFilmInvites");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserFilmInvites",
                table: "UserFilmInvites");

            migrationBuilder.DropIndex(
                name: "IX_UserFilmInvites_InvitedUserId",
                table: "UserFilmInvites");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "UserFilmInvites");

            migrationBuilder.RenameColumn(
                name: "GroupId",
                table: "UserFilmInvites",
                newName: "FilmId");

            migrationBuilder.RenameIndex(
                name: "IX_UserFilmInvites_GroupId",
                table: "UserFilmInvites",
                newName: "IX_UserFilmInvites_FilmId");

            migrationBuilder.AddColumn<int>(
                name: "InvitingUserId",
                table: "UserFilmInvites",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "UserFilmInvites",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "WatchDate",
                table: "UserFilmInvites",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserFilmInvites",
                table: "UserFilmInvites",
                columns: new[] { "InvitedUserId", "InvitingUserId", "FilmId" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 1,
                column: "Password",
                value: "AAp8Gl5mR9l+RlupYIJ1UoXUjW81CKVwf0iuiFGfp1MLOG88+6/QXX2otuFVpOUc5A==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 2,
                column: "Password",
                value: "AJE0hszwGTufuEp64wM8sW8y6F6/N5xtGWWPPZ29CTGAO4+bJkUtwugDJlDGMlW02Q==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 3,
                column: "Password",
                value: "APGxsJVpfYZiES+mBThYBzMnv7ro5WBBmP8yR2ebSm/+g0qrQ4YW+LcfKMRQDorKPw==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 4,
                column: "Password",
                value: "APu00iJlok7VpieXTelifUq5/G+gVuXv7txQ6n3XuFVktbjDIyjDmZxKkt8os33j1A==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 5,
                column: "Password",
                value: "AJ8Ex959VwH588C3PJoNM/lo6AIMHYJKax8ONrMG0nb8Iy34JIBgR+4Oq8Lylckfbw==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 6,
                column: "Password",
                value: "ADnEvfd1JW88Gic0Kk5d0PyjNlN7Wt4qd+/gIs4z/p4NmiLKrJo78dxNTqhNhPuVUQ==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 7,
                column: "Password",
                value: "APenOYHGcuN3gimx0iX3/2mb+NumdtURe7zifyFTmwEZQkdHCNvc2qA4Wrd0j3Re2g==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 8,
                column: "Password",
                value: "AAnCe8M7LcMpKj4xJkKs9QbpccuZ7h1NmzU5mKLjgI00aaz+kf5O92oDLZ/DzLKAqg==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 9,
                column: "Password",
                value: "AJkuTMEnzAMAi0fZ1MVFKUEe8Y48eIw+O/Bi1m3QahX2iWH9yjRkkgKfDewXHu7iDw==");

            migrationBuilder.CreateIndex(
                name: "IX_UserFilmInvites_InvitingUserId",
                table: "UserFilmInvites",
                column: "InvitingUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserFilmInvites_Film_FilmId",
                table: "UserFilmInvites",
                column: "FilmId",
                principalTable: "Film",
                principalColumn: "FilmId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserFilmInvites_User_InvitingUserId",
                table: "UserFilmInvites",
                column: "InvitingUserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
