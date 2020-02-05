using Microsoft.EntityFrameworkCore.Migrations;

namespace Estimator.Migrations
{
    public partial class CorrectTestChains3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TestAction_TestChainItem_TestChainItemElementTypeID_TestChainItemOperationID",
                table: "TestAction");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TestChainItem",
                table: "TestChainItem");

            migrationBuilder.DropIndex(
                name: "IX_TestAction_TestChainItemElementTypeID_TestChainItemOperationID",
                table: "TestAction");

            migrationBuilder.DropColumn(
                name: "TestChainItemElementTypeID",
                table: "TestAction");

            migrationBuilder.DropColumn(
                name: "TestChainItemOperationID",
                table: "TestAction");

            migrationBuilder.AddColumn<int>(
                name: "TestChainItemID",
                table: "TestChainItem",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TestChainItem",
                table: "TestChainItem",
                column: "TestChainItemID");

            migrationBuilder.CreateIndex(
                name: "IX_TestChainItem_ElementTypeID",
                table: "TestChainItem",
                column: "ElementTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_TestAction_TestChainItemID",
                table: "TestAction",
                column: "TestChainItemID");

            migrationBuilder.AddForeignKey(
                name: "FK_TestAction_TestChainItem_TestChainItemID",
                table: "TestAction",
                column: "TestChainItemID",
                principalTable: "TestChainItem",
                principalColumn: "TestChainItemID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TestAction_TestChainItem_TestChainItemID",
                table: "TestAction");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TestChainItem",
                table: "TestChainItem");

            migrationBuilder.DropIndex(
                name: "IX_TestChainItem_ElementTypeID",
                table: "TestChainItem");

            migrationBuilder.DropIndex(
                name: "IX_TestAction_TestChainItemID",
                table: "TestAction");

            migrationBuilder.DropColumn(
                name: "TestChainItemID",
                table: "TestChainItem");

            migrationBuilder.AddColumn<int>(
                name: "TestChainItemElementTypeID",
                table: "TestAction",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TestChainItemOperationID",
                table: "TestAction",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_TestChainItem",
                table: "TestChainItem",
                columns: new[] { "ElementTypeID", "OperationID" });

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
    }
}
