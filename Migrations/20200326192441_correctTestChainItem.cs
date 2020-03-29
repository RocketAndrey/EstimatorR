using Microsoft.EntityFrameworkCore.Migrations;

namespace Estimator.Migrations
{
    public partial class correctTestChainItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "TestChainItem",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Element",
                columns: table => new
                {
                    ElementID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ElementText = table.Column<string>(nullable: true),
                    CustomerRequestID = table.Column<int>(nullable: false),
                    ElementTypeID = table.Column<int>(nullable: true),
                    ElementType = table.Column<int>(nullable: true),
                    Count = table.Column<int>(nullable: false)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Element");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "TestChainItem");
        }
    }
}
