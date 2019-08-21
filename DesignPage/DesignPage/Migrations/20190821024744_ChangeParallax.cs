using Microsoft.EntityFrameworkCore.Migrations;

namespace DesignPage.Migrations
{
    public partial class ChangeParallax : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rule",
                table: "Parallaxes");

            migrationBuilder.RenameColumn(
                name: "Num",
                table: "Parallaxes",
                newName: "Start");

            migrationBuilder.AddColumn<int>(
                name: "End",
                table: "Parallaxes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Set",
                table: "Parallaxes",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "End",
                table: "Parallaxes");

            migrationBuilder.DropColumn(
                name: "Set",
                table: "Parallaxes");

            migrationBuilder.RenameColumn(
                name: "Start",
                table: "Parallaxes",
                newName: "Num");

            migrationBuilder.AddColumn<string>(
                name: "Rule",
                table: "Parallaxes",
                maxLength: 300,
                nullable: false,
                defaultValue: "");
        }
    }
}
