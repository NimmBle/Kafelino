using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Kafelino.Data.Migrations
{
    /// <inheritdoc />
    public partial class СInitial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TasteNotes",
                columns: table => new
                {
                    TasteNoteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TasteNotes", x => x.TasteNoteId);
                });

            migrationBuilder.CreateTable(
                name: "Weights",
                columns: table => new
                {
                    WeightId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<int>(type: "int", nullable: false),
                    Unit = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weights", x => x.WeightId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TotalSum = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_Orders_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    WeightId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Products_Weights_WeightId",
                        column: x => x.WeightId,
                        principalTable: "Weights",
                        principalColumn: "WeightId",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateTable(
                name: "OrderProducts",
                columns: table => new
                {
                    OrderProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderProducts", x => x.OrderProductId);
                    table.ForeignKey(
                        name: "FK_OrderProducts_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderProducts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductTasteNotes",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    TasteNoteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTasteNotes", x => new { x.ProductId, x.TasteNoteId });
                    table.ForeignKey(
                        name: "FK_ProductTasteNotes_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductTasteNotes_TasteNotes_TasteNoteId",
                        column: x => x.TasteNoteId,
                        principalTable: "TasteNotes",
                        principalColumn: "TasteNoteId",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.InsertData(
                table: "TasteNotes",
                columns: new[] { "TasteNoteId", "Name" },
                values: new object[,]
                {
                    { 1, "Жасмин" },
                    { 2, "Папая" },
                    { 3, "Кафява захар" },
                    { 4, "Праскова" },
                    { 5, "Кокос" },
                    { 6, "Ванилия" },
                    { 7, "Боровинки" },
                    { 8, "Грозде" },
                    { 9, "Натурален шоколад" },
                    { 10, "Ягода" },
                    { 11, "Мед" },
                    { 12, "Червена ябълка" },
                    { 13, "Карамел" },
                    { 14, "Зряла череша" },
                    { 15, "Черен чай" },
                    { 16, "Касис" },
                    { 17, "Цитрусови плодове" },
                    { 18, "Какао" },
                    { 19, "Портокалова кора" },
                    { 20, "Шоколад" },
                    { 21, "Лешник" }
                });

            migrationBuilder.InsertData(
                table: "Weights",
                columns: new[] { "WeightId", "Unit", "Value" },
                values: new object[,]
                {
                    { 1, "г", 250 },
                    { 2, "г", 500 },
                    { 3, "кг", 1 },
                    { 4, "кг", 2 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "964f4b36-48aa-4630-9cd4-2df269f0592a", "2165c78b-8b5e-4fd2-b862-36d753465dfc" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Brand", "CreatedOn", "Description", "ImageUrl", "IsDeleted", "Name", "Price", "Quantity", "WeightId" },
                values: new object[,]
                {
                    { 1, "KOMETA", new DateTime(2025, 3, 19, 22, 2, 0, 808, DateTimeKind.Local).AddTicks(1461), "Тази изключителна партида Гейша идва от прочутата ферма Volcán Azul, която редовно се отличава като победител в конкурса Cup of Excellence Costa Rica. Обработена чрез натурален метод, тази партида разкрива елегантността и сложността, които правят Гейша толкова ценен сорт. Ароматът е фин и цветен, водещ към живи вкусове на жасмин и сочна папая. Ябълково-цитрусова киселинност придава свеж баланс, докато естествената сладост се запазва дълго, оставяйки изтънчен и продължителен вкус на кафява захар.", "https://kometa.coffee/wp-content/uploads/2024/03/vulkan-azul-geisha.jpg", false, "Вулкан Азул | Гейша", 26.00m, 95, 2 },
                    { 2, "KOMETA", new DateTime(2025, 3, 19, 22, 2, 0, 808, DateTimeKind.Local).AddTicks(1531), "Тази уникална партида е резултат от иновативния подход на Хайро Арсила, който използва плодова ферментация за обогатяване на вкусовия профил. Кафето впечатлява с нотки на праскова, кокос и ванилия, създавайки комплексен и запомнящ се вкус.", "https://kometa.coffee/wp-content/uploads/2024/03/jairo-arsila-fruit-fermentation.jpg", false, "Хайро Арсила | Плодова ферментация", 24.00m, 120, 4 },
                    { 3, "KOMETA", new DateTime(2025, 3, 19, 22, 2, 0, 808, DateTimeKind.Local).AddTicks(1533), "Отгледано в региона Уиля, Колумбия, това кафе от сорта Таби предлага богат вкус с изразени нотки на боровинки, грозде и натурален шоколад. Идеално за любителите на плодови и сладки профили.", "https://kometa.coffee/wp-content/uploads/2024/03/alonso-bustos-tabi.jpg", false, "Алонсо Бустос | Таби", 32.00m, 75, 3 },
                    { 4, "KOMETA", new DateTime(2025, 3, 19, 22, 2, 0, 808, DateTimeKind.Local).AddTicks(1535), "Тази партида от региона Гуджи в Етиопия се отличава с флорални аромати и вкусове на жасмин, праскова и карамел. Перфектен избор за тези, които търсят елегантно и балансирано кафе.", "https://kometa.coffee/wp-content/uploads/2024/03/hambela-guji-ethiopia.jpg", false, "Хамбела Гуджи, Етиопия", 28.00m, 105, 1 },
                    { 5, "KOMETA", new DateTime(2025, 3, 19, 22, 2, 0, 808, DateTimeKind.Local).AddTicks(1537), "Кафе от региона Матагалпа в Никарагуа, което впечатлява с плътно тяло и вкусови нотки на карамел, зряла череша и черен чай.", "https://kometa.coffee/wp-content/uploads/2024/03/finca-san-isidro-catuai.jpg", false, "Финка Сан Исидро | Катуай", 19.00m, 85, 4 },
                    { 6, "KOMETA", new DateTime(2025, 3, 19, 22, 2, 0, 808, DateTimeKind.Local).AddTicks(1539), "Традиционно кенийско кафе с интензивен аромат и вкусове на касис, цитрусови плодове и черен чай. Отличен избор за филтърно приготвяне.", "https://kometa.coffee/wp-content/uploads/2024/03/kenya-karimiru-sl28-sl34.jpg", false, "Кения Каримиру | SL28 & SL34", 28.00m, 95, 3 },
                    { 7, "KOMETA", new DateTime(2025, 3, 19, 22, 2, 0, 808, DateTimeKind.Local).AddTicks(1541), "Кафе от планините на Гватемала с комплексен профил и вкусове на какао, карамел и портокалова кора.", "https://kometa.coffee/wp-content/uploads/2024/03/guatemala-junacan-pacamara.jpg", false, "Гватемала Хунакан | Пакмара", 25.00m, 110, 2 },
                    { 8, "KOMETA", new DateTime(2025, 3, 19, 22, 2, 0, 808, DateTimeKind.Local).AddTicks(1543), "Традиционно бразилско кафе със сладък и балансиран вкус на шоколад, лешник и карамел. Перфектно за еспресо.", "https://kometa.coffee/wp-content/uploads/2024/03/brazil-santos-natural.jpg", false, "Бразилия Сантош | Натурален", 18.00m, 90, 1 },
                    { 9, "KOMETA", new DateTime(2025, 3, 19, 22, 2, 0, 808, DateTimeKind.Local).AddTicks(1545), "Легендарно кафе от региона Йиргачеф в Етиопия, което предлага флорални нотки, цитрусови плодове и медена сладост.", "https://kometa.coffee/wp-content/uploads/2024/03/ethiopia-sidamo-yirgacheffe.jpg", false, "Етиопия Сидамо | Yirgacheffe", 26.00m, 80, 3 },
                    { 10, "KOMETA", new DateTime(2025, 3, 19, 22, 2, 0, 808, DateTimeKind.Local).AddTicks(1547), "Плодово и сладко кафе с нотки на сушена слива, лешник и мед. Един от най-добрите примери за африканско кафе.", "https://kometa.coffee/wp-content/uploads/2024/03/rwanda-gaciziro-bourbon.jpg", false, "Руанда Гацизиро | Бърбън", 27.00m, 115, 4 },
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
                table: "ProductTasteNotes",
                columns: new[] { "ProductId", "TasteNoteId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 2, 4 },
                    { 2, 5 },
                    { 2, 6 },
                    { 3, 7 },
                    { 3, 8 },
                    { 3, 9 },
                    { 4, 1 },
                    { 4, 4 },
                    { 4, 13 },
                    { 5, 13 },
                    { 5, 14 },
                    { 5, 15 },
                    { 6, 15 },
                    { 6, 16 },
                    { 6, 17 },
                    { 7, 13 },
                    { 7, 18 },
                    { 7, 19 },
                    { 8, 13 },
                    { 8, 20 },
                    { 8, 21 },
                    { 9, 1 },
                    { 9, 11 },
                    { 9, 17 },
                    { 10, 11 },
                    { 10, 14 },
                    { 10, 21 },
                    { 11, 1 },
                    { 11, 11 },
                    { 11, 17 },
                    { 12, 3 },
                    { 12, 6 },
                    { 12, 20 },
                    { 13, 14 },
                    { 13, 15 },
                    { 13, 20 },
                    { 14, 3 },
                    { 14, 4 },
                    { 14, 20 },
                    { 15, 11 },
                    { 15, 20 },
                    { 15, 21 },
                    { 16, 13 },
                    { 16, 20 },
                    { 16, 21 },
                    { 17, 14 },
                    { 17, 20 },
                    { 17, 21 },
                    { 18, 6 },
                    { 18, 13 },
                    { 18, 19 },
                    { 19, 11 },
                    { 19, 12 },
                    { 19, 17 },
                    { 20, 4 },
                    { 20, 11 },
                    { 20, 15 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_UserId",
                table: "Carts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderProducts_OrderId",
                table: "OrderProducts",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderProducts_ProductId",
                table: "OrderProducts",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_WeightId",
                table: "Products",
                column: "WeightId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductTasteNotes_TasteNoteId",
                table: "ProductTasteNotes",
                column: "TasteNoteId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "OrderProducts");

            migrationBuilder.DropTable(
                name: "ProductTasteNotes");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "TasteNotes");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Weights");
        }
    }
}
