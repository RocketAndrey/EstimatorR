using Microsoft.EntityFrameworkCore.Migrations;

namespace Estimator.Migrations
{
    public partial class AddRequestElementType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RequestElementType",
                columns: table => new
                {
                    RequestElementTypeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ElementTypeID = table.Column<int>(nullable: true),
                    CustomerRequestID = table.Column<int>(nullable: false),
                    BatchCount = table.Column<int>(nullable: false),
                    ItemCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestElementType", x => x.RequestElementTypeID);
                    table.ForeignKey(
                        name: "FK_RequestElementType_CustomerRequests_CustomerRequestID",
                        column: x => x.CustomerRequestID,
                        principalTable: "CustomerRequests",
                        principalColumn: "CustomerRequestID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RequestElementType_ElementType_ElementTypeID",
                        column: x => x.ElementTypeID,
                        principalTable: "ElementType",
                        principalColumn: "ElementTypeID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RequestElementType_CustomerRequestID",
                table: "RequestElementType",
                column: "CustomerRequestID");

            migrationBuilder.CreateIndex(
                name: "IX_RequestElementType_ElementTypeID",
                table: "RequestElementType",
                column: "ElementTypeID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RequestElementType");
        }
    }
}
