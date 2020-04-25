using Microsoft.EntityFrameworkCore.Migrations;

namespace NotFake.Migrations
{
    public partial class GenreSeedTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Genre",
                columns: new[] { "GenreId", "Name" },
                values: new object[] { 2, "Action" });

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

            migrationBuilder.InsertData(
                table: "Film",
                columns: new[] { "FilmId", "GenreId", "Name", "ThumbnailAddress", "Type" },
                values: new object[] { 2, 2, "Action Film Example", "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/__ia_thumb.jpg", 0 });

            migrationBuilder.InsertData(
                table: "FilmData",
                columns: new[] { "Id", "FilmId", "Address", "Name", "RunTime", "ThumbnailAddress" },
                values: new object[] { 9, 2, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/008%20%20%20Fine%20Feathered%20Friend%20%5B1942%5D.mp4", "Fine Feathered Friend", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/008%20%20%20Fine%20Feathered%20Friend%20%5B1942%5D_000001.jpg" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 9, 2 });

            migrationBuilder.DeleteData(
                table: "Film",
                keyColumn: "FilmId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "GenreId",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 1,
                column: "Password",
                value: "ANUhHzTPpImI2jouF/cYEADKo8PE306TH5SR9RZBE5R+0AoTzJdekxww1/FT5JD4OQ==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 2,
                column: "Password",
                value: "ANYbRFBwwBizUR8GETM8s4VVzSftcdfhrmFlCqIe/Uv6N+MxmtcqddLSqZPZkYkArQ==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 3,
                column: "Password",
                value: "ACvYZhsZsYy5yR28B5r8/St6jWqwVP1e1nOgIb8lGlwwUDXUoJ9J92sY0hz2WFJLQg==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 4,
                column: "Password",
                value: "AIbyomJIKALguGJicoMukD0BRxgCH45ASr3kQqrmjLHomygKJA+9lroU+kBi3F+7zQ==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 5,
                column: "Password",
                value: "AJoDHiPPF4geOrdsFl4uSbdFTiJ+g5ddu6BpnhSc+xOHYgGLm/h1S6SncK8aYEdJXQ==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 6,
                column: "Password",
                value: "AIXrcPD3w9C1lH9BzrduegXk5SEbkzq5IDMJ6jPNWTHEA9dTG47lAEGeIDS37cYemw==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 7,
                column: "Password",
                value: "ADHumWYCkTcqbgGLHNv8UN+Sxs0F6hcIQsVelqN/h7Q+adg53v6pw+ahvzVy/HzYJA==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 8,
                column: "Password",
                value: "AAOI/8C8hv/VXbA0EdWNzMHsXWfGxA3Ub5/OkyDWxIzofs1vpQ7kzaNDg7/Q556W/g==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 9,
                column: "Password",
                value: "AGpVzlKFw8uc9bth5KYPpa2192v5Zn0hx26ztA402kQzdjiqIgk9NGadKUufU3+SGw==");
        }
    }
}
