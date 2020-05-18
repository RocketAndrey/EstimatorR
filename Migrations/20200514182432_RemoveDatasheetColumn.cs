using Microsoft.EntityFrameworkCore.Migrations;

namespace Estimator.Migrations
{
    public partial class RemoveDatasheetColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ElementDatasheet",
                table: "XLSXElementType");

            migrationBuilder.DropColumn(
                name: "ElementDatasheetColumn",
                table: "ElementImports");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ElementDatasheet",
                table: "XLSXElementType",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ElementDatasheetColumn",
                table: "ElementImports",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
