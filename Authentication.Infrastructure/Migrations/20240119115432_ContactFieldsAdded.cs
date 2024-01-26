using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Authentication.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ContactFieldsAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Contacts",
                newName: "LastName");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SenderName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "BirthDate",
                table: "Contacts",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Gender",
                table: "Contacts",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 368, DateTimeKind.Utc).AddTicks(9477), "superadmin@Authentication.com", new DateTime(2024, 1, 19, 11, 54, 30, 369, DateTimeKind.Utc).AddTicks(1488), null, new DateTime(2024, 1, 19, 11, 54, 30, 369, DateTimeKind.Utc).AddTicks(2018), new DateTime(2024, 1, 19, 11, 54, 30, 369, DateTimeKind.Utc).AddTicks(2551), null, new DateTime(2024, 1, 19, 11, 54, 30, 368, DateTimeKind.Utc).AddTicks(9848) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 369, DateTimeKind.Utc).AddTicks(4059), "admin@Authentication.com", new DateTime(2024, 1, 19, 11, 54, 30, 369, DateTimeKind.Utc).AddTicks(4062), null, new DateTime(2024, 1, 19, 11, 54, 30, 369, DateTimeKind.Utc).AddTicks(4063), new DateTime(2024, 1, 19, 11, 54, 30, 369, DateTimeKind.Utc).AddTicks(4064), null, new DateTime(2024, 1, 19, 11, 54, 30, 369, DateTimeKind.Utc).AddTicks(4060) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7571), "user_3@Authentication.com", new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7606), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7608), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7609), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7572) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7619), "user_4@Authentication.com", new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7621), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7622), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7622), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7619) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7680), "user_5@Authentication.com", new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7682), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7683), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7683), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7681) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7686), "user_6@Authentication.com", new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7688), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7688), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7688), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7686) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7690), "user_7@Authentication.com", new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7692), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7692), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7692), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7690) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7694), "user_8@Authentication.com", new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7695), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7696), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7696), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7694) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7697), "user_9@Authentication.com", new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7699), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7699), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7700), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7698) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7701), "user_10@Authentication.com", new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7706), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7707), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7707), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7702) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7709), "user_11@Authentication.com", new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7710), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7711), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7711), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7709) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7712), "user_12@Authentication.com", new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7714), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7714), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7715), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7713) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7716), "user_13@Authentication.com", new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7717), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7718), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7718), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7716) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7720), "user_14@Authentication.com", new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7721), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7722), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7722), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7720) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7723), "user_15@Authentication.com", new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7725), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7725), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7725), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7723) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7727), "user_16@Authentication.com", new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7729), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7729), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7730), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7727) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7731), "user_17@Authentication.com", new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7733), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7733), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7733), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7731) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7736), "user_18@Authentication.com", new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7737), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7738), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7738), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7736) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7739), "user_19@Authentication.com", new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7741), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7741), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7742), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7740) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7743), "user_20@Authentication.com", new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7745), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7745), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7745), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7743) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7746), "user_21@Authentication.com", new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7748), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7748), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7749), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7747) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7750), "user_22@Authentication.com", new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7752), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7752), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7752), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7751) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7754), "user_23@Authentication.com", new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7755), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7756), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7756), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7754) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7757), "user_24@Authentication.com", new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7759), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7759), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7760), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7758) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7761), "user_25@Authentication.com", new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7763), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7763), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7764), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7761) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7765), "user_26@Authentication.com", new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7767), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7767), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7767), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7765) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7769), "user_27@Authentication.com", new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7770), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7770), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7771), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7769) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7772), "user_28@Authentication.com", new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7774), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7774), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7774), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7772) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7776), "user_29@Authentication.com", new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7777), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7778), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7778), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7776) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7779), "user_30@Authentication.com", new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7781), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7781), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7782), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7780) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7819), "user_31@Authentication.com", new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7821), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7822), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7822), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7820) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7824), "user_32@Authentication.com", new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7825), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7826), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7826), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7824) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7827), "user_33@Authentication.com", new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7829), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7829), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7829), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7827) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7832), "user_34@Authentication.com", new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7834), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7834), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7834), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7832) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7836), "user_35@Authentication.com", new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7837), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7838), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7838), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7836) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7839), "user_36@Authentication.com", new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7841), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7841), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7841), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7839) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7843), "user_37@Authentication.com", new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7844), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7845), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7845), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7843) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7847), "user_38@Authentication.com", new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7848), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7849), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7849), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7847) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7850), "user_39@Authentication.com", new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7852), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7852), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7853), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7851) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7854), "user_40@Authentication.com", new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7855), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7856), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7856), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7854) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7858), "user_41@Authentication.com", new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7859), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7860), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7860), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7858) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7861), "user_42@Authentication.com", new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7863), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7863), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7863), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7861) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7865), "user_43@Authentication.com", new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7866), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7867), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7867), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7865) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7868), "user_44@Authentication.com", new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7870), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7870), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7870), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7869) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7872), "user_45@Authentication.com", new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7873), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7874), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7874), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7872) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7875), "user_46@Authentication.com", new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7877), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7877), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7878), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7875) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7879), "user_47@Authentication.com", new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7881), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7881), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7881), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7879) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7883), "user_48@Authentication.com", new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7884), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7885), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7885), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7883) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7886), "user_49@Authentication.com", new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7888), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7889), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7889), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7887) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7890), "user_50@Authentication.com", new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7892), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7892), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7893), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7891) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7894), "user_51@Authentication.com", new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7896), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7896), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7896), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7894) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7898), "user_52@Authentication.com", new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7899), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7900), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7900), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7898) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7901), "user_53@Authentication.com", new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7903), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7903), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7904), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7901) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7905), "user_54@Authentication.com", new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7906), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7907), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7907), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7905) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7909), "user_55@Authentication.com", new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7910), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7910), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7911), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7909) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7912), "user_56@Authentication.com", new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7914), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7914), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7914), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7912) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7938), "user_57@Authentication.com", new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7940), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7940), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7941), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7938) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7942), "user_58@Authentication.com", new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7943), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7944), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7944), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7942) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7946), "user_59@Authentication.com", new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7947), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7948), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7948), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7946) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7949), "user_60@Authentication.com", new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7951), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7952), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7952), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7950) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7953), "user_61@Authentication.com", new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7955), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7955), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7955), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7953) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7957), "user_62@Authentication.com", new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7958), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7959), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7959), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7957) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7960), "user_63@Authentication.com", new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7962), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7962), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7963), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7961) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7964), "user_64@Authentication.com", new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7965), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7966), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7966), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7964) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7967), "user_65@Authentication.com", new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7969), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7969), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7970), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7968) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7972), "user_66@Authentication.com", new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7974), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7975), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7975), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7973) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7976), "user_67@Authentication.com", new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7978), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7978), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7979), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7977) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7980), "user_68@Authentication.com", new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7982), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7982), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7982), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7980) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7984), "user_69@Authentication.com", new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7985), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7986), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7986), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7984) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7987), "user_70@Authentication.com", new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7989), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7989), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7990), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7988) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7991), "user_71@Authentication.com", new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7993), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7993), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7993), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7991) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7995), "user_72@Authentication.com", new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7996), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7997), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7997), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7995) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7998), "user_73@Authentication.com", new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8000), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8000), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8000), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7999) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8002), "user_74@Authentication.com", new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8003), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8004), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8004), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8002) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8006), "user_75@Authentication.com", new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8007), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8008), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8008), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8006) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8009), "user_76@Authentication.com", new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8011), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8011), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8011), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8009) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8013), "user_77@Authentication.com", new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8015), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8015), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8015), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8013) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8017), "user_78@Authentication.com", new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8018), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8018), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8019), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8017) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8020), "user_79@Authentication.com", new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8022), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8022), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8022), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8020) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8097), "user_80@Authentication.com", new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8099), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8100), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8100), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8097) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8101), "user_81@Authentication.com", new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8103), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8103), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8104), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8102) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8105), "user_82@Authentication.com", new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8106), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8107), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8107), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8105) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8108), "user_83@Authentication.com", new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8110), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8110), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8111), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8109) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8112), "user_84@Authentication.com", new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8114), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8114), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8114), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8112) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8116), "user_85@Authentication.com", new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8117), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8117), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8118), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8116) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8119), "user_86@Authentication.com", new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8121), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8121), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8121), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8119) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8123), "user_87@Authentication.com", new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8124), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8125), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8125), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8123) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8126), "user_88@Authentication.com", new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8128), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8128), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8129), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8127) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8130), "user_89@Authentication.com", new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8131), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8132), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8132), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8130) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8133), "user_90@Authentication.com", new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8135), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8135), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8136), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8134) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8137), "user_91@Authentication.com", new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8138), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8139), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8139), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8137) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8140), "user_92@Authentication.com", new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8142), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8142), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8143), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8141) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8144), "user_93@Authentication.com", new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8146), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8146), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8147), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8144) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8148), "user_94@Authentication.com", new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8149), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8150), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8150), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8148) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8151), "user_95@Authentication.com", new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8153), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8153), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8154), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8152) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8155), "user_96@Authentication.com", new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8157), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8157), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8157), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8155) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8158), "user_97@Authentication.com", new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8160), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8160), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8161), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8159) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8162), "user_98@Authentication.com", new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8164), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8164), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8164), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8162) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8165), "user_99@Authentication.com", new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8167), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8167), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8168), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8166) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "SenderName",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "BirthDate",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Contacts");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Contacts",
                newName: "Name");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 11, 14, 18, 38, 543, DateTimeKind.Utc).AddTicks(1375), "superadmin@Authentication.com", new DateTime(2024, 1, 11, 14, 18, 38, 543, DateTimeKind.Utc).AddTicks(3370), new DateTime(2024, 1, 11, 14, 18, 38, 543, DateTimeKind.Utc).AddTicks(3915), new DateTime(2024, 1, 11, 14, 18, 38, 543, DateTimeKind.Utc).AddTicks(4450), new DateTime(2024, 1, 11, 14, 18, 38, 543, DateTimeKind.Utc).AddTicks(1718) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 11, 14, 18, 38, 543, DateTimeKind.Utc).AddTicks(5989), "admin@Authentication.com", new DateTime(2024, 1, 11, 14, 18, 38, 543, DateTimeKind.Utc).AddTicks(5992), new DateTime(2024, 1, 11, 14, 18, 38, 543, DateTimeKind.Utc).AddTicks(5993), new DateTime(2024, 1, 11, 14, 18, 38, 543, DateTimeKind.Utc).AddTicks(5994), new DateTime(2024, 1, 11, 14, 18, 38, 543, DateTimeKind.Utc).AddTicks(5990) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2381), "user_3@Authentication.com", new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2414), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2415), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2416), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2382) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2422), "user_4@Authentication.com", new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2424), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2425), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2425), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2423) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2427), "user_5@Authentication.com", new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2428), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2429), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2429), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2427) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2431), "user_6@Authentication.com", new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2484), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2485), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2485), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2432) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2486), "user_7@Authentication.com", new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2488), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2488), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2489), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2487) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2490), "user_8@Authentication.com", new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2492), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2492), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2492), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2490) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2493), "user_9@Authentication.com", new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2495), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2495), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2496), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2494) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2498), "user_10@Authentication.com", new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2504), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2504), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2504), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2498) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2505), "user_11@Authentication.com", new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2507), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2507), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2508), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2506) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2509), "user_12@Authentication.com", new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2510), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2511), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2511), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2509) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2512), "user_13@Authentication.com", new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2514), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2514), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2514), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2513) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2516), "user_14@Authentication.com", new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2517), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2517), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2518), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2516) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2519), "user_15@Authentication.com", new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2520), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2521), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2521), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2519) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2522), "user_16@Authentication.com", new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2524), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2525), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2525), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2523) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2526), "user_17@Authentication.com", new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2528), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2528), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2528), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2526) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2530), "user_18@Authentication.com", new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2532), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2532), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2533), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2531) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2534), "user_19@Authentication.com", new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2536), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2536), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2536), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2534) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2538), "user_20@Authentication.com", new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2539), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2539), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2540), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2538) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2541), "user_21@Authentication.com", new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2542), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2543), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2543), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2541) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2544), "user_22@Authentication.com", new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2546), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2546), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2547), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2545) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2548), "user_23@Authentication.com", new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2549), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2550), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2550), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2548) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2551), "user_24@Authentication.com", new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2553), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2553), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2553), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2551) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2554), "user_25@Authentication.com", new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2556), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2556), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2557), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2555) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2558), "user_26@Authentication.com", new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2559), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2560), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2560), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2558) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2561), "user_27@Authentication.com", new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2563), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2563), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2563), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2561) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2564), "user_28@Authentication.com", new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2566), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2566), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2567), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2565) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2568), "user_29@Authentication.com", new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2569), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2570), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2570), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2568) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2571), "user_30@Authentication.com", new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2573), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2573), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2574), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2572) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2575), "user_31@Authentication.com", new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2576), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2577), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2577), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2575) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2578), "user_32@Authentication.com", new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2580), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2580), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2580), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2578) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2581), "user_33@Authentication.com", new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2583), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2583), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2584), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2582) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2620), "user_34@Authentication.com", new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2622), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2622), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2623), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2620) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2624), "user_35@Authentication.com", new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2626), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2626), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2626), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2624) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2628), "user_36@Authentication.com", new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2629), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2629), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2630), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2628) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2631), "user_37@Authentication.com", new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2632), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2633), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2633), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2631) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2634), "user_38@Authentication.com", new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2636), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2636), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2636), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2635) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2638), "user_39@Authentication.com", new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2639), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2639), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2640), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2638) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2641), "user_40@Authentication.com", new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2642), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2643), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2643), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2641) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2644), "user_41@Authentication.com", new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2646), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2646), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2646), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2645) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2648), "user_42@Authentication.com", new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2649), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2650), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2650), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2648) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2651), "user_43@Authentication.com", new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2653), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2653), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2653), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2651) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2654), "user_44@Authentication.com", new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2656), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2656), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2657), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2655) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2658), "user_45@Authentication.com", new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2659), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2660), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2660), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2658) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2661), "user_46@Authentication.com", new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2663), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2663), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2663), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2661) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2665), "user_47@Authentication.com", new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2666), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2667), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2667), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2665) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2668), "user_48@Authentication.com", new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2670), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2671), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2671), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2669) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2672), "user_49@Authentication.com", new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2674), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2674), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2675), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2672) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2676), "user_50@Authentication.com", new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2677), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2678), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2678), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2676) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2679), "user_51@Authentication.com", new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2681), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2681), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2682), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2680) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2683), "user_52@Authentication.com", new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2684), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2685), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2685), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2683) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2686), "user_53@Authentication.com", new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2688), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2688), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2688), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2686) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2689), "user_54@Authentication.com", new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2691), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2691), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2692), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2690) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2693), "user_55@Authentication.com", new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2694), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2695), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2695), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2693) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2696), "user_56@Authentication.com", new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2698), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2698), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2699), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2696) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2700), "user_57@Authentication.com", new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2701), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2702), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2702), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2700) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2703), "user_58@Authentication.com", new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2704), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2705), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2705), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2706), "user_59@Authentication.com", new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2708), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2708), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2709), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2707) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2710), "user_60@Authentication.com", new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2711), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2712), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2712), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2710) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2713), "user_61@Authentication.com", new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2715), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2715), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2715), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2714) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2738), "user_62@Authentication.com", new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2740), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2740), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2740), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2738) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2741), "user_63@Authentication.com", new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2743), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2743), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2743), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2742) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2745), "user_64@Authentication.com", new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2747), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2747), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2747), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2745) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2748), "user_65@Authentication.com", new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2750), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2750), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2751), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2749) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2753), "user_66@Authentication.com", new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2755), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2755), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2755), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2753) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2756), "user_67@Authentication.com", new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2758), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2758), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2759), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2757) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2760), "user_68@Authentication.com", new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2761), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2762), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2762), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2760) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2763), "user_69@Authentication.com", new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2765), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2765), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2765), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2763) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2767), "user_70@Authentication.com", new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2768), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2768), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2769), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2767) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2770), "user_71@Authentication.com", new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2771), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2772), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2772), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2770) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2773), "user_72@Authentication.com", new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2775), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2775), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2775), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2774) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2776), "user_73@Authentication.com", new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2778), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2778), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2779), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2777) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2780), "user_74@Authentication.com", new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2781), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2782), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2782), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2780) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2783), "user_75@Authentication.com", new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2785), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2785), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2785), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2783) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2787), "user_76@Authentication.com", new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2788), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2788), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2789), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2787) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2790), "user_77@Authentication.com", new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2791), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2792), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2792), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2790) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2793), "user_78@Authentication.com", new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2795), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2795), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2795), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2794) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2797), "user_79@Authentication.com", new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2798), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2798), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2799), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2797) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2800), "user_80@Authentication.com", new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2801), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2802), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2802), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2800) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2803), "user_81@Authentication.com", new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2805), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2805), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2805), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2803) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2806), "user_82@Authentication.com", new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2808), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2809), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2809), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2807) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2810), "user_83@Authentication.com", new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2812), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2812), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2812), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2810) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2813), "user_84@Authentication.com", new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2815), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2815), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2816), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2814) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2817), "user_85@Authentication.com", new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2818), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2819), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2819), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2817) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2877), "user_86@Authentication.com", new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2878), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2879), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2879), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2877) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2880), "user_87@Authentication.com", new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2882), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2882), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2882), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2881) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2884), "user_88@Authentication.com", new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2885), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2886), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2886), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2884) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2887), "user_89@Authentication.com", new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2888), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2889), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2889), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2887) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2890), "user_90@Authentication.com", new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2892), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2892), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2892), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2891) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2894), "user_91@Authentication.com", new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2895), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2895), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2896), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2894) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2897), "user_92@Authentication.com", new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2898), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2899), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2899), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2897) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2900), "user_93@Authentication.com", new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2902), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2902), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2902), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2900) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2904), "user_94@Authentication.com", new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2905), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2906), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2906), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2904) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2907), "user_95@Authentication.com", new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2909), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2909), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2909), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2908) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2910), "user_96@Authentication.com", new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2912), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2912), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2913), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2911) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2914), "user_97@Authentication.com", new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2915), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2916), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2916), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2914) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2917), "user_98@Authentication.com", new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2919), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2919), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2919), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2917) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedOn", "Email", "EmailVerifiedAt", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2920), "user_99@Authentication.com", new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2922), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2922), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2922), new DateTime(2024, 1, 11, 14, 18, 38, 815, DateTimeKind.Utc).AddTicks(2921) });
        }
    }
}
