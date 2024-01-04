﻿// <auto-generated />
using System;
using Digimash.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Digimash.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231230210655_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Digimash.Domain.Entities.User", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"));

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("EmailVerifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("RefreshToken")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RefreshTokenExpiryTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ResetPasswordExpiry")
                        .HasColumnType("datetime2");

                    b.Property<string>("ResetPasswordToken")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedOn = new DateTime(2023, 12, 30, 21, 6, 54, 837, DateTimeKind.Utc).AddTicks(4200),
                            Email = "superadmin@digimash.com",
                            EmailVerifiedAt = new DateTime(2023, 12, 30, 21, 6, 54, 837, DateTimeKind.Utc).AddTicks(5459),
                            Name = "Super Administrator",
                            PasswordHash = new byte[] { 35, 90, 244, 18, 43, 21, 195, 38, 253, 159, 107, 4, 55, 18, 200, 156, 84, 209, 241, 56, 27, 72, 90, 53, 220, 177, 39, 238, 117, 222, 23, 141, 154, 189, 55, 192, 113, 129, 205, 207, 226, 181, 138, 80, 84, 166, 226, 153, 64, 24, 39, 131, 91, 56, 154, 150, 210, 129, 163, 197, 230, 210, 1, 184 },
                            PasswordSalt = new byte[] { 141, 249, 58, 0, 174, 228, 48, 60, 70, 120, 31, 142, 153, 188, 235, 210, 202, 154, 79, 198, 74, 194, 78, 154, 133, 112, 30, 189, 171, 202, 164, 9, 106, 78, 229, 131, 106, 18, 44, 114, 165, 89, 98, 17, 156, 31, 248, 142, 103, 98, 52, 176, 27, 154, 19, 178, 8, 31, 81, 183, 114, 237, 44, 80, 213, 69, 239, 33, 27, 95, 113, 116, 150, 169, 203, 208, 49, 84, 57, 29, 132, 148, 75, 131, 223, 59, 207, 147, 37, 91, 50, 190, 55, 204, 95, 113, 39, 201, 179, 191, 245, 184, 61, 146, 8, 47, 145, 224, 10, 240, 216, 97, 159, 135, 199, 201, 113, 50, 57, 45, 232, 72, 16, 138, 86, 166, 101, 64 },
                            RefreshTokenExpiryTime = new DateTime(2023, 12, 30, 21, 6, 54, 837, DateTimeKind.Utc).AddTicks(5847),
                            ResetPasswordExpiry = new DateTime(2023, 12, 30, 21, 6, 54, 837, DateTimeKind.Utc).AddTicks(6498),
                            Role = 1,
                            UpdatedOn = new DateTime(2023, 12, 30, 21, 6, 54, 837, DateTimeKind.Utc).AddTicks(4467)
                        },
                        new
                        {
                            Id = 2,
                            CreatedOn = new DateTime(2023, 12, 30, 21, 6, 54, 837, DateTimeKind.Utc).AddTicks(6863),
                            Email = "admin@digimash.com",
                            EmailVerifiedAt = new DateTime(2023, 12, 30, 21, 6, 54, 837, DateTimeKind.Utc).AddTicks(6865),
                            Name = "Admin",
                            PasswordHash = new byte[] { 35, 90, 244, 18, 43, 21, 195, 38, 253, 159, 107, 4, 55, 18, 200, 156, 84, 209, 241, 56, 27, 72, 90, 53, 220, 177, 39, 238, 117, 222, 23, 141, 154, 189, 55, 192, 113, 129, 205, 207, 226, 181, 138, 80, 84, 166, 226, 153, 64, 24, 39, 131, 91, 56, 154, 150, 210, 129, 163, 197, 230, 210, 1, 184 },
                            PasswordSalt = new byte[] { 141, 249, 58, 0, 174, 228, 48, 60, 70, 120, 31, 142, 153, 188, 235, 210, 202, 154, 79, 198, 74, 194, 78, 154, 133, 112, 30, 189, 171, 202, 164, 9, 106, 78, 229, 131, 106, 18, 44, 114, 165, 89, 98, 17, 156, 31, 248, 142, 103, 98, 52, 176, 27, 154, 19, 178, 8, 31, 81, 183, 114, 237, 44, 80, 213, 69, 239, 33, 27, 95, 113, 116, 150, 169, 203, 208, 49, 84, 57, 29, 132, 148, 75, 131, 223, 59, 207, 147, 37, 91, 50, 190, 55, 204, 95, 113, 39, 201, 179, 191, 245, 184, 61, 146, 8, 47, 145, 224, 10, 240, 216, 97, 159, 135, 199, 201, 113, 50, 57, 45, 232, 72, 16, 138, 86, 166, 101, 64 },
                            RefreshTokenExpiryTime = new DateTime(2023, 12, 30, 21, 6, 54, 837, DateTimeKind.Utc).AddTicks(6866),
                            ResetPasswordExpiry = new DateTime(2023, 12, 30, 21, 6, 54, 837, DateTimeKind.Utc).AddTicks(6867),
                            Role = 2,
                            UpdatedOn = new DateTime(2023, 12, 30, 21, 6, 54, 837, DateTimeKind.Utc).AddTicks(6863)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
