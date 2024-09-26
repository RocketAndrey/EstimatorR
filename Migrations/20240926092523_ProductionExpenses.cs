using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Estimator.Migrations
{
    /// <inheritdoc />
    public partial class ProductionExpenses : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "GeneralionExpenses",
                table: "CompanyHistory",
                type: "decimal(18,4)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "ProductionExpenses",
                table: "CompanyHistory",
                type: "decimal(18,4)",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GeneralionExpenses",
                table: "CompanyHistory");

            migrationBuilder.DropColumn(
                name: "ProductionExpenses",
                table: "CompanyHistory");
        }
    }
}
