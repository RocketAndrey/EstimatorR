using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Estimator.Migrations
{
    public partial class AddCompany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "OperationGroupCode",
                table: "RequestOperationGroupViews",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SampleCount",
                table: "RequestElementType",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SampleCount",
                table: "Operation",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "CompanyHistory",
                columns: table => new
                {
                    CompanyHistoryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    OverHead = table.Column<double>(nullable: false),
                    Margin = table.Column<double>(nullable: false),
                    PensionTax = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyHistory", x => x.CompanyHistoryID);
                });

            migrationBuilder.CreateTable(
                name: "StaffItem",
                columns: table => new
                {
                    StaffItemID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyHistoryID = table.Column<int>(nullable: false),
                    QualificationID = table.Column<int>(nullable: false),
                    Count = table.Column<int>(nullable: false),
                    Salary = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StaffItem", x => x.StaffItemID);
                    table.ForeignKey(
                        name: "FK_StaffItem_CompanyHistory_CompanyHistoryID",
                        column: x => x.CompanyHistoryID,
                        principalTable: "CompanyHistory",
                        principalColumn: "CompanyHistoryID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StaffItem_Qualification_QualificationID",
                        column: x => x.QualificationID,
                        principalTable: "Qualification",
                        principalColumn: "QualificationID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StaffItem_CompanyHistoryID",
                table: "StaffItem",
                column: "CompanyHistoryID");

            migrationBuilder.CreateIndex(
                name: "IX_StaffItem_QualificationID",
                table: "StaffItem",
                column: "QualificationID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StaffItem");

            migrationBuilder.DropTable(
                name: "CompanyHistory");

            migrationBuilder.DropColumn(
                name: "OperationGroupCode",
                table: "RequestOperationGroupViews");

            migrationBuilder.DropColumn(
                name: "SampleCount",
                table: "RequestElementType");

            migrationBuilder.DropColumn(
                name: "SampleCount",
                table: "Operation");
        }
    }
}
