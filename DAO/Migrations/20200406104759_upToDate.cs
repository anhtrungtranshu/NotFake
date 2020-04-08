using Microsoft.EntityFrameworkCore.Migrations;

namespace DAO.Migrations
{
    public partial class upToDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 1,
                column: "Password",
                value: "AAmiinSbDjbCXzJnHILGaOEB/dlE59F6B7AiY15plu4+Gwr8tTtlYO90VpK2Pr+07g==");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 1,
                column: "Password",
                value: "ANVbOvd4b6vMXsNMH/oxAau7tSA5P1e6DoGjdQYpABZeGdGYthJ4eLVeBoS3ssZ7Ag==");
        }
    }
}
