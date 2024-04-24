using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddDefaultValues : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Country",
                columns: new[] { "Id", "Code", "CreatedDate", "Name", "UpdatedDate" },
                values: new object[] { new Guid("2757e51b-80f6-4aeb-86da-9369ccd9b8a1"), "TJ", new DateTime(2024, 4, 24, 12, 51, 58, 143, DateTimeKind.Utc).AddTicks(561), "Tajikistan", null });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "Id", "Code", "CountryId", "CreatedDate", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("30395d79-364f-4443-9ef7-a6f2b0dbf48f"), "DUS", new Guid("2757e51b-80f6-4aeb-86da-9369ccd9b8a1"), new DateTime(2024, 4, 24, 12, 51, 58, 142, DateTimeKind.Utc).AddTicks(9117), "Dushanbe", null },
                    { new Guid("4bdc5646-122f-425d-81b4-5a0e365366e8"), "KHU", new Guid("2757e51b-80f6-4aeb-86da-9369ccd9b8a1"), new DateTime(2024, 4, 24, 12, 51, 58, 142, DateTimeKind.Utc).AddTicks(9131), "Khujand", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: new Guid("30395d79-364f-4443-9ef7-a6f2b0dbf48f"));

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: new Guid("4bdc5646-122f-425d-81b4-5a0e365366e8"));

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: new Guid("2757e51b-80f6-4aeb-86da-9369ccd9b8a1"));
        }
    }
}
