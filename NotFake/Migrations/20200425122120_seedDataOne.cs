using Microsoft.EntityFrameworkCore.Migrations;

namespace NotFake.Migrations
{
    public partial class seedDataOne : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Film",
                keyColumn: "FilmId",
                keyValue: 2,
                columns: new[] { "GenreId", "Name" },
                values: new object[] { 1, "Tom and Jerry 2" });

            migrationBuilder.InsertData(
                table: "Film",
                columns: new[] { "FilmId", "GenreId", "Name", "ThumbnailAddress", "Type" },
                values: new object[,]
                {
                    { 9, 2, "Hard Gun II : Reloaded", "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/__ia_thumb.jpg", 1 },
                    { 8, 2, "Hard Gun", "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/__ia_thumb.jpg", 1 },
                    { 7, 2, "Action Film Example 1", "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/__ia_thumb.jpg", 1 },
                    { 10, 2, "A Knock at the Door", "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/__ia_thumb.jpg", 1 },
                    { 5, 1, "Meet the Dogs", "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/__ia_thumb.jpg", 1 },
                    { 4, 1, "Excalibur!", "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/__ia_thumb.jpg", 1 },
                    { 3, 1, "The Land Before Rhyme", "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/__ia_thumb.jpg", 1 },
                    { 6, 1, "Home Away From Home", "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/__ia_thumb.jpg", 1 }
                });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 1,
                column: "Password",
                value: "AJkaPNio0CZvhiTNa45pyuOnCfsVUX7aCav0c0jAQ9fkSCb/MUJjn0yMJN+FV6qJnA==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 2,
                column: "Password",
                value: "AFOsk2DGjOCBiu2qPkqIDIXg9AIRWQzLef9dx+rZnZrMrMClerg/pR7u/1s0wRSEjg==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 3,
                column: "Password",
                value: "AADAehi+qNplWugpsXIG5e3XjZyc5+QcUBOpvCk1fu7ZtgQsOvIm3Iu2IOXKgnJQww==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 4,
                column: "Password",
                value: "AMaj8yHcueRHZ34Qz/qM9fbkFVCf/ZVDM/coftO8Qbh15YJTTKq2RYTE9/0Pr/an6g==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 5,
                column: "Password",
                value: "AGmSh7MY8kdg3Vaoo4nRqscv7pkcqY/ductqakHcNpld45fdQxiP8CTimi2XD2/tMg==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 6,
                column: "Password",
                value: "APVnKyyueY468TKj1iNYcTMDS/HBTnrrraN4BJVFdMJgGv1RVAhNd/cquMFpsu90jA==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 7,
                column: "Password",
                value: "AC6n8EbS+zeh+aCAJLrmD1aTFVy0zvgdkJp+whCh7pyxiHYZJHQM6mUnO/44qdJ/Lg==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 8,
                column: "Password",
                value: "AGtnnbHoJSUMTggEtmBQImYvi0Gc6LCZT0Z5c7EAbUMvCr7qNiq84yq6+e7drW3Fdg==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 9,
                column: "Password",
                value: "ALH98hHwAcxu+aQltmzCkINET8DJ37g6kgplGJTC8f4CFg2nvxwF7V2PpgtbYSPYDA==");

            migrationBuilder.InsertData(
                table: "FilmData",
                columns: new[] { "Id", "FilmId", "Address", "Name", "RunTime", "ThumbnailAddress" },
                values: new object[,]
                {
                    { 11, 3, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/008%20%20%20Fine%20Feathered%20Friend%20%5B1942%5D.mp4", "Fine Feathered Friend", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/008%20%20%20Fine%20Feathered%20Friend%20%5B1942%5D_000001.jpg" },
                    { 12, 3, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/008%20%20%20Fine%20Feathered%20Friend%20%5B1942%5D.mp4", "Fine Feathered Friend", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/008%20%20%20Fine%20Feathered%20Friend%20%5B1942%5D_000001.jpg" },
                    { 13, 4, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/008%20%20%20Fine%20Feathered%20Friend%20%5B1942%5D.mp4", "Fine Feathered Friend", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/008%20%20%20Fine%20Feathered%20Friend%20%5B1942%5D_000001.jpg" },
                    { 14, 4, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/008%20%20%20Fine%20Feathered%20Friend%20%5B1942%5D.mp4", "Fine Feathered Friend", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/008%20%20%20Fine%20Feathered%20Friend%20%5B1942%5D_000001.jpg" },
                    { 15, 5, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/008%20%20%20Fine%20Feathered%20Friend%20%5B1942%5D.mp4", "Fine Feathered Friend", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/008%20%20%20Fine%20Feathered%20Friend%20%5B1942%5D_000001.jpg" },
                    { 16, 5, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/008%20%20%20Fine%20Feathered%20Friend%20%5B1942%5D.mp4", "Fine Feathered Friend", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/008%20%20%20Fine%20Feathered%20Friend%20%5B1942%5D_000001.jpg" },
                    { 17, 6, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/008%20%20%20Fine%20Feathered%20Friend%20%5B1942%5D.mp4", "Fine Feathered Friend", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/008%20%20%20Fine%20Feathered%20Friend%20%5B1942%5D_000001.jpg" },
                    { 18, 6, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/008%20%20%20Fine%20Feathered%20Friend%20%5B1942%5D.mp4", "Fine Feathered Friend", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/008%20%20%20Fine%20Feathered%20Friend%20%5B1942%5D_000001.jpg" },
                    { 19, 7, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/008%20%20%20Fine%20Feathered%20Friend%20%5B1942%5D.mp4", "Fine Feathered Friend", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/008%20%20%20Fine%20Feathered%20Friend%20%5B1942%5D_000001.jpg" },
                    { 20, 7, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/008%20%20%20Fine%20Feathered%20Friend%20%5B1942%5D.mp4", "Fine Feathered Friend", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/008%20%20%20Fine%20Feathered%20Friend%20%5B1942%5D_000001.jpg" },
                    { 21, 8, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/008%20%20%20Fine%20Feathered%20Friend%20%5B1942%5D.mp4", "Fine Feathered Friend", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/008%20%20%20Fine%20Feathered%20Friend%20%5B1942%5D_000001.jpg" },
                    { 22, 8, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/008%20%20%20Fine%20Feathered%20Friend%20%5B1942%5D.mp4", "Fine Feathered Friend", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/008%20%20%20Fine%20Feathered%20Friend%20%5B1942%5D_000001.jpg" },
                    { 23, 9, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/008%20%20%20Fine%20Feathered%20Friend%20%5B1942%5D.mp4", "Fine Feathered Friend", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/008%20%20%20Fine%20Feathered%20Friend%20%5B1942%5D_000001.jpg" },
                    { 24, 9, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/008%20%20%20Fine%20Feathered%20Friend%20%5B1942%5D.mp4", "Fine Feathered Friend", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/008%20%20%20Fine%20Feathered%20Friend%20%5B1942%5D_000001.jpg" },
                    { 25, 10, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/008%20%20%20Fine%20Feathered%20Friend%20%5B1942%5D.mp4", "Fine Feathered Friend", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/008%20%20%20Fine%20Feathered%20Friend%20%5B1942%5D_000001.jpg" },
                    { 26, 10, "https://ia601204.us.archive.org/33/items/126BuddiesThickerThanWater1962/008%20%20%20Fine%20Feathered%20Friend%20%5B1942%5D.mp4", "Fine Feathered Friend", 100, "https://archive.org/download/126BuddiesThickerThanWater1962/126BuddiesThickerThanWater1962.thumbs/008%20%20%20Fine%20Feathered%20Friend%20%5B1942%5D_000001.jpg" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 11, 3 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 12, 3 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 13, 4 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 14, 4 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 15, 5 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 16, 5 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 17, 6 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 18, 6 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 19, 7 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 20, 7 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 21, 8 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 22, 8 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 23, 9 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 24, 9 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 25, 10 });

            migrationBuilder.DeleteData(
                table: "FilmData",
                keyColumns: new[] { "Id", "FilmId" },
                keyValues: new object[] { 26, 10 });

            migrationBuilder.DeleteData(
                table: "Film",
                keyColumn: "FilmId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Film",
                keyColumn: "FilmId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Film",
                keyColumn: "FilmId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Film",
                keyColumn: "FilmId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Film",
                keyColumn: "FilmId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Film",
                keyColumn: "FilmId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Film",
                keyColumn: "FilmId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Film",
                keyColumn: "FilmId",
                keyValue: 10);

            migrationBuilder.UpdateData(
                table: "Film",
                keyColumn: "FilmId",
                keyValue: 2,
                columns: new[] { "GenreId", "Name" },
                values: new object[] { 2, "Action Film Example" });

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
    }
}
