using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Kafelino.Data.Migrations
{
    /// <inheritdoc />
    public partial class multipleimages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4e20463a-91b5-44db-b0f8-6d4b8e6ffbe8", "fa7b8147-d0b4-4d59-b4a8-64b26a6fc0e1" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "97a12f0f-d3a8-45e2-91cc-1d02f0a57854");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4e20463a-91b5-44db-b0f8-6d4b8e6ffbe8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fa7b8147-d0b4-4d59-b4a8-64b26a6fc0e1");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6c5359bb-6895-4c10-ab69-0d8ffb1c7533", "6c5359bb-6895-4c10-ab69-0d8ffb1c7533", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "10ae77d6-689b-453e-9a4c-88c42af2088d", 0, "c6f10d62-2182-45e1-a566-ae59b544bdbd", "user@kafelino.com", true, "Михаил", "Филипов", false, null, "USER@KAFELINO.COM", "USER@KAFELINO.COM", "AQAAAAIAAYagAAAAEKDE9dVz6s6PtOAZ3Vx1trysCGaN+owIj26VWvxoC09zutkONKQj/SimxilySpMIJA==", null, false, "9e88afb0-92b4-4a2b-b752-dbdc91951429", false, "user@kafelino.com" },
                    { "b4a31b04-65ca-4672-8016-9601d069bf11", 0, "b512daaa-e2b5-417e-a7dc-fe2bfb5f3fde", "admin@kafelino.com", true, "Иван", "Георгиев", false, null, "ADMIN@KAFELINO.COM", "ADMIN@KAFELINO.COM", "AQAAAAIAAYagAAAAED8XzDQa7GR0D0RUPCuof/DRKYQaIe1QMqcsSKty6OiPP9X0p44QFtZ5VSWlPMHVoA==", null, false, "fdfddbb7-ea92-4da8-b0cc-0f53eab17e26", false, "admin@kafelino.com" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 30, 17, 55, 11, 940, DateTimeKind.Local).AddTicks(5310));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 30, 17, 55, 11, 940, DateTimeKind.Local).AddTicks(5471));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 30, 17, 55, 11, 940, DateTimeKind.Local).AddTicks(5507));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 30, 17, 55, 11, 940, DateTimeKind.Local).AddTicks(5519));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 30, 17, 55, 11, 940, DateTimeKind.Local).AddTicks(5727));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 30, 17, 55, 11, 940, DateTimeKind.Local).AddTicks(5741));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 30, 17, 55, 11, 940, DateTimeKind.Local).AddTicks(5752));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 30, 17, 55, 11, 940, DateTimeKind.Local).AddTicks(5761));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 30, 17, 55, 11, 940, DateTimeKind.Local).AddTicks(5768));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 30, 17, 55, 11, 940, DateTimeKind.Local).AddTicks(5775));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "6c5359bb-6895-4c10-ab69-0d8ffb1c7533", "b4a31b04-65ca-4672-8016-9601d069bf11" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6c5359bb-6895-4c10-ab69-0d8ffb1c7533", "b4a31b04-65ca-4672-8016-9601d069bf11" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10ae77d6-689b-453e-9a4c-88c42af2088d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6c5359bb-6895-4c10-ab69-0d8ffb1c7533");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b4a31b04-65ca-4672-8016-9601d069bf11");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4e20463a-91b5-44db-b0f8-6d4b8e6ffbe8", "4e20463a-91b5-44db-b0f8-6d4b8e6ffbe8", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "97a12f0f-d3a8-45e2-91cc-1d02f0a57854", 0, "fc0d34a2-deed-4137-8d63-ca198260755b", "user@kafelino.com", true, "Михаил", "Филипов", false, null, "USER@KAFELINO.COM", "USER@KAFELINO.COM", "AQAAAAIAAYagAAAAEA54qlsPWQFtbNCockjpxPNeGg31TAuhl80JZN8mijTNXmSDoBgFa/JZsa9Q/l90wQ==", null, false, "134835a9-ba0f-4f76-9d50-829eaa2229a0", false, "user@kafelino.com" },
                    { "fa7b8147-d0b4-4d59-b4a8-64b26a6fc0e1", 0, "37b1b2a0-d0d8-4424-a9e7-161ca55ae5b1", "admin@kafelino.com", true, "Иван", "Георгиев", false, null, "ADMIN@KAFELINO.COM", "ADMIN@KAFELINO.COM", "AQAAAAIAAYagAAAAEMFnngNw5E/Usd/AKKr6Oj0v+42wv7Yr3b817icSD6cvTmk1sYOk6RnegYGBiFgXoA==", null, false, "3711d093-bf76-4aae-a721-85adc49faf8c", false, "admin@kafelino.com" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 30, 17, 37, 42, 674, DateTimeKind.Local).AddTicks(1262));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 30, 17, 37, 42, 674, DateTimeKind.Local).AddTicks(1359));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 30, 17, 37, 42, 674, DateTimeKind.Local).AddTicks(1364));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 30, 17, 37, 42, 674, DateTimeKind.Local).AddTicks(1369));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 30, 17, 37, 42, 674, DateTimeKind.Local).AddTicks(1374));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 30, 17, 37, 42, 674, DateTimeKind.Local).AddTicks(1379));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 30, 17, 37, 42, 674, DateTimeKind.Local).AddTicks(1385));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 30, 17, 37, 42, 674, DateTimeKind.Local).AddTicks(1389));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 30, 17, 37, 42, 674, DateTimeKind.Local).AddTicks(1395));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 30, 17, 37, 42, 674, DateTimeKind.Local).AddTicks(1400));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "4e20463a-91b5-44db-b0f8-6d4b8e6ffbe8", "fa7b8147-d0b4-4d59-b4a8-64b26a6fc0e1" });
        }
    }
}
