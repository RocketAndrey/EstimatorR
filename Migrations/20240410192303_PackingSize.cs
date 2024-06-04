using Microsoft.EntityFrameworkCore.Migrations;
using NPOI.SS.Formula.Functions;

#nullable disable

namespace Estimator.Migrations
{
    /// <inheritdoc />
    public partial class PackingSize : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Included",
                table: "XLSXElementType",
                type: "bit",
                nullable: false,
                defaultValue: true);

            migrationBuilder.AddColumn<int>(
                name: "MinPackingSize",
                table: "XLSXElementType",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PackingSample",
                table: "XLSXElementType",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SampleSize",
                table: "XLSXElementType",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MinPackingSize",
                table: "ElementPriceHistory",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PackingSample",
                table: "ElementPriceHistory",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Included",
                table: "XLSXElementType");

            migrationBuilder.DropColumn(
                name: "MinPackingSize",
                table: "XLSXElementType");

            migrationBuilder.DropColumn(
                name: "PackingSample",
                table: "XLSXElementType");

            migrationBuilder.DropColumn(
                name: "SampleSize",
                table: "XLSXElementType");

            migrationBuilder.DropColumn(
                name: "MinPackingSize",
                table: "ElementPriceHistory");

            migrationBuilder.DropColumn(
                name: "PackingSample",
                table: "ElementPriceHistory");
        }
    }
}
