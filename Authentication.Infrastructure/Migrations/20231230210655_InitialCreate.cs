using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Authentication.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    EmailVerifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RefreshToken = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RefreshTokenExpiryTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ResetPasswordToken = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ResetPasswordExpiry = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Role = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedOn", "Email", "EmailVerifiedAt", "Name", "PasswordHash", "PasswordSalt", "RefreshToken", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "ResetPasswordToken", "Role", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 12, 30, 21, 6, 54, 837, DateTimeKind.Utc).AddTicks(4200), "superadmin@Authentication.com", new DateTime(2023, 12, 30, 21, 6, 54, 837, DateTimeKind.Utc).AddTicks(5459), "Super User", new byte[] { 35, 90, 244, 18, 43, 21, 195, 38, 253, 159, 107, 4, 55, 18, 200, 156, 84, 209, 241, 56, 27, 72, 90, 53, 220, 177, 39, 238, 117, 222, 23, 141, 154, 189, 55, 192, 113, 129, 205, 207, 226, 181, 138, 80, 84, 166, 226, 153, 64, 24, 39, 131, 91, 56, 154, 150, 210, 129, 163, 197, 230, 210, 1, 184 }, new byte[] { 141, 249, 58, 0, 174, 228, 48, 60, 70, 120, 31, 142, 153, 188, 235, 210, 202, 154, 79, 198, 74, 194, 78, 154, 133, 112, 30, 189, 171, 202, 164, 9, 106, 78, 229, 131, 106, 18, 44, 114, 165, 89, 98, 17, 156, 31, 248, 142, 103, 98, 52, 176, 27, 154, 19, 178, 8, 31, 81, 183, 114, 237, 44, 80, 213, 69, 239, 33, 27, 95, 113, 116, 150, 169, 203, 208, 49, 84, 57, 29, 132, 148, 75, 131, 223, 59, 207, 147, 37, 91, 50, 190, 55, 204, 95, 113, 39, 201, 179, 191, 245, 184, 61, 146, 8, 47, 145, 224, 10, 240, 216, 97, 159, 135, 199, 201, 113, 50, 57, 45, 232, 72, 16, 138, 86, 166, 101, 64 }, null, new DateTime(2023, 12, 30, 21, 6, 54, 837, DateTimeKind.Utc).AddTicks(5847), new DateTime(2023, 12, 30, 21, 6, 54, 837, DateTimeKind.Utc).AddTicks(6498), null, 1, new DateTime(2023, 12, 30, 21, 6, 54, 837, DateTimeKind.Utc).AddTicks(4467) },
                    { 2, new DateTime(2023, 12, 30, 21, 6, 54, 837, DateTimeKind.Utc).AddTicks(6863), "admin@Authentication.com", new DateTime(2023, 12, 30, 21, 6, 54, 837, DateTimeKind.Utc).AddTicks(6865), "Admin", new byte[] { 35, 90, 244, 18, 43, 21, 195, 38, 253, 159, 107, 4, 55, 18, 200, 156, 84, 209, 241, 56, 27, 72, 90, 53, 220, 177, 39, 238, 117, 222, 23, 141, 154, 189, 55, 192, 113, 129, 205, 207, 226, 181, 138, 80, 84, 166, 226, 153, 64, 24, 39, 131, 91, 56, 154, 150, 210, 129, 163, 197, 230, 210, 1, 184 }, new byte[] { 141, 249, 58, 0, 174, 228, 48, 60, 70, 120, 31, 142, 153, 188, 235, 210, 202, 154, 79, 198, 74, 194, 78, 154, 133, 112, 30, 189, 171, 202, 164, 9, 106, 78, 229, 131, 106, 18, 44, 114, 165, 89, 98, 17, 156, 31, 248, 142, 103, 98, 52, 176, 27, 154, 19, 178, 8, 31, 81, 183, 114, 237, 44, 80, 213, 69, 239, 33, 27, 95, 113, 116, 150, 169, 203, 208, 49, 84, 57, 29, 132, 148, 75, 131, 223, 59, 207, 147, 37, 91, 50, 190, 55, 204, 95, 113, 39, 201, 179, 191, 245, 184, 61, 146, 8, 47, 145, 224, 10, 240, 216, 97, 159, 135, 199, 201, 113, 50, 57, 45, 232, 72, 16, 138, 86, 166, 101, 64 }, null, new DateTime(2023, 12, 30, 21, 6, 54, 837, DateTimeKind.Utc).AddTicks(6866), new DateTime(2023, 12, 30, 21, 6, 54, 837, DateTimeKind.Utc).AddTicks(6867), null, 2, new DateTime(2023, 12, 30, 21, 6, 54, 837, DateTimeKind.Utc).AddTicks(6863) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
