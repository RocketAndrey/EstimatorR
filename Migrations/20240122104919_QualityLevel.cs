using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Estimator.Migrations
{
    public partial class QualityLevel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Datasheet",
                table: "XLSXElementType",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImportedQualificationLevel",
                table: "XLSXElementType",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DatasheetColumn",
                table: "ElementImports",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "ImportDatasheet",
                table: "ElementImports",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ImportQualityLevel",
                table: "ElementImports",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "QualityLevelColumn",
                table: "ElementImports",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "UseElementPrice",
                table: "ElementImports",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Datasheet",
                table: "XLSXElementType");

            migrationBuilder.DropColumn(
                name: "ImportedQualificationLevel",
                table: "XLSXElementType");

            migrationBuilder.DropColumn(
                name: "DatasheetColumn",
                table: "ElementImports");

            migrationBuilder.DropColumn(
                name: "ImportDatasheet",
                table: "ElementImports");

            migrationBuilder.DropColumn(
                name: "ImportQualityLevel",
                table: "ElementImports");

            migrationBuilder.DropColumn(
                name: "QualityLevelColumn",
                table: "ElementImports");

            migrationBuilder.DropColumn(
                name: "UseElementPrice",
                table: "ElementImports");
        }
    }
}
