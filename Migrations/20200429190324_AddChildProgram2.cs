using Microsoft.EntityFrameworkCore.Migrations;

namespace Estimator.Migrations
{
    public partial class AddChildProgram2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ParentElementTypeID",
                table: "ElementType");

            migrationBuilder.AddColumn<int>(
                name: "ChildElementTypeID",
                table: "ElementType",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ChildElementTypeID",
                table: "ElementType");

            migrationBuilder.AddColumn<int>(
                name: "ParentElementTypeID",
                table: "ElementType",
                type: "int",
                nullable: true);
        }
    }
}
