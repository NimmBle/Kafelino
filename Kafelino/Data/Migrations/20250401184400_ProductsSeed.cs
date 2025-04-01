using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Kafelino.Data.Migrations
{
    /// <inheritdoc />
    public partial class ProductsSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c20d752f-fdbf-4dee-bf4d-a74884544984", "c20d752f-fdbf-4dee-bf4d-a74884544984", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "d11aca42-5c31-4970-b684-05e8ce5b35b0", 0, "e68ead61-da33-4a25-9fde-095045245e01", "admin@kafelino.com", true, "Иван", "Георгиев", false, null, "ADMIN@KAFELINO.COM", "ADMIN@KAFELINO.COM", "AQAAAAIAAYagAAAAEDjG8bxOXMOI1ilPmTrYMyW/eg9OSWxjAJccT3dxV75vW83jEJrGw9BZfOC9M120hQ==", null, false, "41383756-2375-4744-ba30-4dece30c6f96", false, "admin@kafelino.com" },
                    { "d39dfee2-14be-41ca-89a8-e9fe57869106", 0, "ad115563-f339-4457-8720-91b521795b05", "user@kafelino.com", true, "Михаил", "Филипов", false, null, "USER@KAFELINO.COM", "USER@KAFELINO.COM", "AQAAAAIAAYagAAAAEALnR82wxRUljSFH58sLk1YlrrGsNVDDc29igO13DfROsBbrp94/JBE/eyZP43uwqQ==", null, false, "e854f777-e0f5-4956-89d7-cdd31f08439f", false, "user@kafelino.com" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2025, 4, 1, 21, 43, 59, 297, DateTimeKind.Local).AddTicks(3631));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2025, 4, 1, 21, 43, 59, 297, DateTimeKind.Local).AddTicks(3700));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2025, 4, 1, 21, 43, 59, 297, DateTimeKind.Local).AddTicks(3702));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2025, 4, 1, 21, 43, 59, 297, DateTimeKind.Local).AddTicks(3704));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2025, 4, 1, 21, 43, 59, 297, DateTimeKind.Local).AddTicks(3706));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2025, 4, 1, 21, 43, 59, 297, DateTimeKind.Local).AddTicks(3708));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                columns: new[] { "Brand", "CreatedOn", "ImageUrl" },
                values: new object[] { "BUGs", new DateTime(2025, 4, 1, 21, 43, 59, 297, DateTimeKind.Local).AddTicks(3709), "product-7.webp" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                columns: new[] { "Brand", "CreatedOn", "ImageUrl" },
                values: new object[] { "BUGs", new DateTime(2025, 4, 1, 21, 43, 59, 297, DateTimeKind.Local).AddTicks(3711), "product-8.webp" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                columns: new[] { "Brand", "CreatedOn", "ImageUrl" },
                values: new object[] { "BUGs", new DateTime(2025, 4, 1, 21, 43, 59, 297, DateTimeKind.Local).AddTicks(3713), "product-9.webp" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                columns: new[] { "Brand", "CreatedOn", "ImageUrl" },
                values: new object[] { "BUGs", new DateTime(2025, 4, 1, 21, 43, 59, 297, DateTimeKind.Local).AddTicks(3715), "product-10.webp" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Brand", "CreatedOn", "Description", "ImageUrl", "IsDeleted", "Name", "Price", "Quantity", "WeightId" },
                values: new object[,]
                {
                    { 11, "BUGs", new DateTime(2025, 4, 1, 21, 43, 59, 297, DateTimeKind.Local).AddTicks(3716), "Едно от най-изисканите кафета в света – Панамската Гейша от региона Бокете е известна със своите интензивни флорални аромати, цитрусови нотки и копринена текстура. Сладостта и продължителният послевкус правят това кафе истинско удоволствие.", "product-11.webp", false, "Панама Бокете | Гейша", 30.00m, 105, 1 },
                    { 12, "Sparrows", new DateTime(2025, 4, 1, 21, 43, 59, 297, DateTimeKind.Local).AddTicks(3718), "Кафе от региона Гайо в Суматра, което предлага пикантни и земни нотки с намек за канела, тъмен шоколад и индийско орехче. Балансирано тяло и дълъг, сладък послевкус.", "product-12.webp", false, "Индонезия Суматра | Gayo", 22.50m, 95, 3 },
                    { 13, "Methodical", new DateTime(2025, 4, 1, 21, 43, 59, 297, DateTimeKind.Local).AddTicks(3720), "Класическо йеменско кафе с дълбок профил – нотки на тъмен шоколад, черен чай и сушени плодове. Истинско историческо кафе с автентичен вкус.", "product-13.webp", false, "Йемен Мокха Матари", 32.00m, 85, 2 },
                    { 14, "Huckleberry", new DateTime(2025, 4, 1, 21, 43, 59, 297, DateTimeKind.Local).AddTicks(3722), "Уникално кафе от планините на Уганда със сочен плодов профил и нотки на кайсия, шоколад и карамфил. Отличава се със свежа киселинност и кремообразно тяло.", "product-14.webp", false, "Уганда Бугису | SL14 & SL28", 23.50m, 115, 4 },
                    { 15, "Atomic", new DateTime(2025, 4, 1, 21, 43, 59, 297, DateTimeKind.Local).AddTicks(3724), "Отгледано в региона Маркала, това кафе предлага приятен баланс между сладост и киселинност, с нотки на мед, орех и млечен шоколад.", "product-15.webp", false, "Хондурас Маркала | Катуай", 21.50m, 100, 1 },
                    { 16, "KOMETA", new DateTime(2025, 4, 1, 21, 43, 59, 297, DateTimeKind.Local).AddTicks(3725), "Кафе от региона Серрадо в Бразилия със сладък и плътен профил. Вкусове на лешник, шоколад и карамел правят това кафе отличен избор за еспресо.", "product-16.webp", false, "Бразилия Серрадо | Бурбон", 19.00m, 110, 2 },
                    { 17, "KOMETA", new DateTime(2025, 4, 1, 21, 43, 59, 297, DateTimeKind.Local).AddTicks(3797), "Средно изпечено перуанско кафе със сладък и мек вкус. Нотки на тъмен шоколад, бадем и сладка череша. Подходящо за всички методи на приготвяне.", "product-17.webp", false, "Перу Сан Игнасио | Катуай", 23.00m, 90, 3 },
                    { 18, "KOMETA", new DateTime(2025, 4, 1, 21, 43, 59, 297, DateTimeKind.Local).AddTicks(3799), "Кафе от един от най-добрите райони в Коста Рика, отличаващо се с карамелена сладост, нотки на ванилия и цитрусово усещане. Перфектно за филтърно кафе.", "product-18.webp", false, "Коста Рика Тарразу | Катура", 24.50m, 120, 4 },
                    { 19, "KOMETA", new DateTime(2025, 4, 1, 21, 43, 59, 297, DateTimeKind.Local).AddTicks(3801), "Фина селекция от сорта Пакамаара, отличаваща се с плодова сладост и нотки на зелена ябълка, мед и лимон. Изключително комплексно и балансирано кафе.", "product-19.webp", false, "Ел Салвадор Санта Ана | Пакамаара", 26.00m, 80, 2 },
                    { 20, "KOMETA", new DateTime(2025, 4, 1, 21, 43, 59, 297, DateTimeKind.Local).AddTicks(3803), "Високопланинско кафе с богата киселинност и сложен ароматен профил. Нотки на кайсия, мед и черен чай го правят предпочитан избор за филтърно кафе.", "product-20.webp", false, "Колумбия Толуима | Кастийо", 25.00m, 75, 1 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "c20d752f-fdbf-4dee-bf4d-a74884544984", "d11aca42-5c31-4970-b684-05e8ce5b35b0" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c20d752f-fdbf-4dee-bf4d-a74884544984", "d11aca42-5c31-4970-b684-05e8ce5b35b0" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d39dfee2-14be-41ca-89a8-e9fe57869106");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c20d752f-fdbf-4dee-bf4d-a74884544984");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d11aca42-5c31-4970-b684-05e8ce5b35b0");

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
                column: "CreatedOn",
                value: new DateTime(2025, 4, 1, 11, 24, 26, 738, DateTimeKind.Local).AddTicks(6895));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2025, 4, 1, 11, 24, 26, 738, DateTimeKind.Local).AddTicks(6969));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2025, 4, 1, 11, 24, 26, 738, DateTimeKind.Local).AddTicks(6971));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2025, 4, 1, 11, 24, 26, 738, DateTimeKind.Local).AddTicks(6974));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2025, 4, 1, 11, 24, 26, 738, DateTimeKind.Local).AddTicks(6976));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2025, 4, 1, 11, 24, 26, 738, DateTimeKind.Local).AddTicks(6979));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                columns: new[] { "Brand", "CreatedOn", "ImageUrl" },
                values: new object[] { "KOMETA", new DateTime(2025, 4, 1, 11, 24, 26, 738, DateTimeKind.Local).AddTicks(6981), "https://kometa.coffee/wp-content/uploads/2024/03/guatemala-junacan-pacamara.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                columns: new[] { "Brand", "CreatedOn", "ImageUrl" },
                values: new object[] { "KOMETA", new DateTime(2025, 4, 1, 11, 24, 26, 738, DateTimeKind.Local).AddTicks(7054), "https://kometa.coffee/wp-content/uploads/2024/03/brazil-santos-natural.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                columns: new[] { "Brand", "CreatedOn", "ImageUrl" },
                values: new object[] { "KOMETA", new DateTime(2025, 4, 1, 11, 24, 26, 738, DateTimeKind.Local).AddTicks(7057), "https://kometa.coffee/wp-content/uploads/2024/03/ethiopia-sidamo-yirgacheffe.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                columns: new[] { "Brand", "CreatedOn", "ImageUrl" },
                values: new object[] { "KOMETA", new DateTime(2025, 4, 1, 11, 24, 26, 738, DateTimeKind.Local).AddTicks(7060), "https://kometa.coffee/wp-content/uploads/2024/03/rwanda-gaciziro-bourbon.jpg" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "3d06e014-d1c8-4a78-9004-42fac65b1e03", "5d770782-e4cd-41f3-8f16-a8eeff6af311" });
        }
    }
}
