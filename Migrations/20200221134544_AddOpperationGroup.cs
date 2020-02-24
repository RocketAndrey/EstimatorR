using Microsoft.EntityFrameworkCore.Migrations;

namespace Estimator.Migrations
{
    public partial class AddOpperationGroup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OperationGroupID",
                table: "Operation",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "OperationGroup",
                columns: table => new
                {
                    OperationGroupID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(maxLength: 10, nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationGroup", x => x.OperationGroupID);
                });

            migrationBuilder.CreateTable(
                name: "RequestOperationGroupViews",
                columns: table => new
                {
                    OperationID = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    IsExecute = table.Column<bool>(nullable: false),
                    ExecuteCount = table.Column<int>(nullable: false),
                    Order = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateIndex(
                name: "IX_Operation_OperationGroupID",
                table: "Operation",
                column: "OperationGroupID");

            migrationBuilder.AddForeignKey(
                name: "FK_Operation_OperationGroup_OperationGroupID",
                table: "Operation",
                column: "OperationGroupID",
                principalTable: "OperationGroup",
                principalColumn: "OperationGroupID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Operation_OperationGroup_OperationGroupID",
                table: "Operation");

            migrationBuilder.DropTable(
                name: "OperationGroup");

            migrationBuilder.DropTable(
                name: "RequestOperationGroupViews");

            migrationBuilder.DropIndex(
                name: "IX_Operation_OperationGroupID",
                table: "Operation");

            migrationBuilder.DropColumn(
                name: "OperationGroupID",
                table: "Operation");
        }
    }
}
