using Microsoft.EntityFrameworkCore.Migrations;

namespace Estimator.Migrations
{
    public partial class AddTestChains : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Laboriousness",
                columns: table => new
                {
                    LaboriousnessID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OperationID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Laboriousness", x => x.LaboriousnessID);
                    table.ForeignKey(
                        name: "FK_Laboriousness_Operation_OperationID",
                        column: x => x.OperationID,
                        principalTable: "Operation",
                        principalColumn: "OperationID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Qualification",
                columns: table => new
                {
                    QualificationID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Qualification", x => x.QualificationID);
                });

            migrationBuilder.CreateTable(
                name: "TestChain",
                columns: table => new
                {
                    TestChainID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestChain", x => x.TestChainID);
                });

            migrationBuilder.CreateTable(
                name: "TestAction",
                columns: table => new
                {
                    QualificationID = table.Column<int>(nullable: false),
                    LaboriousnessID = table.Column<int>(nullable: false),
                    BatchLabor = table.Column<int>(nullable: false),
                    ItemLabor = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestAction", x => new { x.QualificationID, x.LaboriousnessID });
                    table.ForeignKey(
                        name: "FK_TestAction_Laboriousness_LaboriousnessID",
                        column: x => x.LaboriousnessID,
                        principalTable: "Laboriousness",
                        principalColumn: "LaboriousnessID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TestAction_Qualification_QualificationID",
                        column: x => x.QualificationID,
                        principalTable: "Qualification",
                        principalColumn: "QualificationID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TestChainItem",
                columns: table => new
                {
                    TestChainID = table.Column<int>(nullable: false),
                    ElementTypeID = table.Column<int>(nullable: false),
                    OperationID = table.Column<int>(nullable: false),
                    Order = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestChainItem", x => new { x.ElementTypeID, x.OperationID, x.TestChainID });
                    table.ForeignKey(
                        name: "FK_TestChainItem_ElementType_ElementTypeID",
                        column: x => x.ElementTypeID,
                        principalTable: "ElementType",
                        principalColumn: "ElementTypeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TestChainItem_Operation_OperationID",
                        column: x => x.OperationID,
                        principalTable: "Operation",
                        principalColumn: "OperationID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TestChainItem_TestChain_TestChainID",
                        column: x => x.TestChainID,
                        principalTable: "TestChain",
                        principalColumn: "TestChainID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Laboriousness_OperationID",
                table: "Laboriousness",
                column: "OperationID");

            migrationBuilder.CreateIndex(
                name: "IX_TestAction_LaboriousnessID",
                table: "TestAction",
                column: "LaboriousnessID");

            migrationBuilder.CreateIndex(
                name: "IX_TestChainItem_OperationID",
                table: "TestChainItem",
                column: "OperationID");

            migrationBuilder.CreateIndex(
                name: "IX_TestChainItem_TestChainID",
                table: "TestChainItem",
                column: "TestChainID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TestAction");

            migrationBuilder.DropTable(
                name: "TestChainItem");

            migrationBuilder.DropTable(
                name: "Laboriousness");

            migrationBuilder.DropTable(
                name: "Qualification");

            migrationBuilder.DropTable(
                name: "TestChain");
        }
    }
}
