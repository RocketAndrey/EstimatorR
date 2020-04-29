using Microsoft.EntityFrameworkCore.Migrations;

namespace Estimator.Migrations
{
    public partial class AddFileName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ElementManufacturing",
                table: "XLSXElementType");

            migrationBuilder.DropColumn(
                name: "ElementManufacturingColumn",
                table: "ElementImports");

            migrationBuilder.AddColumn<int>(
                name: "ElementTypeID",
                table: "XLSXElementType",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "FileUploaded",
                table: "ElementImports",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ElementTypeID",
                table: "XLSXElementType");

            migrationBuilder.DropColumn(
                name: "FileUploaded",
                table: "ElementImports");

            migrationBuilder.AddColumn<string>(
                name: "ElementManufacturing",
                table: "XLSXElementType",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ElementManufacturingColumn",
                table: "ElementImports",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
