using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MoldovanIoana_Lab2.Migrations
{
    public partial class Author : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Book_Author_AuthorID",
                table: "Book");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Author",
                table: "Author");

            migrationBuilder.RenameTable(
                name: "Author",
                newName: "Author");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Author_1",
                table: "Author",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Author_1_AuthorID",
                table: "Book",
                column: "AuthorID",
                principalTable: "Author",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Book_Author_1_AuthorID",
                table: "Book");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Author_1",
                table: "Author");

            migrationBuilder.RenameTable(
                name: "Author",
                newName: "Author");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Author",
                table: "Author",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Author_AuthorID",
                table: "Book",
                column: "AuthorID",
                principalTable: "Author",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
