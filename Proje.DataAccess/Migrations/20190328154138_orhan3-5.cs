using Microsoft.EntityFrameworkCore.Migrations;

namespace Proje.DataAccess.Migrations
{
    public partial class orhan35 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Email_Contact_ContactID",
                table: "Email");

            migrationBuilder.DropForeignKey(
                name: "FK_Phone_Contact_ContactID",
                table: "Phone");

            migrationBuilder.DropIndex(
                name: "IX_Phone_ContactID",
                table: "Phone");

            migrationBuilder.DropIndex(
                name: "IX_Email_ContactID",
                table: "Email");

            migrationBuilder.DropColumn(
                name: "ContactID",
                table: "Phone");

            migrationBuilder.DropColumn(
                name: "ContactID",
                table: "Email");

            migrationBuilder.CreateIndex(
                name: "IX_Contact_EmailID",
                table: "Contact",
                column: "EmailID");

            migrationBuilder.CreateIndex(
                name: "IX_Contact_PhoneID",
                table: "Contact",
                column: "PhoneID");

            migrationBuilder.AddForeignKey(
                name: "FK_Contact_Email_EmailID",
                table: "Contact",
                column: "EmailID",
                principalTable: "Email",
                principalColumn: "EmailID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Contact_Phone_PhoneID",
                table: "Contact",
                column: "PhoneID",
                principalTable: "Phone",
                principalColumn: "PhoneID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contact_Email_EmailID",
                table: "Contact");

            migrationBuilder.DropForeignKey(
                name: "FK_Contact_Phone_PhoneID",
                table: "Contact");

            migrationBuilder.DropIndex(
                name: "IX_Contact_EmailID",
                table: "Contact");

            migrationBuilder.DropIndex(
                name: "IX_Contact_PhoneID",
                table: "Contact");

            migrationBuilder.AddColumn<int>(
                name: "ContactID",
                table: "Phone",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ContactID",
                table: "Email",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Phone_ContactID",
                table: "Phone",
                column: "ContactID");

            migrationBuilder.CreateIndex(
                name: "IX_Email_ContactID",
                table: "Email",
                column: "ContactID");

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
    }
}
