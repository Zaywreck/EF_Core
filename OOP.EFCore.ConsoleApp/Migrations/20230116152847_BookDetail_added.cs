using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OOP.EFCore.ConsoleApp.Migrations
{
    /// <inheritdoc />
    public partial class BookDetailadded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Books",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 16, 18, 28, 47, 141, DateTimeKind.Local).AddTicks(8446),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 16, 18, 14, 9, 213, DateTimeKind.Local).AddTicks(4010));

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Books",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateTable(
                name: "BookDetail",
                columns: table => new
                {
                    BookDetailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookId = table.Column<int>(type: "int", nullable: false),
                    ISSN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Year = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookDetail", x => x.BookDetailId);
                    table.ForeignKey(
                        name: "FK_BookDetail_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_BookDetail_BookId",
                table: "BookDetail",
                column: "BookId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookDetail");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Books");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Books",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 16, 18, 14, 9, 213, DateTimeKind.Local).AddTicks(4010),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 16, 18, 28, 47, 141, DateTimeKind.Local).AddTicks(8446));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 16, 18, 14, 9, 213, DateTimeKind.Local).AddTicks(4010));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 16, 18, 14, 9, 213, DateTimeKind.Local).AddTicks(4010));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 16, 18, 14, 9, 213, DateTimeKind.Local).AddTicks(4010));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 16, 18, 14, 9, 213, DateTimeKind.Local).AddTicks(4010));
        }
    }
}
