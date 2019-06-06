using Microsoft.EntityFrameworkCore.Migrations;

namespace Proje.DataAccess.Migrations
{
    public partial class _123 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Password_User_UserID",
                table: "Password");

            migrationBuilder.DropIndex(
                name: "IX_Password_UserID",
                table: "Password");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "Password");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserID",
                table: "Password",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Password_UserID",
                table: "Password",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Password_User_UserID",
                table: "Password",
                column: "UserID",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
