using Microsoft.EntityFrameworkCore.Migrations;

namespace Estimator.Migrations
{
    public partial class AddRequestOperation2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RequestOperation",
                columns: table => new
                {
                    RequestOperationID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerRequestID = table.Column<int>(nullable: false),
                    RequestElementTypeID = table.Column<int>(nullable: true),
                    OperationID = table.Column<int>(nullable: false),
                    IsExecute = table.Column<bool>(nullable: false),
                    ExecuteCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestOperation", x => x.RequestOperationID);
                    table.ForeignKey(
                        name: "FK_RequestOperation_CustomerRequests_CustomerRequestID",
                        column: x => x.CustomerRequestID,
                        principalTable: "CustomerRequests",
                        principalColumn: "CustomerRequestID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RequestOperation_Operation_OperationID",
                        column: x => x.OperationID,
                        principalTable: "Operation",
                        principalColumn: "OperationID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RequestOperation_RequestElementType_RequestElementTypeID",
                        column: x => x.RequestElementTypeID,
                        principalTable: "RequestElementType",
                        principalColumn: "RequestElementTypeID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RequestOperation_CustomerRequestID",
                table: "RequestOperation",
                column: "CustomerRequestID");

            migrationBuilder.CreateIndex(
                name: "IX_RequestOperation_OperationID",
                table: "RequestOperation",
                column: "OperationID");

            migrationBuilder.CreateIndex(
                name: "IX_RequestOperation_RequestElementTypeID",
                table: "RequestOperation",
                column: "RequestElementTypeID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RequestOperation");
        }
    }
}
