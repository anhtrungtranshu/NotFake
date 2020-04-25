﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace NotFake.Migrations
{
    public partial class AsSeriesTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Film",
                keyColumn: "FilmId",
                keyValue: 2,
                column: "Type",
                value: 1);

            migrationBuilder.InsertData(
                table: "FilmData",
                columns: new[] { "Id", "FilmId", "Address", "Name", "RunTime", "ThumbnailAddress" },
                values: new object[] { 10, 2, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/008%20%20%20Fine%20Feathered%20Friend%20%5B1942%5D.mp4", "Fine Feathered Friend", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/008%20%20%20Fine%20Feathered%20Friend%20%5B1942%5D_000001.jpg" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 1,
                column: "Password",
                value: "AKw6CPkCnxnkBlwGWjtnWUIQf8QN7obv5qSx3XpCAXtR110CIyf/4Eel2MJbpYq94A==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 2,
                column: "Password",
                value: "APxVah/2bKMk0kI/wN4p9GjFj6FZXr+hItfyiKQPe6tlac+PHI1iUvA0PyFwVEB/Yw==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 3,
                column: "Password",
                value: "AMdJpindcRibkrKkZNGci5jVNeYuakyed7OZGubVVVwR69344rm8QkVAcGpUVnJ1zA==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 4,
                column: "Password",
                value: "AP0y8cyNB2pCV9X3MchF/FMB7XJeacRAl2c1T5pDbA5BR7knAVDNmES2i6qcu4L8TA==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 5,
                column: "Password",
                value: "AISNtfeW3WS0VnnlNE4NxdxFpEumS/tHZd9dCKgDbl5SpeBrnDN4wC5Rm/xpkIT3iQ==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 6,
                column: "Password",
                value: "AF1DufrphnxZgKhRp+k9xlq0P1k6MUm+xsTGWuA8OQwCywUDr9oKGbIo1comOfoCug==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 7,
                column: "Password",
                value: "AF51bbHiTfj3ixTqDnsZHAMO3QMYngbWF0sxwUhsw4etdIv1PfHRFTYdHMcmVRdzuA==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 8,
                column: "Password",
                value: "AGV/5givYwPRpEsIGFjQLAn7cVLzTq79ZRiNagPZ/hxrLbPmPu39ynbjqeGUeqkY0w==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 9,
                column: "Password",
                value: "AKZh4kLlu3zWe7Rp5auBwBCplFY20jyTzQSMI6DwjSkGaBwbygtyyNdxdl93fhhMGQ==");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 10, 2 });

            migrationBuilder.UpdateData(
                table: "Film",
                keyColumn: "FilmId",
                keyValue: 2,
                column: "Type",
                value: 0);

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 1,
                column: "Password",
                value: "AATQQjNIRbSza1h39rHkypSrJHp4NWFeJO6ug8O0Jw5iJXeS7oZF446P+OkntjxlJA==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 2,
                column: "Password",
                value: "AGIiemRo3htj1hy0IVKrZjkWhhXIH2IZs897BO4sbOuTz2tpcE/MzHjrQCUOSPtF6A==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 3,
                column: "Password",
                value: "ACT41m9ka6mzN3Xq1BBMLgXfFixVBrRD5+lNTYcCJb3QigAToav9pEkBc+1Mx2Cmcw==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 4,
                column: "Password",
                value: "AO7V1g197tSxZvGZeGC6r6lSqzlKa3t7Q1isRD5mR6SFSjH1FmYqS/SGkXmjycsBvQ==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 5,
                column: "Password",
                value: "ACT+WZnzhe6iX1r/Wj1fV+IsDhRHxXvjb559dNIxvZbgxQxQ4op0iRYVXz+PZhCrng==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 6,
                column: "Password",
                value: "ANN0y9SkllSPAjwEFHPF8drJM6QSDd5uuH7+2E07XRzRn7GkT7ewGakObd1nMZIqmw==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 7,
                column: "Password",
                value: "ANVgXA62OtXyERwu8oOm4q5HkjWOxW6P154rGydhG3l+qzYTgEhZAeI61JxnA0GVuw==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 8,
                column: "Password",
                value: "AFSN8uAsgcol4a3oWYeka2z7X9rYySndYkvDe27ECoBR+h/hWQdwXok8wAOfDyn9yg==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 9,
                column: "Password",
                value: "AJpEVdpXCMBTR9v4r2h9aYvAt+hf/g6Nn6THGwiAmncjvsbq4Ruk3xF1zNo7RTnkrg==");
        }
    }
}
