using Microsoft.EntityFrameworkCore.Migrations;

namespace DesignPage.Migrations
{
    public partial class FieldPositionToAboutUs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Position",
                table: "AboutUses",
                maxLength: 150,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Position",
                table: "AboutUses");
        }
    }
}
