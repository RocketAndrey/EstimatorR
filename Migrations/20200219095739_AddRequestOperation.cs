using Microsoft.EntityFrameworkCore.Migrations;

namespace Estimator.Migrations
{
    public partial class AddRequestOperation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "KitCount",
                table: "RequestElementType",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsExecuteDefault",
                table: "Operation",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "KitCount",
                table: "RequestElementType");

            migrationBuilder.DropColumn(
                name: "IsExecuteDefault",
                table: "Operation");
        }
    }
}
