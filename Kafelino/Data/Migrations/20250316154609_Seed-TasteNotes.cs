using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Kafelino.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedTasteNotes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "89a64002-1f35-4f08-b3f8-487858484b13", "4a47cb16-58ed-4264-92d9-15b192cd58c4" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "358243b9-a779-4c13-b5d6-11d1cf02f14f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "89a64002-1f35-4f08-b3f8-487858484b13");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4a47cb16-58ed-4264-92d9-15b192cd58c4");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8fb405a8-a209-4cdc-ade4-0b5f7759abf6", "8fb405a8-a209-4cdc-ade4-0b5f7759abf6", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "35b71e3f-3f1b-4df6-9107-6202cc375db2", 0, "3c645650-6fb6-49d7-aa00-ca67e8337660", "User", "admin@kafelino.com", true, "Иван", "Георгиев", false, null, "ADMIN@KAFELINO.COM", "ADMIN", "AQAAAAIAAYagAAAAEPtIDf85vQxaSjrvD15B5ipIbszPGjCwe4+umqBpnHZy2oEi50sSZq8PjCIrnChnYg==", null, false, "1de48e53-ec6e-4a1f-bb4a-66c47ed5c0ca", false, "admin" },
                    { "7c34f2c3-d123-4d87-82ca-b0b1878b1eef", 0, "a0963702-fd6f-4a39-ad11-c2da4fb0ebf9", "User", "user@kafelino.com", true, "Михаил", "Филипов", false, null, "USER@kafelino.COM", "USER", "AQAAAAIAAYagAAAAEP7s/YPQ9Q5LMcxgrGJ+m5D5Wj6UhHh2F5Jx905hLu6A+eUFo3mZc4yq0HcP7TyOhQ==", null, false, "97367c58-ae66-460e-abfa-39ce63834603", false, "user" }
                });

            migrationBuilder.InsertData(
                table: "TasteNotes",
                columns: new[] { "TasteNoteId", "Name" },
                values: new object[,]
                {
                    { 1, "Шоколад" },
                    { 2, "Карамел" },
                    { 3, "Ядки" },
                    { 4, "Цитрус" },
                    { 5, "Горски плодове" },
                    { 6, "Цветен" },
                    { 7, "Подправки" },
                    { 8, "Меласа" },
                    { 9, "Мед" },
                    { 10, "Ванилия" },
                    { 11, "Ябълка" },
                    { 12, "Костилкови плодове" },
                    { 13, "Кафява захар" },
                    { 14, "Грейпфрут" },
                    { 15, "Тофи" },
                    { 16, "Лешник" },
                    { 17, "Тропически плодове" },
                    { 18, "Канела" },
                    { 19, "Черен чай" },
                    { 20, "Тъмен шоколад" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "8fb405a8-a209-4cdc-ade4-0b5f7759abf6", "35b71e3f-3f1b-4df6-9107-6202cc375db2" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8fb405a8-a209-4cdc-ade4-0b5f7759abf6", "35b71e3f-3f1b-4df6-9107-6202cc375db2" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7c34f2c3-d123-4d87-82ca-b0b1878b1eef");

            migrationBuilder.DeleteData(
                table: "TasteNotes",
                keyColumn: "TasteNoteId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TasteNotes",
                keyColumn: "TasteNoteId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TasteNotes",
                keyColumn: "TasteNoteId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TasteNotes",
                keyColumn: "TasteNoteId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TasteNotes",
                keyColumn: "TasteNoteId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TasteNotes",
                keyColumn: "TasteNoteId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "TasteNotes",
                keyColumn: "TasteNoteId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "TasteNotes",
                keyColumn: "TasteNoteId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "TasteNotes",
                keyColumn: "TasteNoteId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "TasteNotes",
                keyColumn: "TasteNoteId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "TasteNotes",
                keyColumn: "TasteNoteId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "TasteNotes",
                keyColumn: "TasteNoteId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "TasteNotes",
                keyColumn: "TasteNoteId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "TasteNotes",
                keyColumn: "TasteNoteId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "TasteNotes",
                keyColumn: "TasteNoteId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "TasteNotes",
                keyColumn: "TasteNoteId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "TasteNotes",
                keyColumn: "TasteNoteId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "TasteNotes",
                keyColumn: "TasteNoteId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "TasteNotes",
                keyColumn: "TasteNoteId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "TasteNotes",
                keyColumn: "TasteNoteId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8fb405a8-a209-4cdc-ade4-0b5f7759abf6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "35b71e3f-3f1b-4df6-9107-6202cc375db2");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "89a64002-1f35-4f08-b3f8-487858484b13", "89a64002-1f35-4f08-b3f8-487858484b13", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "358243b9-a779-4c13-b5d6-11d1cf02f14f", 0, "ace55701-e0b2-4b97-8d51-ef8bd16d4166", "User", "user@kafelino.com", true, "Михаил", "Филипов", false, null, "USER@kafelino.COM", "USER", "AQAAAAIAAYagAAAAEHdgZN0KNWmPJyNLlbMn/WaMnyxD9zhLK6WimQzDeBJL3jeldYbYQSxC4lsj3kYD2w==", null, false, "c6046aa0-81d9-49a0-91a4-d85c014921f0", false, "user" },
                    { "4a47cb16-58ed-4264-92d9-15b192cd58c4", 0, "4517e443-f31f-4bd8-9ad4-09dfa4d986d9", "User", "admin@kafelino.com", true, "Иван", "Георгиев", false, null, "ADMIN@KAFELINO.COM", "ADMIN", "AQAAAAIAAYagAAAAENyI6p6ZQ4Cx4MLbjGlJzBG3m0XcyemYWX9wxxpigxpvxYZrz5QnHcrOd1pVt+ghdw==", null, false, "c9335c26-8d60-4f34-a358-c976ba8dc2e0", false, "admin" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "89a64002-1f35-4f08-b3f8-487858484b13", "4a47cb16-58ed-4264-92d9-15b192cd58c4" });
        }
    }
}
