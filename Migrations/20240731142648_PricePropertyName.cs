using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Estimator.Migrations
{
    /// <inheritdoc />
    public partial class PricePropertyName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PriceItemTypeId",
                table: "Prices",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Property0",
                table: "Prices",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Property1",
                table: "Prices",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Property2",
                table: "Prices",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Property3",
                table: "Prices",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Property4",
                table: "Prices",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Property5",
                table: "Prices",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Property6",
                table: "Prices",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Property7",
                table: "Prices",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Property8",
                table: "Prices",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Property9",
                table: "Prices",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "PriceLists",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "PriceItemType",
                columns: table => new
                {
                    PriceItemTypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PriceItemTypeName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PriceItemType", x => x.PriceItemTypeID);
                });

            migrationBuilder.CreateTable(
                name: "PricePropertyName",
                columns: table => new
                {
                    PricePropertyNameId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PriceItemTypeId = table.Column<int>(type: "int", nullable: false),
                    PropertyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ElementPropertyName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PricePropertyName", x => x.PricePropertyNameId);
                    table.ForeignKey(
                        name: "FK_PricePropertyName_PriceItemType_PriceItemTypeId",
                        column: x => x.PriceItemTypeId,
                        principalTable: "PriceItemType",
                        principalColumn: "PriceItemTypeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Prices_PriceItemTypeId",
                table: "Prices",
                column: "PriceItemTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PricePropertyName_PriceItemTypeId",
                table: "PricePropertyName",
                column: "PriceItemTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Prices_PriceItemType_PriceItemTypeId",
                table: "Prices",
                column: "PriceItemTypeId",
                principalTable: "PriceItemType",
                principalColumn: "PriceItemTypeID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Prices_PriceItemType_PriceItemTypeId",
                table: "Prices");

            migrationBuilder.DropTable(
                name: "PricePropertyName");

            migrationBuilder.DropTable(
                name: "PriceItemType");

            migrationBuilder.DropIndex(
                name: "IX_Prices_PriceItemTypeId",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "PriceItemTypeId",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "Property0",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "Property1",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "Property2",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "Property3",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "Property4",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "Property5",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "Property6",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "Property7",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "Property8",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "Property9",
                table: "Prices");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "PriceLists",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
