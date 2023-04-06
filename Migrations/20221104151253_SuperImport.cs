using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Estimator.Migrations
{
    public partial class SuperImport : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UseFirstRowNumber",
                table: "ElementImports",
                newName: "ImportElementКitPrice");

            migrationBuilder.AddColumn<int>(
                name: "ElementContractorPriceColumn",
                table: "ElementImports",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ElementKitPriceColumn",
                table: "ElementImports",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "ImportElementContractorPrice",
                table: "ElementImports",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ElementContractorPriceColumn",
                table: "ElementImports");

            migrationBuilder.DropColumn(
                name: "ElementKitPriceColumn",
                table: "ElementImports");

            migrationBuilder.DropColumn(
                name: "ImportElementContractorPrice",
                table: "ElementImports");

            migrationBuilder.RenameColumn(
                name: "ImportElementКitPrice",
                table: "ElementImports",
                newName: "UseFirstRowNumber");
        }
    }
}
