using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Proje.DataAccess.Migrations
{
    public partial class ilk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Photo",
                columns: table => new
                {
                    PhotoID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Photos = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    PhotoSize = table.Column<int>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Time = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photo", x => x.PhotoID);
                });

            migrationBuilder.CreateTable(
                name: "RegisterTemp",
                columns: table => new
                {
                    RegisterTempID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    SurName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Gender = table.Column<bool>(nullable: false),
                    IsStudent = table.Column<bool>(nullable: false),
                    City = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true),
                    Role = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegisterTemp", x => x.RegisterTempID);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Surname = table.Column<string>(nullable: true),
                    Gender = table.Column<bool>(nullable: false),
                    Token = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "Advert",
                columns: table => new
                {
                    AdvertID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Price = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    Time = table.Column<DateTime>(nullable: false),
                    AdvertOr = table.Column<bool>(nullable: false),
                    UserID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Advert", x => x.AdvertID);
                    table.ForeignKey(
                        name: "FK_Advert_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Avatar",
                columns: table => new
                {
                    AvatarID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Photo = table.Column<string>(nullable: true),
                    Type = table.Column<int>(nullable: false),
                    UserID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Avatar", x => x.AvatarID);
                    table.ForeignKey(
                        name: "FK_Avatar_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Contact",
                columns: table => new
                {
                    ContactID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Email = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    UserID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contact", x => x.ContactID);
                    table.ForeignKey(
                        name: "FK_Contact_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Message",
                columns: table => new
                {
                    MessageID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    To = table.Column<int>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Body = table.Column<int>(nullable: false),
                    From = table.Column<int>(nullable: false),
                    IsRead = table.Column<bool>(nullable: false),
                    Time = table.Column<DateTime>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    UserID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Message", x => x.MessageID);
                    table.ForeignKey(
                        name: "FK_Message_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Password",
                columns: table => new
                {
                    PasswordId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Pass = table.Column<string>(nullable: true),
                    UserID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Password", x => x.PasswordId);
                    table.ForeignKey(
                        name: "FK_Password_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    RoleID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoleText = table.Column<string>(nullable: true),
                    UserID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.RoleID);
                    table.ForeignKey(
                        name: "FK_Role_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserLocation",
                columns: table => new
                {
                    UserLocationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LocationName = table.Column<int>(nullable: false),
                    LocationCoordinated = table.Column<int>(nullable: false),
                    UserID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLocation", x => x.UserLocationId);
                    table.ForeignKey(
                        name: "FK_UserLocation_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserStarAndComment",
                columns: table => new
                {
                    UserStarAndCommentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Rate = table.Column<int>(nullable: false),
                    Comment = table.Column<string>(nullable: true),
                    CommentToUserID = table.Column<int>(nullable: false),
                    CommentUserID = table.Column<int>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Time = table.Column<DateTime>(nullable: false),
                    UserID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserStarAndComment", x => x.UserStarAndCommentID);
                    table.ForeignKey(
                        name: "FK_UserStarAndComment_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserTime",
                columns: table => new
                {
                    UserTimeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LoginTime = table.Column<int>(nullable: false),
                    LoginDate = table.Column<int>(nullable: false),
                    LogoutTime = table.Column<int>(nullable: false),
                    LogoutDate = table.Column<int>(nullable: false),
                    UserID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTime", x => x.UserTimeID);
                    table.ForeignKey(
                        name: "FK_UserTime_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AdvertStatus",
                columns: table => new
                {
                    AdvertStatusID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    StatusText = table.Column<string>(nullable: true),
                    AdvertID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdvertStatus", x => x.AdvertStatusID);
                    table.ForeignKey(
                        name: "FK_AdvertStatus_Advert_AdvertID",
                        column: x => x.AdvertID,
                        principalTable: "Advert",
                        principalColumn: "AdvertID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    CategoryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CategoryName = table.Column<string>(nullable: true),
                    AdvertID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.CategoryID);
                    table.ForeignKey(
                        name: "FK_Category_Advert_AdvertID",
                        column: x => x.AdvertID,
                        principalTable: "Advert",
                        principalColumn: "AdvertID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    CityID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CityText = table.Column<string>(nullable: true),
                    Count = table.Column<int>(nullable: false),
                    AdvertID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.CityID);
                    table.ForeignKey(
                        name: "FK_City_Advert_AdvertID",
                        column: x => x.AdvertID,
                        principalTable: "Advert",
                        principalColumn: "AdvertID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SharedPhoto",
                columns: table => new
                {
                    SharedPhotoID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PhotoID = table.Column<int>(nullable: false),
                    AdvertID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SharedPhoto", x => x.SharedPhotoID);
                    table.ForeignKey(
                        name: "FK_SharedPhoto_Advert_AdvertID",
                        column: x => x.AdvertID,
                        principalTable: "Advert",
                        principalColumn: "AdvertID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SharedPhoto_Photo_PhotoID",
                        column: x => x.PhotoID,
                        principalTable: "Photo",
                        principalColumn: "PhotoID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Univercity",
                columns: table => new
                {
                    UnivercityID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UnivercityText = table.Column<int>(nullable: false),
                    AdvertID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Univercity", x => x.UnivercityID);
                    table.ForeignKey(
                        name: "FK_Univercity_Advert_AdvertID",
                        column: x => x.AdvertID,
                        principalTable: "Advert",
                        principalColumn: "AdvertID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Email",
                columns: table => new
                {
                    EmailID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EmailText = table.Column<string>(nullable: true),
                    ContactID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Email", x => x.EmailID);
                    table.ForeignKey(
                        name: "FK_Email_Contact_ContactID",
                        column: x => x.ContactID,
                        principalTable: "Contact",
                        principalColumn: "ContactID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Phone",
                columns: table => new
                {
                    PhoneID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PhoneText = table.Column<string>(nullable: true),
                    ContactID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phone", x => x.PhoneID);
                    table.ForeignKey(
                        name: "FK_Phone_Contact_ContactID",
                        column: x => x.ContactID,
                        principalTable: "Contact",
                        principalColumn: "ContactID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OldPasswords",
                columns: table => new
                {
                    OldPasswordID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    OldPass = table.Column<int>(nullable: false),
                    UserID = table.Column<int>(nullable: false),
                    PasswordId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OldPasswords", x => x.OldPasswordID);
                    table.ForeignKey(
                        name: "FK_OldPasswords_Password_PasswordId",
                        column: x => x.PasswordId,
                        principalTable: "Password",
                        principalColumn: "PasswordId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OldPasswords_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserPassword",
                columns: table => new
                {
                    UserPasswordID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PasswordId = table.Column<int>(nullable: false),
                    UserID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserPassword", x => x.UserPasswordID);
                    table.ForeignKey(
                        name: "FK_UserPassword_Password_PasswordId",
                        column: x => x.PasswordId,
                        principalTable: "Password",
                        principalColumn: "PasswordId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserPassword_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UniCity",
                columns: table => new
                {
                    UniCityID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UnivercityID = table.Column<int>(nullable: false),
                    CityID = table.Column<int>(nullable: false),
                    AdvertID = table.Column<int>(nullable: false),
                    UserID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UniCity", x => x.UniCityID);
                    table.ForeignKey(
                        name: "FK_UniCity_Advert_AdvertID",
                        column: x => x.AdvertID,
                        principalTable: "Advert",
                        principalColumn: "AdvertID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UniCity_City_CityID",
                        column: x => x.CityID,
                        principalTable: "City",
                        principalColumn: "CityID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UniCity_Univercity_UnivercityID",
                        column: x => x.UnivercityID,
                        principalTable: "Univercity",
                        principalColumn: "UnivercityID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UniCity_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Advert_UserID",
                table: "Advert",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_AdvertStatus_AdvertID",
                table: "AdvertStatus",
                column: "AdvertID");

            migrationBuilder.CreateIndex(
                name: "IX_Avatar_UserID",
                table: "Avatar",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Category_AdvertID",
                table: "Category",
                column: "AdvertID");

            migrationBuilder.CreateIndex(
                name: "IX_City_AdvertID",
                table: "City",
                column: "AdvertID");

            migrationBuilder.CreateIndex(
                name: "IX_Contact_UserID",
                table: "Contact",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Email_ContactID",
                table: "Email",
                column: "ContactID");

            migrationBuilder.CreateIndex(
                name: "IX_Message_UserID",
                table: "Message",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_OldPasswords_PasswordId",
                table: "OldPasswords",
                column: "PasswordId");

            migrationBuilder.CreateIndex(
                name: "IX_OldPasswords_UserID",
                table: "OldPasswords",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Password_UserID",
                table: "Password",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Phone_ContactID",
                table: "Phone",
                column: "ContactID");

            migrationBuilder.CreateIndex(
                name: "IX_Role_UserID",
                table: "Role",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_SharedPhoto_AdvertID",
                table: "SharedPhoto",
                column: "AdvertID");

            migrationBuilder.CreateIndex(
                name: "IX_SharedPhoto_PhotoID",
                table: "SharedPhoto",
                column: "PhotoID");

            migrationBuilder.CreateIndex(
                name: "IX_UniCity_AdvertID",
                table: "UniCity",
                column: "AdvertID");

            migrationBuilder.CreateIndex(
                name: "IX_UniCity_CityID",
                table: "UniCity",
                column: "CityID");

            migrationBuilder.CreateIndex(
                name: "IX_UniCity_UnivercityID",
                table: "UniCity",
                column: "UnivercityID");

            migrationBuilder.CreateIndex(
                name: "IX_UniCity_UserID",
                table: "UniCity",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Univercity_AdvertID",
                table: "Univercity",
                column: "AdvertID");

            migrationBuilder.CreateIndex(
                name: "IX_UserLocation_UserID",
                table: "UserLocation",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_UserPassword_PasswordId",
                table: "UserPassword",
                column: "PasswordId");

            migrationBuilder.CreateIndex(
                name: "IX_UserPassword_UserID",
                table: "UserPassword",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_UserStarAndComment_UserID",
                table: "UserStarAndComment",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_UserTime_UserID",
                table: "UserTime",
                column: "UserID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdvertStatus");

            migrationBuilder.DropTable(
                name: "Avatar");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Email");

            migrationBuilder.DropTable(
                name: "Message");

            migrationBuilder.DropTable(
                name: "OldPasswords");

            migrationBuilder.DropTable(
                name: "Phone");

            migrationBuilder.DropTable(
                name: "RegisterTemp");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "SharedPhoto");

            migrationBuilder.DropTable(
                name: "UniCity");

            migrationBuilder.DropTable(
                name: "UserLocation");

            migrationBuilder.DropTable(
                name: "UserPassword");

            migrationBuilder.DropTable(
                name: "UserStarAndComment");

            migrationBuilder.DropTable(
                name: "UserTime");

            migrationBuilder.DropTable(
                name: "Contact");

            migrationBuilder.DropTable(
                name: "Photo");

            migrationBuilder.DropTable(
                name: "City");

            migrationBuilder.DropTable(
                name: "Univercity");

            migrationBuilder.DropTable(
                name: "Password");

            migrationBuilder.DropTable(
                name: "Advert");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
