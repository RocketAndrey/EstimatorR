using Microsoft.EntityFrameworkCore.Migrations;

namespace Estimator.Migrations
{
    public partial class importXLSX : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ElementImports",
                columns: table => new
                {
                    ElementImportID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerRequestID = table.Column<int>(nullable: false),
                    ElementNameColumn = table.Column<int>(nullable: false),
                    ElementDatasheetColumn = table.Column<int>(nullable: false),
                    ElementManufacturingColumn = table.Column<int>(nullable: false),
                    ElementTypeKeyColumn = table.Column<int>(nullable: false),
                    ElementCountColumn = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElementImports", x => x.ElementImportID);
                    table.ForeignKey(
                        name: "FK_ElementImports_CustomerRequests_CustomerRequestID",
                        column: x => x.CustomerRequestID,
                        principalTable: "CustomerRequests",
                        principalColumn: "CustomerRequestID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "XLSXElementType",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ElementImportID = table.Column<int>(nullable: false),
                    ElementName = table.Column<string>(nullable: true),
                    ElementDatasheet = table.Column<string>(nullable: true),
                    ElementManufacturing = table.Column<string>(nullable: true),
                    ElementTypeKey = table.Column<string>(nullable: true),
                    ElementCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_XLSXElementType", x => x.ID);
                    table.ForeignKey(
                        name: "FK_XLSXElementType_ElementImports_ElementImportID",
                        column: x => x.ElementImportID,
                        principalTable: "ElementImports",
                        principalColumn: "ElementImportID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ElementImports_CustomerRequestID",
                table: "ElementImports",
                column: "CustomerRequestID");

            migrationBuilder.CreateIndex(
                name: "IX_XLSXElementType_ElementImportID",
                table: "XLSXElementType",
                column: "ElementImportID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "XLSXElementType");

            migrationBuilder.DropTable(
                name: "ElementImports");
        }
    }
}
