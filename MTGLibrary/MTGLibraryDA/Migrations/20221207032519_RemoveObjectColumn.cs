using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MTGLibraryDA.Migrations
{
    public partial class RemoveObjectColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "_object",
                table: "Cards");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "_object",
                table: "Cards",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
