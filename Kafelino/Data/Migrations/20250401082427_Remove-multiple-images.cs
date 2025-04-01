using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Kafelino.Data.Migrations
{
    /// <inheritdoc />
    public partial class Removemultipleimages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "ImageUrls",
                table: "Products",
                newName: "ImageUrl");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3d06e014-d1c8-4a78-9004-42fac65b1e03", "3d06e014-d1c8-4a78-9004-42fac65b1e03", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1b2af6e2-6377-452d-9f27-462adc2e2e79", 0, "5673a99e-c7a6-4f73-8c1b-850a060e414c", "user@kafelino.com", true, "Михаил", "Филипов", false, null, "USER@KAFELINO.COM", "USER@KAFELINO.COM", "AQAAAAIAAYagAAAAEDzNscdbTxsEDlCJAPCJnMUx+PFI1Al3mF1p1LOVooZWj7QaWIs9ceJU31oeUJ6ndg==", null, false, "3efedbf7-ef04-4905-8ee5-a45ac1b45cf9", false, "user@kafelino.com" },
                    { "5d770782-e4cd-41f3-8f16-a8eeff6af311", 0, "0d72e88d-cabd-45cd-be86-7e7cf001a675", "admin@kafelino.com", true, "Иван", "Георгиев", false, null, "ADMIN@KAFELINO.COM", "ADMIN@KAFELINO.COM", "AQAAAAIAAYagAAAAEIjJdETBhx5rV1AOjxkveK51zWgHBHTwF6zdu3dtpF8cx1iw/CYocZ30dXrJga+JEQ==", null, false, "07672caa-5d00-4fba-a47e-3d227b5825ab", false, "admin@kafelino.com" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ImageUrl" },
                values: new object[] { new DateTime(2025, 4, 1, 11, 24, 26, 738, DateTimeKind.Local).AddTicks(6895), "product-1.webp" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ImageUrl" },
                values: new object[] { new DateTime(2025, 4, 1, 11, 24, 26, 738, DateTimeKind.Local).AddTicks(6969), "product-2.webp" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ImageUrl" },
                values: new object[] { new DateTime(2025, 4, 1, 11, 24, 26, 738, DateTimeKind.Local).AddTicks(6971), "product-3.webp" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "ImageUrl" },
                values: new object[] { new DateTime(2025, 4, 1, 11, 24, 26, 738, DateTimeKind.Local).AddTicks(6974), "product-4.webp" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "ImageUrl" },
                values: new object[] { new DateTime(2025, 4, 1, 11, 24, 26, 738, DateTimeKind.Local).AddTicks(6976), "product-5.webp" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                columns: new[] { "CreatedOn", "ImageUrl" },
                values: new object[] { new DateTime(2025, 4, 1, 11, 24, 26, 738, DateTimeKind.Local).AddTicks(6979), "product-6.webp" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                columns: new[] { "CreatedOn", "ImageUrl" },
                values: new object[] { new DateTime(2025, 4, 1, 11, 24, 26, 738, DateTimeKind.Local).AddTicks(6981), "https://kometa.coffee/wp-content/uploads/2024/03/guatemala-junacan-pacamara.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                columns: new[] { "CreatedOn", "ImageUrl" },
                values: new object[] { new DateTime(2025, 4, 1, 11, 24, 26, 738, DateTimeKind.Local).AddTicks(7054), "https://kometa.coffee/wp-content/uploads/2024/03/brazil-santos-natural.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                columns: new[] { "CreatedOn", "ImageUrl" },
                values: new object[] { new DateTime(2025, 4, 1, 11, 24, 26, 738, DateTimeKind.Local).AddTicks(7057), "https://kometa.coffee/wp-content/uploads/2024/03/ethiopia-sidamo-yirgacheffe.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                columns: new[] { "CreatedOn", "ImageUrl" },
                values: new object[] { new DateTime(2025, 4, 1, 11, 24, 26, 738, DateTimeKind.Local).AddTicks(7060), "https://kometa.coffee/wp-content/uploads/2024/03/rwanda-gaciziro-bourbon.jpg" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "3d06e014-d1c8-4a78-9004-42fac65b1e03", "5d770782-e4cd-41f3-8f16-a8eeff6af311" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3d06e014-d1c8-4a78-9004-42fac65b1e03", "5d770782-e4cd-41f3-8f16-a8eeff6af311" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1b2af6e2-6377-452d-9f27-462adc2e2e79");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d06e014-d1c8-4a78-9004-42fac65b1e03");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5d770782-e4cd-41f3-8f16-a8eeff6af311");

            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "Products",
                newName: "ImageUrls");

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
                columns: new[] { "CreatedOn", "ImageUrls" },
                values: new object[] { new DateTime(2025, 3, 30, 17, 55, 11, 940, DateTimeKind.Local).AddTicks(5310), "[\"product-1.webp\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ImageUrls" },
                values: new object[] { new DateTime(2025, 3, 30, 17, 55, 11, 940, DateTimeKind.Local).AddTicks(5471), "[\"product-2.webp\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ImageUrls" },
                values: new object[] { new DateTime(2025, 3, 30, 17, 55, 11, 940, DateTimeKind.Local).AddTicks(5507), "[\"product-3.webp\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "ImageUrls" },
                values: new object[] { new DateTime(2025, 3, 30, 17, 55, 11, 940, DateTimeKind.Local).AddTicks(5519), "[\"product-4.webp\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "ImageUrls" },
                values: new object[] { new DateTime(2025, 3, 30, 17, 55, 11, 940, DateTimeKind.Local).AddTicks(5727), "[\"product-5.webp\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                columns: new[] { "CreatedOn", "ImageUrls" },
                values: new object[] { new DateTime(2025, 3, 30, 17, 55, 11, 940, DateTimeKind.Local).AddTicks(5741), "[\"product-6.webp\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                columns: new[] { "CreatedOn", "ImageUrls" },
                values: new object[] { new DateTime(2025, 3, 30, 17, 55, 11, 940, DateTimeKind.Local).AddTicks(5752), "[\"https://kometa.coffee/wp-content/uploads/2024/03/guatemala-junacan-pacamara.jpg\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                columns: new[] { "CreatedOn", "ImageUrls" },
                values: new object[] { new DateTime(2025, 3, 30, 17, 55, 11, 940, DateTimeKind.Local).AddTicks(5761), "[\"https://kometa.coffee/wp-content/uploads/2024/03/brazil-santos-natural.jpg\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                columns: new[] { "CreatedOn", "ImageUrls" },
                values: new object[] { new DateTime(2025, 3, 30, 17, 55, 11, 940, DateTimeKind.Local).AddTicks(5768), "[\"https://kometa.coffee/wp-content/uploads/2024/03/ethiopia-sidamo-yirgacheffe.jpg\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                columns: new[] { "CreatedOn", "ImageUrls" },
                values: new object[] { new DateTime(2025, 3, 30, 17, 55, 11, 940, DateTimeKind.Local).AddTicks(5775), "[\"https://kometa.coffee/wp-content/uploads/2024/03/rwanda-gaciziro-bourbon.jpg\"]" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "6c5359bb-6895-4c10-ab69-0d8ffb1c7533", "b4a31b04-65ca-4672-8016-9601d069bf11" });
        }
    }
}
