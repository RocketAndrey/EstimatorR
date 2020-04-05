using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace Estimator.Migrations
{
    public partial class Request : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CustomerRequests",
                columns: table => new
                {
                    CustomerRequestID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequestNumber = table.Column<string>(maxLength: 50, nullable: false),
                    RequestDate = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(maxLength: 250, nullable: false),
                    TestProgramID = table.Column<int>(nullable: false),
                    CustomerID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerRequests", x => x.CustomerRequestID);
                    table.ForeignKey(
                        name: "FK_CustomerRequests_Customer_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customer",
                        principalColumn: "CustomerID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomerRequests_TestProgram_TestProgramID",
                        column: x => x.TestProgramID,
                        principalTable: "TestProgram",
                        principalColumn: "TestProgramID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CustomerRequests_CustomerID",
                table: "CustomerRequests",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerRequests_TestProgramID",
                table: "CustomerRequests",
                column: "TestProgramID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomerRequests");
        }
    }
}
