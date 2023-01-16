using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OOP.EFCore.ConsoleApp.Migrations
{
    /// <inheritdoc />
    public partial class Authoradded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookDetail_Books_BookId",
                table: "BookDetail");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BookDetail",
                table: "BookDetail");

            migrationBuilder.RenameTable(
                name: "BookDetail",
                newName: "BooksDetail");

            migrationBuilder.RenameIndex(
                name: "IX_BookDetail_BookId",
                table: "BooksDetail",
                newName: "IX_BooksDetail_BookId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Books",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 16, 19, 29, 13, 937, DateTimeKind.Local).AddTicks(2553),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 16, 18, 58, 27, 385, DateTimeKind.Local).AddTicks(4994));

            migrationBuilder.AddPrimaryKey(
                name: "PK_BooksDetail",
                table: "BooksDetail",
                column: "BookDetailId");

            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    AuthorID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 1, 16, 19, 29, 13, 938, DateTimeKind.Local).AddTicks(2295))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.AuthorID);
                });

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

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "AuthorID", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "Mert", "Gülle" },
                    { 2, "Sena Nur", "Gülle" },
                    { 3, "Bora Han", "Gülle" }
                });

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

            migrationBuilder.AddForeignKey(
                name: "FK_BooksDetail_Books_BookId",
                table: "BooksDetail",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "BookId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BooksDetail_Books_BookId",
                table: "BooksDetail");

            migrationBuilder.DropTable(
                name: "AuthorBook");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BooksDetail",
                table: "BooksDetail");

            migrationBuilder.RenameTable(
                name: "BooksDetail",
                newName: "BookDetail");

            migrationBuilder.RenameIndex(
                name: "IX_BooksDetail_BookId",
                table: "BookDetail",
                newName: "IX_BookDetail_BookId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Books",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 16, 18, 58, 27, 385, DateTimeKind.Local).AddTicks(4994),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 16, 19, 29, 13, 937, DateTimeKind.Local).AddTicks(2553));

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookDetail",
                table: "BookDetail",
                column: "BookDetailId");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 16, 18, 58, 27, 385, DateTimeKind.Local).AddTicks(4994));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 16, 18, 58, 27, 385, DateTimeKind.Local).AddTicks(4994));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 16, 18, 58, 27, 385, DateTimeKind.Local).AddTicks(4994));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 16, 18, 58, 27, 385, DateTimeKind.Local).AddTicks(4994));

            migrationBuilder.AddForeignKey(
                name: "FK_BookDetail_Books_BookId",
                table: "BookDetail",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "BookId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
