using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MTGLibraryDA.Migrations
{
    public partial class UpdateContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ScryfallCards_Library_LibraryId",
                table: "ScryfallCards");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Library",
                table: "Library");

            migrationBuilder.RenameTable(
                name: "Library",
                newName: "Libraries");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Libraries",
                table: "Libraries",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ScryfallCards_Libraries_LibraryId",
                table: "ScryfallCards",
                column: "LibraryId",
                principalTable: "Libraries",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ScryfallCards_Libraries_LibraryId",
                table: "ScryfallCards");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Libraries",
                table: "Libraries");

            migrationBuilder.RenameTable(
                name: "Libraries",
                newName: "Library");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Library",
                table: "Library",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ScryfallCards_Library_LibraryId",
                table: "ScryfallCards",
                column: "LibraryId",
                principalTable: "Library",
                principalColumn: "Id");
        }
    }
}
