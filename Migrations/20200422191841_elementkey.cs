using Microsoft.EntityFrameworkCore.Migrations;

namespace Estimator.Migrations
{
    public partial class elementkey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ElementKey",
                columns: table => new
                {
                    ElementKeyID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ElementTypeID = table.Column<int>(nullable: false),
                    Key = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElementKey", x => x.ElementKeyID);
                    table.ForeignKey(
                        name: "FK_ElementKey_ElementType_ElementTypeID",
                        column: x => x.ElementTypeID,
                        principalTable: "ElementType",
                        principalColumn: "ElementTypeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ElementKey_ElementTypeID",
                table: "ElementKey",
                column: "ElementTypeID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ElementKey");
        }
    }
}
