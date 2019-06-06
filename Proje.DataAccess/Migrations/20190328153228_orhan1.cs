using Microsoft.EntityFrameworkCore.Migrations;

namespace Proje.DataAccess.Migrations
{
    public partial class orhan1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "Contact",
                newName: "PhoneID");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Contact",
                newName: "EmailID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PhoneID",
                table: "Contact",
                newName: "Phone");

            migrationBuilder.RenameColumn(
                name: "EmailID",
                table: "Contact",
                newName: "Email");
        }
    }
}
