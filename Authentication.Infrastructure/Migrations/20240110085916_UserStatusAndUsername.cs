using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Authentication.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UserStatusAndUsername : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Username",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "Status", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 10, 8, 59, 15, 409, DateTimeKind.Utc).AddTicks(6504), new DateTime(2024, 1, 10, 8, 59, 15, 409, DateTimeKind.Utc).AddTicks(8404), new DateTime(2024, 1, 10, 8, 59, 15, 409, DateTimeKind.Utc).AddTicks(8905), new DateTime(2024, 1, 10, 8, 59, 15, 409, DateTimeKind.Utc).AddTicks(9529), 1, new DateTime(2024, 1, 10, 8, 59, 15, 409, DateTimeKind.Utc).AddTicks(6878), "Super User" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "Status", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 10, 8, 59, 15, 410, DateTimeKind.Utc).AddTicks(931), new DateTime(2024, 1, 10, 8, 59, 15, 410, DateTimeKind.Utc).AddTicks(935), new DateTime(2024, 1, 10, 8, 59, 15, 410, DateTimeKind.Utc).AddTicks(936), new DateTime(2024, 1, 10, 8, 59, 15, 410, DateTimeKind.Utc).AddTicks(937), 1, new DateTime(2024, 1, 10, 8, 59, 15, 410, DateTimeKind.Utc).AddTicks(932), "Admin" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Username",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 9, 12, 58, 20, 376, DateTimeKind.Utc).AddTicks(4667), new DateTime(2024, 1, 9, 12, 58, 20, 376, DateTimeKind.Utc).AddTicks(6317), new DateTime(2024, 1, 9, 12, 58, 20, 376, DateTimeKind.Utc).AddTicks(9815), new DateTime(2024, 1, 9, 12, 58, 20, 377, DateTimeKind.Utc).AddTicks(428), new DateTime(2024, 1, 9, 12, 58, 20, 376, DateTimeKind.Utc).AddTicks(5006) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 9, 12, 58, 20, 377, DateTimeKind.Utc).AddTicks(1463), new DateTime(2024, 1, 9, 12, 58, 20, 377, DateTimeKind.Utc).AddTicks(1467), new DateTime(2024, 1, 9, 12, 58, 20, 377, DateTimeKind.Utc).AddTicks(1467), new DateTime(2024, 1, 9, 12, 58, 20, 377, DateTimeKind.Utc).AddTicks(1468), new DateTime(2024, 1, 9, 12, 58, 20, 377, DateTimeKind.Utc).AddTicks(1464) });
        }
    }
}
