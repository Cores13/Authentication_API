using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Authentication.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Contacts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contacts_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_UserId",
                table: "Contacts",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 4, 13, 58, 52, 741, DateTimeKind.Utc).AddTicks(551), new DateTime(2024, 1, 4, 13, 58, 52, 741, DateTimeKind.Utc).AddTicks(2104), new DateTime(2024, 1, 4, 13, 58, 52, 741, DateTimeKind.Utc).AddTicks(2586), new DateTime(2024, 1, 4, 13, 58, 52, 741, DateTimeKind.Utc).AddTicks(3049), new DateTime(2024, 1, 4, 13, 58, 52, 741, DateTimeKind.Utc).AddTicks(865) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "EmailVerifiedAt", "RefreshTokenExpiryTime", "ResetPasswordExpiry", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 1, 4, 13, 58, 52, 741, DateTimeKind.Utc).AddTicks(3811), new DateTime(2024, 1, 4, 13, 58, 52, 741, DateTimeKind.Utc).AddTicks(3814), new DateTime(2024, 1, 4, 13, 58, 52, 741, DateTimeKind.Utc).AddTicks(3815), new DateTime(2024, 1, 4, 13, 58, 52, 741, DateTimeKind.Utc).AddTicks(3816), new DateTime(2024, 1, 4, 13, 58, 52, 741, DateTimeKind.Utc).AddTicks(3812) });
        }
    }
}
