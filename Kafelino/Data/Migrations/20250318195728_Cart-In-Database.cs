using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Kafelino.Data.Migrations
{
    /// <inheritdoc />
    public partial class CartInDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3955f00f-c0ab-4ad4-83e8-f536fca1b19d", "8a6e481c-85b1-4dde-b450-1ff5eeb95669" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9061f60d-c9ad-475f-a206-160064b3dd92");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3955f00f-c0ab-4ad4-83e8-f536fca1b19d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8a6e481c-85b1-4dde-b450-1ff5eeb95669");

            migrationBuilder.DropColumn(
                name: "Cart",
                table: "AspNetUsers");

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => new { x.ProductId, x.UserId });
                    table.ForeignKey(
                        name: "FK_Carts_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Carts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0b8f9c7c-ae9b-4e6a-84e4-e6abe3160f9c", "0b8f9c7c-ae9b-4e6a-84e4-e6abe3160f9c", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "3541c71b-d183-4a10-af0c-3afa1d1f36fe", 0, "a8c8b739-2dc6-4562-b125-dad05078e0f7", "admin@kafelino.com", true, "Иван", "Георгиев", false, null, "ADMIN@KAFELINO.COM", "ADMIN@KAFELINO.COM", "AQAAAAIAAYagAAAAEC8ti784m45H+indN6PnFE9sCK/wJ2Aaq+tSVJaw+s9i56uR0tWtpU9pg61fWl/E1g==", null, false, "ae531f15-f63d-4437-94d1-2a6bbe2fdf67", false, "admin@kafelino.com" },
                    { "47245f81-aade-468e-a113-1caeea6795d5", 0, "51284b28-c0a9-4951-abcd-c67874ff61d8", "user@kafelino.com", true, "Михаил", "Филипов", false, null, "USER@KAFELINO.COM", "USER@KAFELINO.COM", "AQAAAAIAAYagAAAAEI8awGEG2JUYYsSsOLtbbDyR06rlLaTuuX/0SUXrGTQ+00PEJ+9URy+dK4Yru38ZFQ==", null, false, "655f0137-6093-489d-90a4-2b7c12929adb", false, "user@kafelino.com" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 18, 21, 57, 27, 607, DateTimeKind.Local).AddTicks(1554));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 18, 21, 57, 27, 607, DateTimeKind.Local).AddTicks(1688));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 18, 21, 57, 27, 607, DateTimeKind.Local).AddTicks(1690));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 18, 21, 57, 27, 607, DateTimeKind.Local).AddTicks(1692));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 18, 21, 57, 27, 607, DateTimeKind.Local).AddTicks(1695));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 18, 21, 57, 27, 607, DateTimeKind.Local).AddTicks(1699));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 18, 21, 57, 27, 607, DateTimeKind.Local).AddTicks(1702));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 18, 21, 57, 27, 607, DateTimeKind.Local).AddTicks(1706));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 18, 21, 57, 27, 607, DateTimeKind.Local).AddTicks(1708));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 18, 21, 57, 27, 607, DateTimeKind.Local).AddTicks(1711));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 18, 21, 57, 27, 607, DateTimeKind.Local).AddTicks(1713));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 18, 21, 57, 27, 607, DateTimeKind.Local).AddTicks(1750));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 18, 21, 57, 27, 607, DateTimeKind.Local).AddTicks(1753));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 18, 21, 57, 27, 607, DateTimeKind.Local).AddTicks(1757));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 18, 21, 57, 27, 607, DateTimeKind.Local).AddTicks(1759));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 18, 21, 57, 27, 607, DateTimeKind.Local).AddTicks(1763));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 17,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 18, 21, 57, 27, 607, DateTimeKind.Local).AddTicks(1765));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 18,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 18, 21, 57, 27, 607, DateTimeKind.Local).AddTicks(1768));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 19,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 18, 21, 57, 27, 607, DateTimeKind.Local).AddTicks(1770));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 20,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 18, 21, 57, 27, 607, DateTimeKind.Local).AddTicks(1773));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "0b8f9c7c-ae9b-4e6a-84e4-e6abe3160f9c", "3541c71b-d183-4a10-af0c-3afa1d1f36fe" });

            migrationBuilder.CreateIndex(
                name: "IX_Carts_UserId",
                table: "Carts",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0b8f9c7c-ae9b-4e6a-84e4-e6abe3160f9c", "3541c71b-d183-4a10-af0c-3afa1d1f36fe" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "47245f81-aade-468e-a113-1caeea6795d5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0b8f9c7c-ae9b-4e6a-84e4-e6abe3160f9c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3541c71b-d183-4a10-af0c-3afa1d1f36fe");

            migrationBuilder.AddColumn<string>(
                name: "Cart",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3955f00f-c0ab-4ad4-83e8-f536fca1b19d", "3955f00f-c0ab-4ad4-83e8-f536fca1b19d", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Cart", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "8a6e481c-85b1-4dde-b450-1ff5eeb95669", 0, "", "eef942f7-edc0-44f4-99c5-08bb14d2eb6c", "admin@kafelino.com", true, "Иван", "Георгиев", false, null, "ADMIN@KAFELINO.COM", "ADMIN@KAFELINO.COM", "AQAAAAIAAYagAAAAEM9mhIaF/+ITlTGh9vOhxcJkLP49kt2SUN4Gr4Wl5/ddrZ2KEqvimrXjCRzbd2x00w==", null, false, "077a4bfc-54aa-41ef-a8fa-e956b6b1d9fe", false, "admin@kafelino.com" },
                    { "9061f60d-c9ad-475f-a206-160064b3dd92", 0, "", "15ea516e-b974-46eb-abfa-a8982558d384", "user@kafelino.com", true, "Михаил", "Филипов", false, null, "USER@KAFELINO.COM", "USER@KAFELINO.COM", "AQAAAAIAAYagAAAAEIQ4bLN0CkjfzBvhUNn9TglPV1QG1HflyxrIxgdcQo20qCa3u23r5QHscIcUBmsS9w==", null, false, "4d36a84b-0205-484a-98d0-a01581176cd8", false, "user@kafelino.com" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 18, 13, 8, 26, 368, DateTimeKind.Local).AddTicks(8972));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 18, 13, 8, 26, 368, DateTimeKind.Local).AddTicks(9046));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 18, 13, 8, 26, 368, DateTimeKind.Local).AddTicks(9050));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 18, 13, 8, 26, 368, DateTimeKind.Local).AddTicks(9063));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 18, 13, 8, 26, 368, DateTimeKind.Local).AddTicks(9068));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 18, 13, 8, 26, 368, DateTimeKind.Local).AddTicks(9071));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 18, 13, 8, 26, 368, DateTimeKind.Local).AddTicks(9078));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 18, 13, 8, 26, 368, DateTimeKind.Local).AddTicks(9081));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 18, 13, 8, 26, 368, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 18, 13, 8, 26, 368, DateTimeKind.Local).AddTicks(9097));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 18, 13, 8, 26, 368, DateTimeKind.Local).AddTicks(9102));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 18, 13, 8, 26, 368, DateTimeKind.Local).AddTicks(9106));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 18, 13, 8, 26, 368, DateTimeKind.Local).AddTicks(9110));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 18, 13, 8, 26, 368, DateTimeKind.Local).AddTicks(9114));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 18, 13, 8, 26, 368, DateTimeKind.Local).AddTicks(9118));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 18, 13, 8, 26, 368, DateTimeKind.Local).AddTicks(9134));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 17,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 18, 13, 8, 26, 368, DateTimeKind.Local).AddTicks(9201));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 18,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 18, 13, 8, 26, 368, DateTimeKind.Local).AddTicks(9207));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 19,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 18, 13, 8, 26, 368, DateTimeKind.Local).AddTicks(9210));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 20,
                column: "CreatedOn",
                value: new DateTime(2025, 3, 18, 13, 8, 26, 368, DateTimeKind.Local).AddTicks(9214));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "3955f00f-c0ab-4ad4-83e8-f536fca1b19d", "8a6e481c-85b1-4dde-b450-1ff5eeb95669" });
        }
    }
}
