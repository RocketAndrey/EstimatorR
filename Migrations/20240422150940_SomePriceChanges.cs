using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Estimator.Migrations
{
    /// <inheritdoc />
    public partial class SomePriceChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SampleSize",
                table: "XLSXElementType",
                newName: "PriceHistorySourceID");

            migrationBuilder.AddColumn<int>(
                name: "DeliveryTime",
                table: "ElementPriceHistory",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ElementName",
                table: "ElementPriceHistory",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeliveryTime",
                table: "ElementPriceHistory");

            migrationBuilder.DropColumn(
                name: "ElementName",
                table: "ElementPriceHistory");

            migrationBuilder.RenameColumn(
                name: "PriceHistorySourceID",
                table: "XLSXElementType",
                newName: "SampleSize");
        }
    }
}
