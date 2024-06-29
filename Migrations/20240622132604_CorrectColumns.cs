using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Estimator.Migrations
{
    /// <inheritdoc />
    public partial class CorrectColumns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Manufacturer",
                table: "PriceLists");

            migrationBuilder.RenameColumn(
                name: "TimeDelivery",
                table: "Prices",
                newName: "DeliveryTime");

            migrationBuilder.RenameColumn(
                name: "StandartPack",
                table: "Prices",
                newName: "PackingSample");

            migrationBuilder.RenameColumn(
                name: "StandartDelivery",
                table: "Prices",
                newName: "MinPackingSize");

            migrationBuilder.AlterColumn<int>(
                name: "VniirId",
                table: "Prices",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "CompanyId",
                table: "PriceLists",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Prices_PriceListId",
                table: "Prices",
                column: "PriceListId");

            migrationBuilder.CreateIndex(
                name: "IX_PriceLists_CompanyId",
                table: "PriceLists",
                column: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_PriceLists_Companies_CompanyId",
                table: "PriceLists",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Prices_PriceLists_PriceListId",
                table: "Prices",
                column: "PriceListId",
                principalTable: "PriceLists",
                principalColumn: "PriceListId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PriceLists_Companies_CompanyId",
                table: "PriceLists");

            migrationBuilder.DropForeignKey(
                name: "FK_Prices_PriceLists_PriceListId",
                table: "Prices");

            migrationBuilder.DropIndex(
                name: "IX_Prices_PriceListId",
                table: "Prices");

            migrationBuilder.DropIndex(
                name: "IX_PriceLists_CompanyId",
                table: "PriceLists");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "PriceLists");

            migrationBuilder.RenameColumn(
                name: "PackingSample",
                table: "Prices",
                newName: "StandartPack");

            migrationBuilder.RenameColumn(
                name: "MinPackingSize",
                table: "Prices",
                newName: "StandartDelivery");

            migrationBuilder.RenameColumn(
                name: "DeliveryTime",
                table: "Prices",
                newName: "TimeDelivery");

            migrationBuilder.AlterColumn<int>(
                name: "VniirId",
                table: "Prices",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Manufacturer",
                table: "PriceLists",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
