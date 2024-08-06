using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Estimator.Migrations
{
    /// <inheritdoc />
    public partial class CorrectColumnsPrice : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_XLSXElementType_PriceId",
                table: "XLSXElementType",
                column: "PriceId");

            migrationBuilder.CreateIndex(
                name: "IX_XLSXElementType_VniirItemId",
                table: "XLSXElementType",
                column: "VniirItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_XLSXElementType_DirVniir_VniirItemId",
                table: "XLSXElementType",
                column: "VniirItemId",
                principalTable: "DirVniir",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_XLSXElementType_Prices_PriceId",
                table: "XLSXElementType",
                column: "PriceId",
                principalTable: "Prices",
                principalColumn: "PriceId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_XLSXElementType_DirVniir_VniirItemId",
                table: "XLSXElementType");

            migrationBuilder.DropForeignKey(
                name: "FK_XLSXElementType_Prices_PriceId",
                table: "XLSXElementType");

            migrationBuilder.DropIndex(
                name: "IX_XLSXElementType_PriceId",
                table: "XLSXElementType");

            migrationBuilder.DropIndex(
                name: "IX_XLSXElementType_VniirItemId",
                table: "XLSXElementType");
        }
    }
}
