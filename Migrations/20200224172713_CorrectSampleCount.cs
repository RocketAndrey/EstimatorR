using Microsoft.EntityFrameworkCore.Migrations;

namespace Estimator.Migrations
{
    public partial class CorrectSampleCount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SampleCount",
                table: "RequestElementType");

            migrationBuilder.AddColumn<int>(
                name: "SampleCount",
                table: "RequestOperationGroupViews",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SampleCount",
                table: "RequestOperation",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SampleCount",
                table: "RequestOperationGroupViews");

            migrationBuilder.DropColumn(
                name: "SampleCount",
                table: "RequestOperation");

            migrationBuilder.AddColumn<int>(
                name: "SampleCount",
                table: "RequestElementType",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
