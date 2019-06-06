using Microsoft.EntityFrameworkCore.Migrations;

namespace Proje.DataAccess.Migrations
{
    public partial class database : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OldPasswords_Password_PasswordId",
                table: "OldPasswords");

            migrationBuilder.DropForeignKey(
                name: "FK_UserPassword_Password_PasswordId",
                table: "UserPassword");

            migrationBuilder.RenameColumn(
                name: "PasswordId",
                table: "UserPassword",
                newName: "PasswordID");

            migrationBuilder.RenameIndex(
                name: "IX_UserPassword_PasswordId",
                table: "UserPassword",
                newName: "IX_UserPassword_PasswordID");

            migrationBuilder.RenameColumn(
                name: "PasswordId",
                table: "OldPasswords",
                newName: "PasswordID");

            migrationBuilder.RenameIndex(
                name: "IX_OldPasswords_PasswordId",
                table: "OldPasswords",
                newName: "IX_OldPasswords_PasswordID");

            migrationBuilder.AddForeignKey(
                name: "FK_OldPasswords_Password_PasswordID",
                table: "OldPasswords",
                column: "PasswordID",
                principalTable: "Password",
                principalColumn: "PasswordId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserPassword_Password_PasswordID",
                table: "UserPassword",
                column: "PasswordID",
                principalTable: "Password",
                principalColumn: "PasswordId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OldPasswords_Password_PasswordID",
                table: "OldPasswords");

            migrationBuilder.DropForeignKey(
                name: "FK_UserPassword_Password_PasswordID",
                table: "UserPassword");

            migrationBuilder.RenameColumn(
                name: "PasswordID",
                table: "UserPassword",
                newName: "PasswordId");

            migrationBuilder.RenameIndex(
                name: "IX_UserPassword_PasswordID",
                table: "UserPassword",
                newName: "IX_UserPassword_PasswordId");

            migrationBuilder.RenameColumn(
                name: "PasswordID",
                table: "OldPasswords",
                newName: "PasswordId");

            migrationBuilder.RenameIndex(
                name: "IX_OldPasswords_PasswordID",
                table: "OldPasswords",
                newName: "IX_OldPasswords_PasswordId");

            migrationBuilder.AddForeignKey(
                name: "FK_OldPasswords_Password_PasswordId",
                table: "OldPasswords",
                column: "PasswordId",
                principalTable: "Password",
                principalColumn: "PasswordId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserPassword_Password_PasswordId",
                table: "UserPassword",
                column: "PasswordId",
                principalTable: "Password",
                principalColumn: "PasswordId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
