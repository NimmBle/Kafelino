using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Kafelino.Data.Migrations
{
    /// <inheritdoc />
    public partial class IsDeletedCreateOn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bda0854d-80d0-4b43-9dcc-64a59a3a64e0", "41884d04-bd20-498a-be5b-b77e7a88f29f" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4a71c09f-7dc4-48e5-a708-85164834b9bb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bda0854d-80d0-4b43-9dcc-64a59a3a64e0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41884d04-bd20-498a-be5b-b77e7a88f29f");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Products");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bda0854d-80d0-4b43-9dcc-64a59a3a64e0", "bda0854d-80d0-4b43-9dcc-64a59a3a64e0", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "41884d04-bd20-498a-be5b-b77e7a88f29f", 0, "1063020a-d03f-4ba6-9433-7b5101b56fbf", "User", "admin@kafelino.com", true, "Иван", "Георгиев", false, null, "ADMIN@KAFELINO.COM", "ADMIN", "AQAAAAIAAYagAAAAEEHR/5KyCzKUDqdysIOcIdjroYjeWm3cTZC6mSx0sf1hgDV5ASlcTKdBul2WxV75Mg==", null, false, "268c3494-fb1f-4dfe-aeb8-7a184b0d0b50", false, "admin" },
                    { "4a71c09f-7dc4-48e5-a708-85164834b9bb", 0, "2da23a25-eda1-41c7-9728-58791af09bef", "User", "user@kafelino.com", true, "Михаил", "Филипов", false, null, "USER@kafelino.COM", "USER", "AQAAAAIAAYagAAAAEOVd/IoL40Ql1nAp2D9E1Q2BSud+tc5frXnYwL3gQXsuVihH2Nj+yZDpL03XOpU40w==", null, false, "991222a5-8b55-4b1e-8d4b-6285a23e17fa", false, "user" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "bda0854d-80d0-4b43-9dcc-64a59a3a64e0", "41884d04-bd20-498a-be5b-b77e7a88f29f" });
        }
    }
}
