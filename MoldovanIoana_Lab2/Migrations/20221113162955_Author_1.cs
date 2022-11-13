using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MoldovanIoana_Lab2.Migrations
{
    public partial class Author_1 : Migration
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
                newName: "Author_1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Author_1",
                table: "Author_1",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Author_1_AuthorID",
                table: "Book",
                column: "AuthorID",
                principalTable: "Author_1",
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
                table: "Author_1");

            migrationBuilder.RenameTable(
                name: "Author_1",
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
