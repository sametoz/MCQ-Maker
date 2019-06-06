using Microsoft.EntityFrameworkCore.Migrations;

namespace Proje.DataAccess.Migrations
{
    public partial class orhan3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Email_Contact_ContactID",
                table: "Email");

            migrationBuilder.DropForeignKey(
                name: "FK_Phone_Contact_ContactID",
                table: "Phone");

            migrationBuilder.AlterColumn<int>(
                name: "ContactID",
                table: "Phone",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "ContactID",
                table: "Email",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Email_Contact_ContactID",
                table: "Email",
                column: "ContactID",
                principalTable: "Contact",
                principalColumn: "ContactID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Phone_Contact_ContactID",
                table: "Phone",
                column: "ContactID",
                principalTable: "Contact",
                principalColumn: "ContactID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Email_Contact_ContactID",
                table: "Email");

            migrationBuilder.DropForeignKey(
                name: "FK_Phone_Contact_ContactID",
                table: "Phone");

            migrationBuilder.AlterColumn<int>(
                name: "ContactID",
                table: "Phone",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ContactID",
                table: "Email",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Email_Contact_ContactID",
                table: "Email",
                column: "ContactID",
                principalTable: "Contact",
                principalColumn: "ContactID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Phone_Contact_ContactID",
                table: "Phone",
                column: "ContactID",
                principalTable: "Contact",
                principalColumn: "ContactID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
