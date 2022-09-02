using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Estimator.Migrations
{
    public partial class FirstRowNumber : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ElementPriceColumn",
                table: "ElementImports",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FirstRowNumber",
                table: "ElementImports",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "ImportElementPrice",
                table: "ElementImports",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "UseFirstRowNumber",
                table: "ElementImports",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ElementPriceColumn",
                table: "ElementImports");

            migrationBuilder.DropColumn(
                name: "FirstRowNumber",
                table: "ElementImports");

            migrationBuilder.DropColumn(
                name: "ImportElementPrice",
                table: "ElementImports");

            migrationBuilder.DropColumn(
                name: "UseFirstRowNumber",
                table: "ElementImports");
        }
    }
}
