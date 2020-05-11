using Microsoft.EntityFrameworkCore.Migrations;

namespace Estimator.Migrations
{
    public partial class AddChildProgram : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Element");

            migrationBuilder.AddColumn<int>(
                name: "ChildProgramID",
                table: "TestProgram",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ChildElementTypeID",
                table: "ElementType",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ChildProgramID",
                table: "TestProgram");

            migrationBuilder.DropColumn(
                name: "ChildElementTypeID",
                table: "ElementType");

            migrationBuilder.CreateTable(
                name: "Element",
                columns: table => new
                {
                    ElementID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Count = table.Column<int>(type: "int", nullable: false),
                    CustomerRequestID = table.Column<int>(type: "int", nullable: false),
                    ElementText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ElementType = table.Column<int>(type: "int", nullable: true),
                    ElementTypeID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Element", x => x.ElementID);
                    table.ForeignKey(
                        name: "FK_Element_CustomerRequests_CustomerRequestID",
                        column: x => x.CustomerRequestID,
                        principalTable: "CustomerRequests",
                        principalColumn: "CustomerRequestID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Element_CustomerRequestID",
                table: "Element",
                column: "CustomerRequestID");
        }
    }
}
