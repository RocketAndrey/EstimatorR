using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Estimator.Migrations
{
    /// <inheritdoc />
    public partial class UseElementsPurchase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ValidDatasheet",
                table: "XLSXElementType",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ValidElementName",
                table: "XLSXElementType",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "UseRuChipsDB",
                table: "TestProgram",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<decimal>(
                name: "PriceAmount",
                table: "ElementPriceHistory",
                type: "decimal(18,4)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "ImportSampleSize",
                table: "ElementImports",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "SampleSizeColumn",
                table: "ElementImports",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "HidePackingSample",
                table: "CustomerRequests",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "HideSamplePrice",
                table: "CustomerRequests",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "UsePurchaseElements",
                table: "CustomerRequests",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ValidDatasheet",
                table: "XLSXElementType");

            migrationBuilder.DropColumn(
                name: "ValidElementName",
                table: "XLSXElementType");

            migrationBuilder.DropColumn(
                name: "UseRuChipsDB",
                table: "TestProgram");

            migrationBuilder.DropColumn(
                name: "ImportSampleSize",
                table: "ElementImports");

            migrationBuilder.DropColumn(
                name: "SampleSizeColumn",
                table: "ElementImports");

            migrationBuilder.DropColumn(
                name: "HidePackingSample",
                table: "CustomerRequests");

            migrationBuilder.DropColumn(
                name: "HideSamplePrice",
                table: "CustomerRequests");

            migrationBuilder.DropColumn(
                name: "UsePurchaseElements",
                table: "CustomerRequests");

            migrationBuilder.AlterColumn<decimal>(
                name: "PriceAmount",
                table: "ElementPriceHistory",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,4)",
                oldNullable: true);
        }
    }
}
