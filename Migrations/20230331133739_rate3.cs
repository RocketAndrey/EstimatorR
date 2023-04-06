using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Estimator.Migrations
{
    public partial class rate3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rate",
                table: "ElementImports");

            migrationBuilder.AddColumn<decimal>(
                name: "Rate",
                table: "CustomerRequests",
                type: "decimal(18,4)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rate",
                table: "CustomerRequests");

            migrationBuilder.AddColumn<decimal>(
                name: "Rate",
                table: "ElementImports",
                type: "decimal(18,4)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
