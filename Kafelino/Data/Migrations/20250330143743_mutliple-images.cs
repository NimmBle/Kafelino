using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Kafelino.Data.Migrations
{
    /// <inheritdoc />
    public partial class mutlipleimages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "964f4b36-48aa-4630-9cd4-2df269f0592a", "2165c78b-8b5e-4fd2-b862-36d753465dfc" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "351271dc-b3c0-472c-8634-9440336a328e");

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
                keyValue: "964f4b36-48aa-4630-9cd4-2df269f0592a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2165c78b-8b5e-4fd2-b862-36d753465dfc");

            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "Products",
                newName: "ImageUrls");

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
                columns: new[] { "CreatedOn", "ImageUrls" },
                values: new object[] { new DateTime(2025, 3, 30, 17, 37, 42, 674, DateTimeKind.Local).AddTicks(1262), "[\"product-1.webp\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ImageUrls" },
                values: new object[] { new DateTime(2025, 3, 30, 17, 37, 42, 674, DateTimeKind.Local).AddTicks(1359), "[\"product-2.webp\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ImageUrls" },
                values: new object[] { new DateTime(2025, 3, 30, 17, 37, 42, 674, DateTimeKind.Local).AddTicks(1364), "[\"product-3.webp\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "ImageUrls" },
                values: new object[] { new DateTime(2025, 3, 30, 17, 37, 42, 674, DateTimeKind.Local).AddTicks(1369), "[\"product-4.webp\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "ImageUrls" },
                values: new object[] { new DateTime(2025, 3, 30, 17, 37, 42, 674, DateTimeKind.Local).AddTicks(1374), "[\"product-5.webp\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                columns: new[] { "CreatedOn", "ImageUrls" },
                values: new object[] { new DateTime(2025, 3, 30, 17, 37, 42, 674, DateTimeKind.Local).AddTicks(1379), "[\"product-6.webp\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                columns: new[] { "CreatedOn", "ImageUrls" },
                values: new object[] { new DateTime(2025, 3, 30, 17, 37, 42, 674, DateTimeKind.Local).AddTicks(1385), "[\"https://kometa.coffee/wp-content/uploads/2024/03/guatemala-junacan-pacamara.jpg\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                columns: new[] { "CreatedOn", "ImageUrls" },
                values: new object[] { new DateTime(2025, 3, 30, 17, 37, 42, 674, DateTimeKind.Local).AddTicks(1389), "[\"https://kometa.coffee/wp-content/uploads/2024/03/brazil-santos-natural.jpg\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                columns: new[] { "CreatedOn", "ImageUrls" },
                values: new object[] { new DateTime(2025, 3, 30, 17, 37, 42, 674, DateTimeKind.Local).AddTicks(1395), "[\"https://kometa.coffee/wp-content/uploads/2024/03/ethiopia-sidamo-yirgacheffe.jpg\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                columns: new[] { "CreatedOn", "ImageUrls" },
                values: new object[] { new DateTime(2025, 3, 30, 17, 37, 42, 674, DateTimeKind.Local).AddTicks(1400), "[\"https://kometa.coffee/wp-content/uploads/2024/03/rwanda-gaciziro-bourbon.jpg\"]" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "4e20463a-91b5-44db-b0f8-6d4b8e6ffbe8", "fa7b8147-d0b4-4d59-b4a8-64b26a6fc0e1" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "ImageUrls",
                table: "Products",
                newName: "ImageUrl");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "964f4b36-48aa-4630-9cd4-2df269f0592a", "964f4b36-48aa-4630-9cd4-2df269f0592a", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "2165c78b-8b5e-4fd2-b862-36d753465dfc", 0, "6475fa08-3733-463d-84b7-3154642f630b", "admin@kafelino.com", true, "Иван", "Георгиев", false, null, "ADMIN@KAFELINO.COM", "ADMIN@KAFELINO.COM", "AQAAAAIAAYagAAAAEAPG0QM3unywwqwmdwEIqCO5TAK0QU88oMxc4A55+vCa+FlY6SVjf+Mx5kVIyvLyyg==", null, false, "47207b50-636d-418b-a14d-4c2538884af7", false, "admin@kafelino.com" },
                    { "351271dc-b3c0-472c-8634-9440336a328e", 0, "af9a4e67-ea30-4372-8649-82e3197eba5a", "user@kafelino.com", true, "Михаил", "Филипов", false, null, "USER@KAFELINO.COM", "USER@KAFELINO.COM", "AQAAAAIAAYagAAAAEKkOMXMtGeuuB76gIpS/WQWRQg3b3IBzF1DNAScxeoT3YraLOT84mcorJ8FYFoXJ0A==", null, false, "719c9f34-da9c-4fd5-87b2-392ee7d91ae3", false, "user@kafelino.com" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ImageUrl" },
                values: new object[] { new DateTime(2025, 3, 19, 22, 2, 0, 808, DateTimeKind.Local).AddTicks(1461), "https://kometa.coffee/wp-content/uploads/2024/03/vulkan-azul-geisha.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ImageUrl" },
                values: new object[] { new DateTime(2025, 3, 19, 22, 2, 0, 808, DateTimeKind.Local).AddTicks(1531), "https://kometa.coffee/wp-content/uploads/2024/03/jairo-arsila-fruit-fermentation.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ImageUrl" },
                values: new object[] { new DateTime(2025, 3, 19, 22, 2, 0, 808, DateTimeKind.Local).AddTicks(1533), "https://kometa.coffee/wp-content/uploads/2024/03/alonso-bustos-tabi.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "ImageUrl" },
                values: new object[] { new DateTime(2025, 3, 19, 22, 2, 0, 808, DateTimeKind.Local).AddTicks(1535), "https://kometa.coffee/wp-content/uploads/2024/03/hambela-guji-ethiopia.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "ImageUrl" },
                values: new object[] { new DateTime(2025, 3, 19, 22, 2, 0, 808, DateTimeKind.Local).AddTicks(1537), "https://kometa.coffee/wp-content/uploads/2024/03/finca-san-isidro-catuai.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                columns: new[] { "CreatedOn", "ImageUrl" },
                values: new object[] { new DateTime(2025, 3, 19, 22, 2, 0, 808, DateTimeKind.Local).AddTicks(1539), "https://kometa.coffee/wp-content/uploads/2024/03/kenya-karimiru-sl28-sl34.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                columns: new[] { "CreatedOn", "ImageUrl" },
                values: new object[] { new DateTime(2025, 3, 19, 22, 2, 0, 808, DateTimeKind.Local).AddTicks(1541), "https://kometa.coffee/wp-content/uploads/2024/03/guatemala-junacan-pacamara.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                columns: new[] { "CreatedOn", "ImageUrl" },
                values: new object[] { new DateTime(2025, 3, 19, 22, 2, 0, 808, DateTimeKind.Local).AddTicks(1543), "https://kometa.coffee/wp-content/uploads/2024/03/brazil-santos-natural.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                columns: new[] { "CreatedOn", "ImageUrl" },
                values: new object[] { new DateTime(2025, 3, 19, 22, 2, 0, 808, DateTimeKind.Local).AddTicks(1545), "https://kometa.coffee/wp-content/uploads/2024/03/ethiopia-sidamo-yirgacheffe.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                columns: new[] { "CreatedOn", "ImageUrl" },
                values: new object[] { new DateTime(2025, 3, 19, 22, 2, 0, 808, DateTimeKind.Local).AddTicks(1547), "https://kometa.coffee/wp-content/uploads/2024/03/rwanda-gaciziro-bourbon.jpg" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Brand", "CreatedOn", "Description", "ImageUrl", "IsDeleted", "Name", "Price", "Quantity", "WeightId" },
                values: new object[,]
                {
                    { 11, "KOMETA", new DateTime(2025, 3, 19, 22, 2, 0, 808, DateTimeKind.Local).AddTicks(1549), "Едно от най-изисканите кафета в света – Панамската Гейша от региона Бокете е известна със своите интензивни флорални аромати, цитрусови нотки и копринена текстура. Сладостта и продължителният послевкус правят това кафе истинско удоволствие.", "https://kometa.coffee/wp-content/uploads/2024/03/panama-boquete-geisha.jpg", false, "Панама Бокете | Гейша", 30.00m, 105, 1 },
                    { 12, "KOMETA", new DateTime(2025, 3, 19, 22, 2, 0, 808, DateTimeKind.Local).AddTicks(1551), "Кафе от региона Гайо в Суматра, което предлага пикантни и земни нотки с намек за канела, тъмен шоколад и индийско орехче. Балансирано тяло и дълъг, сладък послевкус.", "https://kometa.coffee/wp-content/uploads/2024/03/indonesia-sumatra-gayo.jpg", false, "Индонезия Суматра | Gayo", 22.50m, 95, 3 },
                    { 13, "KOMETA", new DateTime(2025, 3, 19, 22, 2, 0, 808, DateTimeKind.Local).AddTicks(1553), "Класическо йеменско кафе с дълбок профил – нотки на тъмен шоколад, черен чай и сушени плодове. Истинско историческо кафе с автентичен вкус.", "https://kometa.coffee/wp-content/uploads/2024/03/yemen-mokha-matari.jpg", false, "Йемен Мокха Матари", 32.00m, 85, 2 },
                    { 14, "KOMETA", new DateTime(2025, 3, 19, 22, 2, 0, 808, DateTimeKind.Local).AddTicks(1555), "Уникално кафе от планините на Уганда със сочен плодов профил и нотки на кайсия, шоколад и карамфил. Отличава се със свежа киселинност и кремообразно тяло.", "https://kometa.coffee/wp-content/uploads/2024/03/uganda-bugisu-sl14-sl28.jpg", false, "Уганда Бугису | SL14 & SL28", 23.50m, 115, 4 },
                    { 15, "KOMETA", new DateTime(2025, 3, 19, 22, 2, 0, 808, DateTimeKind.Local).AddTicks(1556), "Отгледано в региона Маркала, това кафе предлага приятен баланс между сладост и киселинност, с нотки на мед, орех и млечен шоколад.", "https://kometa.coffee/wp-content/uploads/2024/03/honduras-marcala-catuai.jpg", false, "Хондурас Маркала | Катуай", 21.50m, 100, 1 },
                    { 16, "KOMETA", new DateTime(2025, 3, 19, 22, 2, 0, 808, DateTimeKind.Local).AddTicks(1558), "Кафе от региона Серрадо в Бразилия със сладък и плътен профил. Вкусове на лешник, шоколад и карамел правят това кафе отличен избор за еспресо.", "https://kometa.coffee/wp-content/uploads/2024/03/brazil-cerrado-bourbon.jpg", false, "Бразилия Серрадо | Бурбон", 19.00m, 110, 2 },
                    { 17, "KOMETA", new DateTime(2025, 3, 19, 22, 2, 0, 808, DateTimeKind.Local).AddTicks(1560), "Средно изпечено перуанско кафе със сладък и мек вкус. Нотки на тъмен шоколад, бадем и сладка череша. Подходящо за всички методи на приготвяне.", "https://kometa.coffee/wp-content/uploads/2024/03/peru-san-ignacio-catuai.jpg", false, "Перу Сан Игнасио | Катуай", 23.00m, 90, 3 },
                    { 18, "KOMETA", new DateTime(2025, 3, 19, 22, 2, 0, 808, DateTimeKind.Local).AddTicks(1562), "Кафе от един от най-добрите райони в Коста Рика, отличаващо се с карамелена сладост, нотки на ванилия и цитрусово усещане. Перфектно за филтърно кафе.", "https://kometa.coffee/wp-content/uploads/2024/03/costa-rica-tarrazu-caturra.jpg", false, "Коста Рика Тарразу | Катура", 24.50m, 120, 4 },
                    { 19, "KOMETA", new DateTime(2025, 3, 19, 22, 2, 0, 808, DateTimeKind.Local).AddTicks(1564), "Фина селекция от сорта Пакамаара, отличаваща се с плодова сладост и нотки на зелена ябълка, мед и лимон. Изключително комплексно и балансирано кафе.", "https://kometa.coffee/wp-content/uploads/2024/03/el-salvador-santa-ana-pacamara.jpg", false, "Ел Салвадор Санта Ана | Пакамаара", 26.00m, 80, 2 },
                    { 20, "KOMETA", new DateTime(2025, 3, 19, 22, 2, 0, 808, DateTimeKind.Local).AddTicks(1566), "Високопланинско кафе с богата киселинност и сложен ароматен профил. Нотки на кайсия, мед и черен чай го правят предпочитан избор за филтърно кафе.", "https://kometa.coffee/wp-content/uploads/2024/03/colombia-tolima-castillo.jpg", false, "Колумбия Толуима | Кастийо", 25.00m, 75, 1 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "964f4b36-48aa-4630-9cd4-2df269f0592a", "2165c78b-8b5e-4fd2-b862-36d753465dfc" });
        }
    }
}
