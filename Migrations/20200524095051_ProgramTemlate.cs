using Microsoft.EntityFrameworkCore.Migrations;

namespace Estimator.Migrations
{
    public partial class ProgramTemlate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "ItemLabor",
                table: "TestAction",
                type: "decimal(18, 4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Salary",
                table: "StaffItem",
                type: "decimal(18, 4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "PensionTax",
                table: "CompanyHistory",
                type: "decimal(18, 4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "OverHead",
                table: "CompanyHistory",
                type: "decimal(18, 4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Margin",
                table: "CompanyHistory",
                type: "decimal(18, 4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "AdditionalSalary",
                table: "CompanyHistory",
                type: "decimal(18, 4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "FactorValue",
                table: "CalcFactor",
                type: "decimal(18, 4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.CreateTable(
                name: "TestProgramTemplate",
                columns: table => new
                {
                    TestProgramTemplateID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TemplateName = table.Column<string>(nullable: true),
                    TestProgramID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestProgramTemplate", x => x.TestProgramTemplateID);
                    table.ForeignKey(
                        name: "FK_TestProgramTemplate_TestProgram_TestProgramID",
                        column: x => x.TestProgramID,
                        principalTable: "TestProgram",
                        principalColumn: "TestProgramID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TestProgramTemplateItem",
                columns: table => new
                {
                    TestProgramTemplateItemID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestProgramTemplateID = table.Column<int>(nullable: false),
                    TestChainItemID = table.Column<int>(nullable: true),
                    IsExecute = table.Column<bool>(nullable: false),
                    ExecuteCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestProgramTemplateItem", x => x.TestProgramTemplateItemID);
                    table.ForeignKey(
                        name: "FK_TestProgramTemplateItem_TestProgramTemplate_TestProgramTemplateID",
                        column: x => x.TestProgramTemplateID,
                        principalTable: "TestProgramTemplate",
                        principalColumn: "TestProgramTemplateID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TestProgramTemplate_TestProgramID",
                table: "TestProgramTemplate",
                column: "TestProgramID");

            migrationBuilder.CreateIndex(
                name: "IX_TestProgramTemplateItem_TestChainItemID",
                table: "TestProgramTemplateItem",
                column: "TestChainItemID");

            migrationBuilder.CreateIndex(
                name: "IX_TestProgramTemplateItem_TestProgramTemplateID",
                table: "TestProgramTemplateItem",
                column: "TestProgramTemplateID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TestProgramTemplateItem");

            migrationBuilder.DropTable(
                name: "TestProgramTemplate");

            migrationBuilder.AlterColumn<decimal>(
                name: "ItemLabor",
                table: "TestAction",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 4)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Salary",
                table: "StaffItem",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 4)");

            migrationBuilder.AlterColumn<decimal>(
                name: "PensionTax",
                table: "CompanyHistory",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 4)");

            migrationBuilder.AlterColumn<decimal>(
                name: "OverHead",
                table: "CompanyHistory",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 4)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Margin",
                table: "CompanyHistory",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 4)");

            migrationBuilder.AlterColumn<decimal>(
                name: "AdditionalSalary",
                table: "CompanyHistory",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 4)");

            migrationBuilder.AlterColumn<decimal>(
                name: "FactorValue",
                table: "CalcFactor",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 4)");
        }
    }
}
