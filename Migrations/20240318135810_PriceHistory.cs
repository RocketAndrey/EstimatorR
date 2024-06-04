using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Estimator.Migrations
{
    /// <inheritdoc />
    public partial class PriceHistory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "ImportedPrice",
                table: "XLSXElementType",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "PriceType",
                table: "XLSXElementType",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ElementPriceHistory",
                columns: table => new
                {
                    ElementPriceHistoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    XLSXElementTypeID = table.Column<int>(type: "int", nullable: true),
                    CustomerRequestID = table.Column<int>(type: "int", nullable: true),
                    PriceType = table.Column<int>(type: "int", nullable: false),
                    PriceAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElementPriceHistory", x => x.ElementPriceHistoryID);
                    table.ForeignKey(
                        name: "FK_ElementPriceHistory_XLSXElementType_XLSXElementTypeID",
                        column: x => x.XLSXElementTypeID,
                        principalTable: "XLSXElementType",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ElementPriceHistory_XLSXElementTypeID",
                table: "ElementPriceHistory",
                column: "XLSXElementTypeID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ElementPriceHistory");

            migrationBuilder.DropColumn(
                name: "ImportedPrice",
                table: "XLSXElementType");

            migrationBuilder.DropColumn(
                name: "PriceType",
                table: "XLSXElementType");
        }
    }
}
