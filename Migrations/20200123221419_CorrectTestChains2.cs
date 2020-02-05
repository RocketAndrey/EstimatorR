using Microsoft.EntityFrameworkCore.Migrations;

namespace Estimator.Migrations
{
    public partial class CorrectTestChains2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TestAction",
                table: "TestAction");

            migrationBuilder.AddColumn<int>(
                name: "TestActionID",
                table: "TestAction",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TestAction",
                table: "TestAction",
                column: "TestActionID");

            migrationBuilder.CreateIndex(
                name: "IX_TestAction_QualificationID",
                table: "TestAction",
                column: "QualificationID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TestAction",
                table: "TestAction");

            migrationBuilder.DropIndex(
                name: "IX_TestAction_QualificationID",
                table: "TestAction");

            migrationBuilder.DropColumn(
                name: "TestActionID",
                table: "TestAction");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TestAction",
                table: "TestAction",
                columns: new[] { "QualificationID", "TestChainItemID" });
        }
    }
}
