using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Estimator.Migrations
{
    public partial class XLSXRowNumber : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RowNum",
                table: "XLSXElementType",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Key",
                table: "ElementKey",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "DefectedType",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeNominal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProtokolNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormTY = table.Column<bool>(type: "bit", nullable: false),
                    Unrecommend = table.Column<bool>(type: "bit", nullable: false),
                    RFA = table.Column<bool>(type: "bit", nullable: false),
                    DefectCount = table.Column<long>(type: "bigint", nullable: false),
                    ElementImportID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DefectedType", x => x.ID);
                    table.ForeignKey(
                        name: "FK_DefectedType_ElementImports_ElementImportID",
                        column: x => x.ElementImportID,
                        principalTable: "ElementImports",
                        principalColumn: "ElementImportID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_CustomerRequests_ParentCustomerRequestID",
                table: "CustomerRequests",
                column: "ParentCustomerRequestID",
                unique: true,
                filter: "[ParentCustomerRequestID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_DefectedType_ElementImportID",
                table: "DefectedType",
                column: "ElementImportID");
          
            //migrationBuilder.AddForeignKey(
            //    name: "FK_CustomerRequests_CustomerRequests_ParentCustomerRequestID",
            //    table: "CustomerRequests",
            //    column: "ParentCustomerRequestID",
            //    principalTable: "CustomerRequests",
            //    principalColumn: "CustomerRequestID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerRequests_CustomerRequests_ParentCustomerRequestID",
                table: "CustomerRequests");

            migrationBuilder.DropTable(
                name: "DefectedType");

            migrationBuilder.DropIndex(
                name: "IX_CustomerRequests_ParentCustomerRequestID",
                table: "CustomerRequests");

            migrationBuilder.DropColumn(
                name: "RowNum",
                table: "XLSXElementType");

            migrationBuilder.AlterColumn<string>(
                name: "Key",
                table: "ElementKey",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
