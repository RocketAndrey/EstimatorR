using Microsoft.EntityFrameworkCore.Migrations;

namespace Estimator.Migrations
{
    public partial class ParentProgram : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ChildProgramID",
                table: "TestProgram");

            migrationBuilder.DropColumn(
                name: "ChildElementTypeID",
                table: "ElementType");

            migrationBuilder.AddColumn<int>(
                name: "ParentProgramID",
                table: "TestProgram",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ParentElementTypeID",
                table: "ElementType",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ParentProgramID",
                table: "TestProgram");

            migrationBuilder.DropColumn(
                name: "ParentElementTypeID",
                table: "ElementType");

            migrationBuilder.AddColumn<int>(
                name: "ChildProgramID",
                table: "TestProgram",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ChildElementTypeID",
                table: "ElementType",
                type: "int",
                nullable: true);
        }
    }
}
