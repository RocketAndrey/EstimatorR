using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Estimator.Migrations
{
    public partial class CRUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "CustomerRequests",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "CreateUserID",
                table: "CustomerRequests",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LastModificateUserID",
                table: "CustomerRequests",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModificateDate",
                table: "CustomerRequests",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateIndex(
                name: "IX_CustomerRequests_CreateUserID",
                table: "CustomerRequests",
                column: "CreateUserID");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerRequests_LastModificateUserID",
                table: "CustomerRequests",
                column: "LastModificateUserID");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerRequests_User_CreateUserID",
                table: "CustomerRequests",
                column: "CreateUserID",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerRequests_User_LastModificateUserID",
                table: "CustomerRequests",
                column: "LastModificateUserID",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerRequests_User_CreateUserID",
                table: "CustomerRequests");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerRequests_User_LastModificateUserID",
                table: "CustomerRequests");

            migrationBuilder.DropIndex(
                name: "IX_CustomerRequests_CreateUserID",
                table: "CustomerRequests");

            migrationBuilder.DropIndex(
                name: "IX_CustomerRequests_LastModificateUserID",
                table: "CustomerRequests");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "CustomerRequests");

            migrationBuilder.DropColumn(
                name: "CreateUserID",
                table: "CustomerRequests");

            migrationBuilder.DropColumn(
                name: "LastModificateUserID",
                table: "CustomerRequests");

            migrationBuilder.DropColumn(
                name: "ModificateDate",
                table: "CustomerRequests");
        }
    }
}
