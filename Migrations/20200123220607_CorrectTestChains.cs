using Microsoft.EntityFrameworkCore.Migrations;

namespace Estimator.Migrations
{
    public partial class CorrectTestChains : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TestAction_Laboriousness_LaboriousnessID",
                table: "TestAction");

            migrationBuilder.DropForeignKey(
                name: "FK_TestChainItem_TestChain_TestChainID",
                table: "TestChainItem");

            migrationBuilder.DropTable(
                name: "Laboriousness");

            migrationBuilder.DropTable(
                name: "TestChain");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TestChainItem",
                table: "TestChainItem");

            migrationBuilder.DropIndex(
                name: "IX_TestChainItem_TestChainID",
                table: "TestChainItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TestAction",
                table: "TestAction");

            migrationBuilder.DropIndex(
                name: "IX_TestAction_LaboriousnessID",
                table: "TestAction");

            migrationBuilder.DropColumn(
                name: "TestChainID",
                table: "TestChainItem");

            migrationBuilder.DropColumn(
                name: "LaboriousnessID",
                table: "TestAction");

            migrationBuilder.AddColumn<int>(
                name: "TestChainItemID",
                table: "TestAction",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TestChainItemElementTypeID",
                table: "TestAction",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TestChainItemOperationID",
                table: "TestAction",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Qualification",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_TestChainItem",
                table: "TestChainItem",
                columns: new[] { "ElementTypeID", "OperationID" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_TestAction",
                table: "TestAction",
                columns: new[] { "QualificationID", "TestChainItemID" });

            migrationBuilder.CreateIndex(
                name: "IX_TestAction_TestChainItemElementTypeID_TestChainItemOperationID",
                table: "TestAction",
                columns: new[] { "TestChainItemElementTypeID", "TestChainItemOperationID" });

            migrationBuilder.AddForeignKey(
                name: "FK_TestAction_TestChainItem_TestChainItemElementTypeID_TestChainItemOperationID",
                table: "TestAction",
                columns: new[] { "TestChainItemElementTypeID", "TestChainItemOperationID" },
                principalTable: "TestChainItem",
                principalColumns: new[] { "ElementTypeID", "OperationID" },
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TestAction_TestChainItem_TestChainItemElementTypeID_TestChainItemOperationID",
                table: "TestAction");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TestChainItem",
                table: "TestChainItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TestAction",
                table: "TestAction");

            migrationBuilder.DropIndex(
                name: "IX_TestAction_TestChainItemElementTypeID_TestChainItemOperationID",
                table: "TestAction");

            migrationBuilder.DropColumn(
                name: "TestChainItemID",
                table: "TestAction");

            migrationBuilder.DropColumn(
                name: "TestChainItemElementTypeID",
                table: "TestAction");

            migrationBuilder.DropColumn(
                name: "TestChainItemOperationID",
                table: "TestAction");

            migrationBuilder.AddColumn<int>(
                name: "TestChainID",
                table: "TestChainItem",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LaboriousnessID",
                table: "TestAction",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Qualification",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AddPrimaryKey(
                name: "PK_TestChainItem",
                table: "TestChainItem",
                columns: new[] { "ElementTypeID", "OperationID", "TestChainID" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_TestAction",
                table: "TestAction",
                columns: new[] { "QualificationID", "LaboriousnessID" });

            migrationBuilder.CreateTable(
                name: "Laboriousness",
                columns: table => new
                {
                    LaboriousnessID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OperationID = table.Column<int>(type: "int", nullable: false)
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
                name: "TestChain",
                columns: table => new
                {
                    TestChainID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestChain", x => x.TestChainID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TestChainItem_TestChainID",
                table: "TestChainItem",
                column: "TestChainID");

            migrationBuilder.CreateIndex(
                name: "IX_TestAction_LaboriousnessID",
                table: "TestAction",
                column: "LaboriousnessID");

            migrationBuilder.CreateIndex(
                name: "IX_Laboriousness_OperationID",
                table: "Laboriousness",
                column: "OperationID");

            migrationBuilder.AddForeignKey(
                name: "FK_TestAction_Laboriousness_LaboriousnessID",
                table: "TestAction",
                column: "LaboriousnessID",
                principalTable: "Laboriousness",
                principalColumn: "LaboriousnessID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TestChainItem_TestChain_TestChainID",
                table: "TestChainItem",
                column: "TestChainID",
                principalTable: "TestChain",
                principalColumn: "TestChainID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
