using Microsoft.EntityFrameworkCore.Migrations;

namespace Estimator.Migrations
{
    public partial class operationTemplate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_TestProgramTemplateItem_TestChainItem_TestChainItemID",
            //    table: "TestProgramTemplateItem");

            migrationBuilder.DropIndex(
                name: "IX_TestProgramTemplateItem_TestChainItemID",
                table: "TestProgramTemplateItem");

            migrationBuilder.DropColumn(
                name: "TestChainItemID",
                table: "TestProgramTemplateItem");

            migrationBuilder.AddColumn<int>(
                name: "OperationID",
                table: "TestProgramTemplateItem",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TestProgramTemplateItem_OperationID",
                table: "TestProgramTemplateItem",
                column: "OperationID");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_TestProgramTemplateItem_Operation_OperationID",
            //    table: "TestProgramTemplateItem",
            //    column: "OperationID",
            //    principalTable: "Operation",
            //    principalColumn: "OperationID",
            //    onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TestProgramTemplateItem_Operation_OperationID",
                table: "TestProgramTemplateItem");

            migrationBuilder.DropIndex(
                name: "IX_TestProgramTemplateItem_OperationID",
                table: "TestProgramTemplateItem");

            migrationBuilder.DropColumn(
                name: "OperationID",
                table: "TestProgramTemplateItem");

            migrationBuilder.AddColumn<int>(
                name: "TestChainItemID",
                table: "TestProgramTemplateItem",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TestProgramTemplateItem_TestChainItemID",
                table: "TestProgramTemplateItem",
                column: "TestChainItemID");

            migrationBuilder.AddForeignKey(
                name: "FK_TestProgramTemplateItem_TestChainItem_TestChainItemID",
                table: "TestProgramTemplateItem",
                column: "TestChainItemID",
                principalTable: "TestChainItem",
                principalColumn: "TestChainItemID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
