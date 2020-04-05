using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Estimator.Migrations
{
    public partial class CalcFactor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "CompanyHistory");

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "CompanyHistory");

            migrationBuilder.AlterColumn<decimal>(
                name: "PensionTax",
                table: "CompanyHistory",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<decimal>(
                name: "OverHead",
                table: "CompanyHistory",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<decimal>(
                name: "Margin",
                table: "CompanyHistory",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AddColumn<string>(
                name: "CompanyName",
                table: "CompanyHistory",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "YearOfNorms",
                table: "CompanyHistory",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "CalcFactor",
                columns: table => new
                {
                    CalcFactorID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyHistoryID = table.Column<int>(nullable: false),
                    FactorName = table.Column<string>(nullable: true),
                    FactorValue = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CalcFactor", x => x.CalcFactorID);
                    table.ForeignKey(
                        name: "FK_CalcFactor_CompanyHistory_CompanyHistoryID",
                        column: x => x.CompanyHistoryID,
                        principalTable: "CompanyHistory",
                        principalColumn: "CompanyHistoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CalcFactor_CompanyHistoryID",
                table: "CalcFactor",
                column: "CompanyHistoryID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CalcFactor");

            migrationBuilder.DropColumn(
                name: "CompanyName",
                table: "CompanyHistory");

            migrationBuilder.DropColumn(
                name: "YearOfNorms",
                table: "CompanyHistory");

            migrationBuilder.AlterColumn<double>(
                name: "PensionTax",
                table: "CompanyHistory",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<double>(
                name: "OverHead",
                table: "CompanyHistory",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<double>(
                name: "Margin",
                table: "CompanyHistory",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "CompanyHistory",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDate",
                table: "CompanyHistory",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
