using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Digimash.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class EmailVerification : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Role",
                table: "Users",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ResetPasswordExpiry",
                table: "Users",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "RefreshTokenExpiryTime",
                table: "Users",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<DateTime>(
                name: "EmailVerificationExpiry",
                table: "Users",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EmailVerificationToken",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "EmailVerificationExpiry", "EmailVerificationToken", "EmailVerifiedAt", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 4, 13, 58, 52, 741, DateTimeKind.Utc).AddTicks(551), null, null, new DateTime(2024, 1, 4, 13, 58, 52, 741, DateTimeKind.Utc).AddTicks(2104), new DateTime(2024, 1, 4, 13, 58, 52, 741, DateTimeKind.Utc).AddTicks(2586), new DateTime(2024, 1, 4, 13, 58, 52, 741, DateTimeKind.Utc).AddTicks(3049), new DateTime(2024, 1, 4, 13, 58, 52, 741, DateTimeKind.Utc).AddTicks(865) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "EmailVerificationExpiry", "EmailVerificationToken", "EmailVerifiedAt", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 4, 13, 58, 52, 741, DateTimeKind.Utc).AddTicks(3811), null, null, new DateTime(2024, 1, 4, 13, 58, 52, 741, DateTimeKind.Utc).AddTicks(3814), new DateTime(2024, 1, 4, 13, 58, 52, 741, DateTimeKind.Utc).AddTicks(3815), new DateTime(2024, 1, 4, 13, 58, 52, 741, DateTimeKind.Utc).AddTicks(3816), new DateTime(2024, 1, 4, 13, 58, 52, 741, DateTimeKind.Utc).AddTicks(3812) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmailVerificationExpiry",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "EmailVerificationToken",
                table: "Users");

            migrationBuilder.AlterColumn<int>(
                name: "Role",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ResetPasswordExpiry",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RefreshTokenExpiryTime",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 12, 30, 21, 6, 54, 837, DateTimeKind.Utc).AddTicks(4200), new DateTime(2023, 12, 30, 21, 6, 54, 837, DateTimeKind.Utc).AddTicks(5459), new DateTime(2023, 12, 30, 21, 6, 54, 837, DateTimeKind.Utc).AddTicks(5847), new DateTime(2023, 12, 30, 21, 6, 54, 837, DateTimeKind.Utc).AddTicks(6498), new DateTime(2023, 12, 30, 21, 6, 54, 837, DateTimeKind.Utc).AddTicks(4467) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 12, 30, 21, 6, 54, 837, DateTimeKind.Utc).AddTicks(6863), new DateTime(2023, 12, 30, 21, 6, 54, 837, DateTimeKind.Utc).AddTicks(6865), new DateTime(2023, 12, 30, 21, 6, 54, 837, DateTimeKind.Utc).AddTicks(6866), new DateTime(2023, 12, 30, 21, 6, 54, 837, DateTimeKind.Utc).AddTicks(6867), new DateTime(2023, 12, 30, 21, 6, 54, 837, DateTimeKind.Utc).AddTicks(6863) });
        }
    }
}
