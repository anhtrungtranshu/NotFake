using Microsoft.EntityFrameworkCore.Migrations;

namespace DAO.Migrations
{
    public partial class MoreUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 1,
                column: "Password",
                value: "AAp8Gl5mR9l+RlupYIJ1UoXUjW81CKVwf0iuiFGfp1MLOG88+6/QXX2otuFVpOUc5A==");

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "UserId", "Email", "Fullname", "Password", "Role" },
                values: new object[,]
                {
                    { 2, "user2@demo.com", "user full name 2", "AJE0hszwGTufuEp64wM8sW8y6F6/N5xtGWWPPZ29CTGAO4+bJkUtwugDJlDGMlW02Q==", 0 },
                    { 3, "user3@demo.com", "user full name 3", "APGxsJVpfYZiES+mBThYBzMnv7ro5WBBmP8yR2ebSm/+g0qrQ4YW+LcfKMRQDorKPw==", 0 },
                    { 4, "user4@demo.com", "user full name 4", "APu00iJlok7VpieXTelifUq5/G+gVuXv7txQ6n3XuFVktbjDIyjDmZxKkt8os33j1A==", 0 },
                    { 5, "user5@demo.com", "user full name 5", "AJ8Ex959VwH588C3PJoNM/lo6AIMHYJKax8ONrMG0nb8Iy34JIBgR+4Oq8Lylckfbw==", 0 },
                    { 6, "user6@demo.com", "user full name 6", "ADnEvfd1JW88Gic0Kk5d0PyjNlN7Wt4qd+/gIs4z/p4NmiLKrJo78dxNTqhNhPuVUQ==", 0 },
                    { 7, "user7@demo.com", "user full name 7", "APenOYHGcuN3gimx0iX3/2mb+NumdtURe7zifyFTmwEZQkdHCNvc2qA4Wrd0j3Re2g==", 0 },
                    { 8, "user8@demo.com", "user full name 8", "AAnCe8M7LcMpKj4xJkKs9QbpccuZ7h1NmzU5mKLjgI00aaz+kf5O92oDLZ/DzLKAqg==", 0 },
                    { 9, "user9@demo.com", "user full name 9", "AJkuTMEnzAMAi0fZ1MVFKUEe8Y48eIw+O/Bi1m3QahX2iWH9yjRkkgKfDewXHu7iDw==", 0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 9);

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 1,
                column: "Password",
                value: "ABlxKXAgyZrphzsY72R4QS3cBiCZXGuXqlnz8PfUtBK7ZwaXv7UlvUG79EIOqDhxww==");
        }
    }
}
