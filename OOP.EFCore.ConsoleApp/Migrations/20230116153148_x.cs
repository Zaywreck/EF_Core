using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OOP.EFCore.ConsoleApp.Migrations
{
    /// <inheritdoc />
    public partial class x : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Books",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Books",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 16, 18, 31, 48, 604, DateTimeKind.Local).AddTicks(2846),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 16, 18, 28, 47, 141, DateTimeKind.Local).AddTicks(8446));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2023, 1, 16, 18, 31, 48, 604, DateTimeKind.Local).AddTicks(2846), 40m });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2023, 1, 16, 18, 31, 48, 604, DateTimeKind.Local).AddTicks(2846), 50m });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2023, 1, 16, 18, 31, 48, 604, DateTimeKind.Local).AddTicks(2846), 60m });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2023, 1, 16, 18, 31, 48, 604, DateTimeKind.Local).AddTicks(2846), 20m });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Books",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldDefaultValue: 0m);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Books",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 16, 18, 28, 47, 141, DateTimeKind.Local).AddTicks(8446),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 16, 18, 31, 48, 604, DateTimeKind.Local).AddTicks(2846));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2023, 1, 16, 18, 28, 47, 141, DateTimeKind.Local).AddTicks(8446), 0m });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2023, 1, 16, 18, 28, 47, 141, DateTimeKind.Local).AddTicks(8446), 0m });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2023, 1, 16, 18, 28, 47, 141, DateTimeKind.Local).AddTicks(8446), 0m });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2023, 1, 16, 18, 28, 47, 141, DateTimeKind.Local).AddTicks(8446), 0m });
        }
    }
}
