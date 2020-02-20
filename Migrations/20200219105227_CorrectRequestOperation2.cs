using Microsoft.EntityFrameworkCore.Migrations;

namespace Estimator.Migrations
{
    public partial class CorrectRequestOperation2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RequestOperation_CustomerRequests_CustomerRequestID",
                table: "RequestOperation");

            migrationBuilder.DropIndex(
                name: "IX_RequestOperation_CustomerRequestID",
                table: "RequestOperation");

            migrationBuilder.DropColumn(
                name: "CustomerRequestID",
                table: "RequestOperation");

            migrationBuilder.AddColumn<int>(
                name: "RequestElementTypeID",
                table: "RequestOperation",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_RequestOperation_RequestElementTypeID",
                table: "RequestOperation",
                column: "RequestElementTypeID");

            migrationBuilder.AddForeignKey(
                name: "FK_RequestOperation_RequestElementType_RequestElementTypeID",
                table: "RequestOperation",
                column: "RequestElementTypeID",
                principalTable: "RequestElementType",
                principalColumn: "RequestElementTypeID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RequestOperation_RequestElementType_RequestElementTypeID",
                table: "RequestOperation");

            migrationBuilder.DropIndex(
                name: "IX_RequestOperation_RequestElementTypeID",
                table: "RequestOperation");

            migrationBuilder.DropColumn(
                name: "RequestElementTypeID",
                table: "RequestOperation");

            migrationBuilder.AddColumn<int>(
                name: "CustomerRequestID",
                table: "RequestOperation",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_RequestOperation_CustomerRequestID",
                table: "RequestOperation",
                column: "CustomerRequestID");

            migrationBuilder.AddForeignKey(
                name: "FK_RequestOperation_CustomerRequests_CustomerRequestID",
                table: "RequestOperation",
                column: "CustomerRequestID",
                principalTable: "CustomerRequests",
                principalColumn: "CustomerRequestID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
