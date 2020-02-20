using Microsoft.EntityFrameworkCore.Migrations;

namespace Estimator.Migrations
{
    public partial class CorrectRequestOperation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RequestOperation_Operation_OperationID",
                table: "RequestOperation");

            migrationBuilder.DropForeignKey(
                name: "FK_RequestOperation_RequestElementType_RequestElementTypeID",
                table: "RequestOperation");

            migrationBuilder.DropIndex(
                name: "IX_RequestOperation_OperationID",
                table: "RequestOperation");

            migrationBuilder.DropIndex(
                name: "IX_RequestOperation_RequestElementTypeID",
                table: "RequestOperation");

            migrationBuilder.DropColumn(
                name: "OperationID",
                table: "RequestOperation");

            migrationBuilder.DropColumn(
                name: "RequestElementTypeID",
                table: "RequestOperation");

            migrationBuilder.AddColumn<int>(
                name: "TestChainItemID",
                table: "RequestOperation",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_RequestOperation_TestChainItemID",
                table: "RequestOperation",
                column: "TestChainItemID");

            migrationBuilder.AddForeignKey(
                name: "FK_RequestOperation_TestChainItem_TestChainItemID",
                table: "RequestOperation",
                column: "TestChainItemID",
                principalTable: "TestChainItem",
                principalColumn: "TestChainItemID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RequestOperation_TestChainItem_TestChainItemID",
                table: "RequestOperation");

            migrationBuilder.DropIndex(
                name: "IX_RequestOperation_TestChainItemID",
                table: "RequestOperation");

            migrationBuilder.DropColumn(
                name: "TestChainItemID",
                table: "RequestOperation");

            migrationBuilder.AddColumn<int>(
                name: "OperationID",
                table: "RequestOperation",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RequestElementTypeID",
                table: "RequestOperation",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_RequestOperation_OperationID",
                table: "RequestOperation",
                column: "OperationID");

            migrationBuilder.CreateIndex(
                name: "IX_RequestOperation_RequestElementTypeID",
                table: "RequestOperation",
                column: "RequestElementTypeID");

            migrationBuilder.AddForeignKey(
                name: "FK_RequestOperation_Operation_OperationID",
                table: "RequestOperation",
                column: "OperationID",
                principalTable: "Operation",
                principalColumn: "OperationID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RequestOperation_RequestElementType_RequestElementTypeID",
                table: "RequestOperation",
                column: "RequestElementTypeID",
                principalTable: "RequestElementType",
                principalColumn: "RequestElementTypeID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
