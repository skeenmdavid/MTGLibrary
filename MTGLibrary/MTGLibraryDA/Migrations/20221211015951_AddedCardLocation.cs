using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MTGLibraryDA.Migrations
{
    public partial class AddedCardLocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cards_Libraries_LibraryId",
                table: "Cards");

            migrationBuilder.AlterColumn<int>(
                name: "LibraryId",
                table: "Cards",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "Cards",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_Cards_Libraries_LibraryId",
                table: "Cards",
                column: "LibraryId",
                principalTable: "Libraries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cards_Libraries_LibraryId",
                table: "Cards");

            migrationBuilder.DropColumn(
                name: "Location",
                table: "Cards");

            migrationBuilder.AlterColumn<int>(
                name: "LibraryId",
                table: "Cards",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Cards_Libraries_LibraryId",
                table: "Cards",
                column: "LibraryId",
                principalTable: "Libraries",
                principalColumn: "Id");
        }
    }
}
