using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Estimator.Migrations
{
    /// <inheritdoc />
    public partial class AdditionalPropPrice : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Property10",
                table: "Prices",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Property11",
                table: "Prices",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Property12",
                table: "Prices",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Property13",
                table: "Prices",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Property14",
                table: "Prices",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Property15",
                table: "Prices",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Property10",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "Property11",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "Property12",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "Property13",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "Property14",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "Property15",
                table: "Prices");
        }
    }
}
