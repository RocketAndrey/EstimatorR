using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Estimator.Migrations
{
    /// <inheritdoc />
    public partial class PriceHistoryCreateDate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ElementPriceHistory_XLSXElementType_XLSXElementTypeID",
                table: "ElementPriceHistory");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "ElementPriceHistory",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddForeignKey(
                name: "FK_ElementPriceHistory_XLSXElementType_XLSXElementTypeID",
                table: "ElementPriceHistory",
                column: "XLSXElementTypeID",
                principalTable: "XLSXElementType",
                principalColumn: "ID",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ElementPriceHistory_XLSXElementType_XLSXElementTypeID",
                table: "ElementPriceHistory");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "ElementPriceHistory");

            migrationBuilder.AddForeignKey(
                name: "FK_ElementPriceHistory_XLSXElementType_XLSXElementTypeID",
                table: "ElementPriceHistory",
                column: "XLSXElementTypeID",
                principalTable: "XLSXElementType",
                principalColumn: "ID");
        }
    }
}
