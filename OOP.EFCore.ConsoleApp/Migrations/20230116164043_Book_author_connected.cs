using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OOP.EFCore.ConsoleApp.Migrations
{
    /// <inheritdoc />
    public partial class Bookauthorconnected : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuthorBook");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Books",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 16, 19, 40, 43, 755, DateTimeKind.Local).AddTicks(9379),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 16, 19, 29, 13, 937, DateTimeKind.Local).AddTicks(2553));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Authors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 16, 19, 40, 43, 756, DateTimeKind.Local).AddTicks(3351),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 16, 19, 29, 13, 938, DateTimeKind.Local).AddTicks(2295));

            migrationBuilder.CreateTable(
                name: "BookAuthors",
                columns: table => new
                {
                    BookAuthorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookId = table.Column<int>(type: "int", nullable: false),
                    AuthorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookAuthors", x => x.BookAuthorId);
                    table.ForeignKey(
                        name: "FK_BookAuthors_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "AuthorID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookAuthors_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 16, 19, 40, 43, 756, DateTimeKind.Local).AddTicks(3351));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 16, 19, 40, 43, 756, DateTimeKind.Local).AddTicks(3351));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 16, 19, 40, 43, 756, DateTimeKind.Local).AddTicks(3351));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 16, 19, 40, 43, 755, DateTimeKind.Local).AddTicks(9379));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 16, 19, 40, 43, 755, DateTimeKind.Local).AddTicks(9379));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 16, 19, 40, 43, 755, DateTimeKind.Local).AddTicks(9379));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 16, 19, 40, 43, 755, DateTimeKind.Local).AddTicks(9379));

            migrationBuilder.CreateIndex(
                name: "IX_BookAuthors_AuthorId",
                table: "BookAuthors",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_BookAuthors_BookId",
                table: "BookAuthors",
                column: "BookId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookAuthors");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Books",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 16, 19, 29, 13, 937, DateTimeKind.Local).AddTicks(2553),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 16, 19, 40, 43, 755, DateTimeKind.Local).AddTicks(9379));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Authors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 16, 19, 29, 13, 938, DateTimeKind.Local).AddTicks(2295),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 16, 19, 40, 43, 756, DateTimeKind.Local).AddTicks(3351));

            migrationBuilder.CreateTable(
                name: "AuthorBook",
                columns: table => new
                {
                    AuthorID = table.Column<int>(type: "int", nullable: false),
                    BooksBookId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuthorBook", x => new { x.AuthorID, x.BooksBookId });
                    table.ForeignKey(
                        name: "FK_AuthorBook_Authors_AuthorID",
                        column: x => x.AuthorID,
                        principalTable: "Authors",
                        principalColumn: "AuthorID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AuthorBook_Books_BooksBookId",
                        column: x => x.BooksBookId,
                        principalTable: "Books",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 16, 19, 29, 13, 938, DateTimeKind.Local).AddTicks(2295));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 16, 19, 29, 13, 938, DateTimeKind.Local).AddTicks(2295));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 16, 19, 29, 13, 938, DateTimeKind.Local).AddTicks(2295));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 16, 19, 29, 13, 937, DateTimeKind.Local).AddTicks(2553));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 16, 19, 29, 13, 937, DateTimeKind.Local).AddTicks(2553));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 16, 19, 29, 13, 937, DateTimeKind.Local).AddTicks(2553));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 16, 19, 29, 13, 937, DateTimeKind.Local).AddTicks(2553));

            migrationBuilder.CreateIndex(
                name: "IX_AuthorBook_BooksBookId",
                table: "AuthorBook",
                column: "BooksBookId");
        }
    }
}
