using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Estimator.Migrations
{
    /// <inheritdoc />
    public partial class updateRemark : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "DirVniir",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TechCondition",
                table: "DirVniir",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "DirVniir");

            migrationBuilder.DropColumn(
                name: "TechCondition",
                table: "DirVniir");
        }
    }
}
