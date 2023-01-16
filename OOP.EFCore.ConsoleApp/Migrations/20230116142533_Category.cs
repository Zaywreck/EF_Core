using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OOP.EFCore.ConsoleApp.Migrations
{
    /// <inheritdoc />
    public partial class Category : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Books",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 16, 17, 25, 33, 605, DateTimeKind.Local).AddTicks(7820),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 14, 22, 15, 49, 225, DateTimeKind.Local).AddTicks(5500));

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false, defaultValue: "")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 16, 17, 25, 33, 605, DateTimeKind.Local).AddTicks(7820));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 16, 17, 25, 33, 605, DateTimeKind.Local).AddTicks(7820));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 16, 17, 25, 33, 605, DateTimeKind.Local).AddTicks(7820));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 16, 17, 25, 33, 605, DateTimeKind.Local).AddTicks(7820));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[,]
                {
                    { 1, "Sağlık" },
                    { 2, "Siyaset" },
                    { 3, "Şiir" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Books",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 14, 22, 15, 49, 225, DateTimeKind.Local).AddTicks(5500),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 16, 17, 25, 33, 605, DateTimeKind.Local).AddTicks(7820));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 14, 22, 15, 49, 225, DateTimeKind.Local).AddTicks(5500));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 14, 22, 15, 49, 225, DateTimeKind.Local).AddTicks(5500));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 14, 22, 15, 49, 225, DateTimeKind.Local).AddTicks(5500));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 14, 22, 15, 49, 225, DateTimeKind.Local).AddTicks(5500));
        }
    }
}
