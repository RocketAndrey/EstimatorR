using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Estimator.Migrations
{
    /// <inheritdoc />
    public partial class PriceListType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PriceItemTypeID",
                table: "PriceLists",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PriceLists_PriceItemTypeID",
                table: "PriceLists",
                column: "PriceItemTypeID");

            migrationBuilder.AddForeignKey(
                name: "FK_PriceLists_PriceItemType_PriceItemTypeID",
                table: "PriceLists",
                column: "PriceItemTypeID",
                principalTable: "PriceItemType",
                principalColumn: "PriceItemTypeID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PriceLists_PriceItemType_PriceItemTypeID",
                table: "PriceLists");

            migrationBuilder.DropIndex(
                name: "IX_PriceLists_PriceItemTypeID",
                table: "PriceLists");

            migrationBuilder.DropColumn(
                name: "PriceItemTypeID",
                table: "PriceLists");
        }
    }
}
