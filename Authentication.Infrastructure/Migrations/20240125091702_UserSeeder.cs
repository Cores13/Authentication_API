using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Authentication.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UserSeeder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "SenderName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 25, 9, 17, 1, 778, DateTimeKind.Utc).AddTicks(4475), new DateTime(2024, 1, 25, 9, 17, 1, 778, DateTimeKind.Utc).AddTicks(6643), "061061061", new DateTime(2024, 1, 25, 9, 17, 1, 778, DateTimeKind.Utc).AddTicks(7245), new DateTime(2024, 1, 25, 9, 17, 1, 778, DateTimeKind.Utc).AddTicks(7917), "Superadmin", new DateTime(2024, 1, 25, 9, 17, 1, 778, DateTimeKind.Utc).AddTicks(4805) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 25, 9, 17, 1, 778, DateTimeKind.Utc).AddTicks(9902), new DateTime(2024, 1, 25, 9, 17, 1, 778, DateTimeKind.Utc).AddTicks(9905), "062062062", new DateTime(2024, 1, 25, 9, 17, 1, 778, DateTimeKind.Utc).AddTicks(9906), new DateTime(2024, 1, 25, 9, 17, 1, 778, DateTimeKind.Utc).AddTicks(9907), "Admin", new DateTime(2024, 1, 25, 9, 17, 1, 778, DateTimeKind.Utc).AddTicks(9903) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1088), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1122), "User 3", "063063063", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1124), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1126), "user3", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1089), "User3" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1136), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1139), "User 4", "064064064", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1140), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1140), "user4", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1136), "User4" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1144), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1202), "User 5", "065065065", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1202), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1202), "user5", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1144), "User5" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1206), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1209), "User 6", "066066066", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1209), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1210), "user6", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1207), "User6" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1213), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1216), "User 7", "067067067", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1216), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1217), "user7", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1214), "User7" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1219), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1222), "User 8", "068068068", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1222), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1222), "user8", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1220), "User8" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1225), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1227), "User 9", "069069069", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1228), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1228), "user9", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1225), "User9" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1232), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1238), "User 10", "061006100610", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1238), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1238), "user10", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1232), "User10" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1241), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1244), "User 11", "061106110611", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1244), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1245), "user11", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1242), "User11" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1248), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1250), "User 12", "061206120612", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1251), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1251), "user12", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1248), "User12" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1254), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1257), "User 13", "061306130613", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1257), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1257), "user13", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1254), "User13" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1260), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1262), "User 14", "061406140614", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1263), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1263), "user14", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1260), "User14" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1266), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1268), "User 15", "061506150615", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1269), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1269), "user15", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1266), "User15" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1272), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1275), "User 16", "061606160616", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1275), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1276), "user16", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1272), "User16" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1278), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1281), "User 17", "061706170617", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1281), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1281), "user17", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1278), "User17" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1285), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1288), "User 18", "061806180618", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1288), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1288), "user18", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1285), "User18" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1291), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1294), "User 19", "061906190619", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1294), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1295), "user19", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1292), "User19" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1297), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1300), "User 20", "062006200620", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1300), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1300), "user20", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1298), "User20" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1303), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1306), "User 21", "062106210621", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1306), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1306), "user21", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1303), "User21" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1338), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1341), "User 22", "062206220622", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1341), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1342), "user22", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1338), "User22" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1344), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1347), "User 23", "062306230623", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1347), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1348), "user23", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1345), "User23" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1351), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1353), "User 24", "062406240624", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1354), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1354), "user24", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1351), "User24" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1357), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1359), "User 25", "062506250625", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1359), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1360), "user25", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1357), "User25" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1363), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1365), "User 26", "062606260626", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1365), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1366), "user26", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1363), "User26" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1368), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1371), "User 27", "062706270627", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1371), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1371), "user27", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1369), "User27" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1374), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1377), "User 28", "062806280628", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1377), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1377), "user28", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1374), "User28" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1380), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1383), "User 29", "062906290629", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1383), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1383), "user29", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1380), "User29" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1386), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1389), "User 30", "063006300630", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1389), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1389), "user30", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1386), "User30" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1392), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1395), "User 31", "063106310631", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1395), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1395), "user31", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1393), "User31" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1398), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1401), "User 32", "063206320632", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1402), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1402), "user32", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1399), "User32" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1405), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1408), "User 33", "063306330633", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1408), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1408), "user33", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1405), "User33" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1412), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1415), "User 34", "063406340634", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1415), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1416), "user34", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1413), "User34" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1419), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1421), "User 35", "063506350635", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1422), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1422), "user35", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1419), "User35" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1425), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1427), "User 36", "063606360636", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1428), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1428), "user36", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1425), "User36" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1430), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1433), "User 37", "063706370637", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1434), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1434), "user37", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1431), "User37" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1436), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1439), "User 38", "063806380638", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1439), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1440), "user38", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1437), "User38" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1472), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1475), "User 39", "063906390639", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1475), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1475), "user39", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1472), "User39" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1478), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1481), "User 40", "064006400640", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1481), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1481), "user40", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1478), "User40" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1484), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1487), "User 41", "064106410641", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1487), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1488), "user41", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1485), "User41" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1490), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1493), "User 42", "064206420642", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1493), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1493), "user42", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1491), "User42" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1496), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1499), "User 43", "064306430643", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1499), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1500), "user43", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1497), "User43" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1502), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1505), "User 44", "064406440644", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1505), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1505), "user44", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1503), "User44" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1508), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1511), "User 45", "064506450645", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1512), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1512), "user45", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1509), "User45" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1515), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1518), "User 46", "064606460646", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1519), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1519), "user46", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1515), "User46" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1522), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1524), "User 47", "064706470647", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1525), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1525), "user47", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1522), "User47" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1528), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1531), "User 48", "064806480648", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1531), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1532), "user48", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1528), "User48" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1534), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1537), "User 49", "064906490649", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1537), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1537), "user49", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1535), "User49" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1540), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1543), "User 50", "065006500650", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1543), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1543), "user50", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1541), "User50" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1546), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1548), "User 51", "065106510651", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1549), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1549), "user51", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1546), "User51" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1552), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1554), "User 52", "065206520652", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1555), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1555), "user52", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1552), "User52" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1558), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1560), "User 53", "065306530653", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1561), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1561), "user53", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1558), "User53" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1564), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1566), "User 54", "065406540654", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1567), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1567), "user54", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1564), "User54" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1570), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1572), "User 55", "065506550655", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1573), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1573), "user55", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1570), "User55" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1575), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1609), "User 56", "065606560656", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1609), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1610), "user56", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1576), "User56" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1613), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1615), "User 57", "065706570657", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1616), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1616), "user57", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1613), "User57" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1619), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1621), "User 58", "065806580658", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1621), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1622), "user58", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1619), "User58" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1624), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1627), "User 59", "065906590659", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1627), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1628), "user59", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1625), "User59" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1630), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1633), "User 60", "066006600660", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1633), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1633), "user60", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1631), "User60" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1636), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1639), "User 61", "066106610661", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1639), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1640), "user61", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1637), "User61" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1642), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1645), "User 62", "066206620662", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1646), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1646), "user62", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1643), "User62" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1649), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1651), "User 63", "066306630663", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1651), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1652), "user63", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1649), "User63" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1655), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1658), "User 64", "066406640664", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1658), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1658), "user64", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1655), "User64" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1661), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1664), "User 65", "066506650665", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1664), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1664), "user65", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1661), "User65" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1668), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1671), "User 66", "066606660666", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1671), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1672), "user66", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1669), "User66" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1674), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1677), "User 67", "066706670667", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1677), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1678), "user67", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1675), "User67" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1680), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1683), "User 68", "066806680668", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1683), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1684), "user68", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1681), "User68" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1687), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1689), "User 69", "066906690669", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1689), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1690), "user69", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1687), "User69" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1692), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1695), "User 70", "067006700670", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1696), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1696), "user70", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1693), "User70" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1699), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1701), "User 71", "067106710671", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1701), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1702), "user71", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1699), "User71" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1733), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1736), "User 72", "067206720672", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1736), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1737), "user72", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1733), "User72" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1740), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1742), "User 73", "067306730673", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1743), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1743), "user73", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1740), "User73" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1746), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1749), "User 74", "067406740674", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1749), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1749), "user74", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1746), "User74" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1752), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1755), "User 75", "067506750675", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1755), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1755), "user75", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1753), "User75" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1758), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1761), "User 76", "067606760676", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1761), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1762), "user76", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1759), "User76" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1764), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1767), "User 77", "067706770677", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1767), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1767), "user77", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1764), "User77" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1770), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1773), "User 78", "067806780678", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1773), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1773), "user78", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1770), "User78" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1776), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1779), "User 79", "067906790679", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1779), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1779), "user79", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1776), "User79" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1782), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1785), "User 80", "068006800680", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1786), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1786), "user80", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1782), "User80" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1789), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1791), "User 81", "068106810681", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1792), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1792), "user81", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1789), "User81" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1795), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1797), "User 82", "068206820682", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1798), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1798), "user82", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1795), "User82" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1801), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1804), "User 83", "068306830683", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1804), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1804), "user83", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1801), "User83" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1807), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1810), "User 84", "068406840684", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1810), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1810), "user84", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1807), "User84" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1813), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1816), "User 85", "068506850685", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1816), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1817), "user85", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1814), "User85" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1819), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1822), "User 86", "068606860686", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1822), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1823), "user86", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1820), "User86" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1825), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1828), "User 87", "068706870687", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1828), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1829), "user87", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1826), "User87" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1832), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1834), "User 88", "068806880688", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1835), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1835), "user88", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1832), "User88" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1838), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1869), "User 89", "068906890689", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1870), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1870), "user89", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1838), "User89" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1873), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1875), "User 90", "069006900690", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1876), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1876), "user90", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1873), "User90" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1879), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1881), "User 91", "069106910691", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1882), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1882), "user91", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1879), "User91" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1885), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1887), "User 92", "069206920692", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1888), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1888), "user92", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1885), "User92" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1891), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1893), "User 93", "069306930693", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1894), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1894), "user93", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1891), "User93" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1897), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1899), "User 94", "069406940694", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1899), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1900), "user94", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1897), "User94" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1903), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1905), "User 95", "069506950695", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1906), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1906), "user95", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1903), "User95" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1909), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1912), "User 96", "069606960696", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1912), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1912), "user96", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1909), "User96" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1915), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1917), "User 97", "069706970697", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1918), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1918), "user97", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1915), "User97" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1921), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1923), "User 98", "069806980698", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1924), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1924), "user98", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1921), "User98" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1927), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1929), "User 99", "069906990699", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1930), new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1930), "user99", new DateTime(2024, 1, 25, 9, 17, 2, 85, DateTimeKind.Utc).AddTicks(1927), "User99" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "SenderName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 368, DateTimeKind.Utc).AddTicks(9477), new DateTime(2024, 1, 19, 11, 54, 30, 369, DateTimeKind.Utc).AddTicks(1488), null, new DateTime(2024, 1, 19, 11, 54, 30, 369, DateTimeKind.Utc).AddTicks(2018), new DateTime(2024, 1, 19, 11, 54, 30, 369, DateTimeKind.Utc).AddTicks(2551), null, new DateTime(2024, 1, 19, 11, 54, 30, 368, DateTimeKind.Utc).AddTicks(9848) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 369, DateTimeKind.Utc).AddTicks(4059), new DateTime(2024, 1, 19, 11, 54, 30, 369, DateTimeKind.Utc).AddTicks(4062), null, new DateTime(2024, 1, 19, 11, 54, 30, 369, DateTimeKind.Utc).AddTicks(4063), new DateTime(2024, 1, 19, 11, 54, 30, 369, DateTimeKind.Utc).AddTicks(4064), null, new DateTime(2024, 1, 19, 11, 54, 30, 369, DateTimeKind.Utc).AddTicks(4060) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7571), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7606), "Admin", null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7608), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7609), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7572), "Admin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7619), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7621), "Admin", null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7622), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7622), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7619), "Admin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7680), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7682), "Admin", null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7683), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7683), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7681), "Admin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7686), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7688), "Admin", null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7688), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7688), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7686), "Admin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7690), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7692), "Admin", null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7692), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7692), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7690), "Admin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7694), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7695), "Admin", null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7696), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7696), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7694), "Admin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7697), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7699), "Admin", null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7699), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7700), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7698), "Admin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7701), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7706), "Admin", null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7707), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7707), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7702), "Admin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7709), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7710), "Admin", null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7711), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7711), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7709), "Admin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7712), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7714), "Admin", null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7714), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7715), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7713), "Admin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7716), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7717), "Admin", null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7718), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7718), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7716), "Admin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7720), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7721), "Admin", null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7722), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7722), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7720), "Admin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7723), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7725), "Admin", null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7725), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7725), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7723), "Admin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7727), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7729), "Admin", null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7729), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7730), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7727), "Admin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7731), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7733), "Admin", null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7733), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7733), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7731), "Admin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7736), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7737), "Admin", null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7738), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7738), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7736), "Admin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7739), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7741), "Admin", null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7741), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7742), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7740), "Admin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7743), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7745), "Admin", null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7745), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7745), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7743), "Admin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7746), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7748), "Admin", null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7748), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7749), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7747), "Admin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7750), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7752), "Admin", null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7752), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7752), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7751), "Admin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7754), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7755), "Admin", null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7756), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7756), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7754), "Admin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7757), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7759), "Admin", null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7759), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7760), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7758), "Admin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7761), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7763), "Admin", null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7763), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7764), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7761), "Admin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7765), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7767), "Admin", null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7767), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7767), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7765), "Admin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7769), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7770), "Admin", null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7770), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7771), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7769), "Admin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7772), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7774), "Admin", null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7774), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7774), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7772), "Admin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7776), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7777), "Admin", null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7778), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7778), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7776), "Admin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7779), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7781), "Admin", null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7781), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7782), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7780), "Admin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7819), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7821), "Admin", null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7822), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7822), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7820), "Admin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7824), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7825), "Admin", null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7826), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7826), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7824), "Admin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7827), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7829), "Admin", null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7829), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7829), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7827), "Admin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7832), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7834), "Admin", null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7834), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7834), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7832), "Admin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7836), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7837), "Admin", null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7838), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7838), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7836), "Admin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7839), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7841), "Admin", null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7841), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7841), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7839), "Admin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7843), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7844), "Admin", null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7845), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7845), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7843), "Admin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7847), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7848), "Admin", null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7849), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7849), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7847), "Admin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7850), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7852), "Admin", null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7852), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7853), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7851), "Admin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7854), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7855), "Admin", null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7856), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7856), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7854), "Admin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7858), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7859), "Admin", null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7860), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7860), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7858), "Admin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7861), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7863), "Admin", null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7863), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7863), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7861), "Admin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7865), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7866), "Admin", null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7867), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7867), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7865), "Admin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7868), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7870), "Admin", null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7870), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7870), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7869), "Admin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7872), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7873), "Admin", null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7874), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7874), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7872), "Admin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7875), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7877), "Admin", null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7877), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7878), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7875), "Admin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7879), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7881), "Admin", null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7881), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7881), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7879), "Admin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7883), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7884), "Admin", null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7885), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7885), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7883), "Admin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7886), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7888), "Admin", null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7889), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7889), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7887), "Admin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7890), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7892), "Admin", null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7892), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7893), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7891), "Admin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7894), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7896), "Admin", null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7896), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7896), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7894), "Admin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7898), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7899), "Admin", null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7900), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7900), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7898), "Admin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7901), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7903), "Admin", null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7903), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7904), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7901), "Admin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7905), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7906), "Admin", null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7907), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7907), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7905), "Admin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7909), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7910), "Admin", null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7910), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7911), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7909), "Admin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7912), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7914), "Admin", null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7914), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7914), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7912), "Admin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7938), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7940), "Admin", null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7940), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7941), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7938), "Admin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7942), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7943), "Admin", null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7944), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7944), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7942), "Admin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7946), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7947), "Admin", null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7948), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7948), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7946), "Admin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7949), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7951), "Admin", null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7952), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7952), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7950), "Admin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7953), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7955), "Admin", null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7955), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7955), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7953), "Admin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7957), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7958), "Admin", null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7959), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7959), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7957), "Admin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7960), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7962), "Admin", null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7962), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7963), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7961), "Admin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7964), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7965), "Admin", null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7966), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7966), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7964), "Admin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7967), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7969), "Admin", null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7969), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7970), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7968), "Admin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7972), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7974), "Admin", null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7975), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7975), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7973), "Admin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7976), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7978), "Admin", null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7978), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7979), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7977), "Admin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7980), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7982), "Admin", null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7982), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7982), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7980), "Admin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7984), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7985), "Admin", null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7986), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7986), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7984), "Admin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7987), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7989), "Admin", null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7989), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7990), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7988), "Admin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7991), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7993), "Admin", null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7993), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7993), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7991), "Admin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7995), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7996), "Admin", null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7997), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7997), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7995), "Admin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7998), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8000), "Admin", null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8000), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8000), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(7999), "Admin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8002), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8003), "Admin", null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8004), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8004), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8002), "Admin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8006), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8007), "Admin", null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8008), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8008), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8006), "Admin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8009), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8011), "Admin", null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8011), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8011), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8009), "Admin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8013), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8015), "Admin", null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8015), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8015), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8013), "Admin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8017), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8018), "Admin", null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8018), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8019), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8017), "Admin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8020), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8022), "Admin", null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8022), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8022), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8020), "Admin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8097), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8099), "Admin", null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8100), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8100), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8097), "Admin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8101), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8103), "Admin", null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8103), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8104), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8102), "Admin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8105), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8106), "Admin", null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8107), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8107), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8105), "Admin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8108), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8110), "Admin", null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8110), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8111), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8109), "Admin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8112), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8114), "Admin", null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8114), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8114), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8112), "Admin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8116), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8117), "Admin", null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8117), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8118), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8116), "Admin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8119), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8121), "Admin", null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8121), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8121), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8119), "Admin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8123), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8124), "Admin", null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8125), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8125), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8123), "Admin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8126), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8128), "Admin", null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8128), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8129), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8127), "Admin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8130), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8131), "Admin", null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8132), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8132), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8130), "Admin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8133), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8135), "Admin", null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8135), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8136), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8134), "Admin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8137), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8138), "Admin", null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8139), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8139), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8137), "Admin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8140), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8142), "Admin", null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8142), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8143), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8141), "Admin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8144), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8146), "Admin", null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8146), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8147), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8144), "Admin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8148), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8149), "Admin", null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8150), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8150), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8148), "Admin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8151), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8153), "Admin", null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8153), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8154), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8152), "Admin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8155), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8157), "Admin", null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8157), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8157), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8155), "Admin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8158), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8160), "Admin", null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8160), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8161), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8159), "Admin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8162), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8164), "Admin", null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8164), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8164), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8162), "Admin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "Name", "PhoneNumber", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "SenderName", "UpdatedOn", "Username" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8165), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8167), "Admin", null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8167), new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8168), null, new DateTime(2024, 1, 19, 11, 54, 30, 828, DateTimeKind.Utc).AddTicks(8166), "Admin" });
        }
    }
}
