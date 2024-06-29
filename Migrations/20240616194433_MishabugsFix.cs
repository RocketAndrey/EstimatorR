using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Estimator.Migrations
{
    /// <inheritdoc />
    public partial class MishabugsFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "PriceHistorySourceID",
                table: "XLSXElementType",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "DirVniir",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TechCondition",
                table: "DirVniir",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_XLSXElementType_PriceHistorySourceID",
                table: "XLSXElementType",
                column: "PriceHistorySourceID");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_XLSXElementType_ElementPriceHistory_PriceHistorySourceID",
            //    table: "XLSXElementType",
            //    column: "PriceHistorySourceID",
            //    principalTable: "ElementPriceHistory",
            //    principalColumn: "ElementPriceHistoryID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_XLSXElementType_ElementPriceHistory_PriceHistorySourceID",
            //    table: "XLSXElementType");

            migrationBuilder.DropIndex(
                name: "IX_XLSXElementType_PriceHistorySourceID",
                table: "XLSXElementType");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "DirVniir");

            migrationBuilder.DropColumn(
                name: "TechCondition",
                table: "DirVniir");

            migrationBuilder.AlterColumn<int>(
                name: "PriceHistorySourceID",
                table: "XLSXElementType",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }
    }
}
