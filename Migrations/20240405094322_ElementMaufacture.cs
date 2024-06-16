using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Estimator.Migrations
{
    /// <inheritdoc />
    public partial class ElementMaufacture : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UseElementPrice",
                table: "ElementImports");

            migrationBuilder.RenameColumn(
                name: "ValidElementName",
                table: "XLSXElementType",
                newName: "QualificationLevel");

            migrationBuilder.RenameColumn(
                name: "ValidDatasheet",
                table: "XLSXElementType",
                newName: "ImportedElementName");

            migrationBuilder.AlterColumn<decimal>(
                name: "ImportedPrice",
                table: "XLSXElementType",
                type: "decimal(18,4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AddColumn<int>(
                name: "CompanyId",
                table: "XLSXElementType",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImportedDatasheet",
                table: "XLSXElementType",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SampleCount",
                table: "XLSXElementType",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_XLSXElementType_CompanyId",
                table: "XLSXElementType",
                column: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_XLSXElementType_Companies_CompanyId",
                table: "XLSXElementType",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_XLSXElementType_Companies_CompanyId",
                table: "XLSXElementType");

            migrationBuilder.DropIndex(
                name: "IX_XLSXElementType_CompanyId",
                table: "XLSXElementType");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "XLSXElementType");

            migrationBuilder.DropColumn(
                name: "ImportedDatasheet",
                table: "XLSXElementType");

            migrationBuilder.DropColumn(
                name: "SampleCount",
                table: "XLSXElementType");

            migrationBuilder.RenameColumn(
                name: "QualificationLevel",
                table: "XLSXElementType",
                newName: "ValidElementName");

            migrationBuilder.RenameColumn(
                name: "ImportedElementName",
                table: "XLSXElementType",
                newName: "ValidDatasheet");

            migrationBuilder.AlterColumn<decimal>(
                name: "ImportedPrice",
                table: "XLSXElementType",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,4)");

            migrationBuilder.AddColumn<bool>(
                name: "UseElementPrice",
                table: "ElementImports",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
