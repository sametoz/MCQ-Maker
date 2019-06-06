﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Proje.DataAccess.Context;

namespace Proje.DataAccess.Migrations
{
    [DbContext(typeof(ProjeContext))]
    [Migration("20190325123156_ilk")]
    partial class ilk
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Proje.DataAccess.Database.Advert", b =>
                {
                    b.Property<int>("AdvertID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("AdvertOr");

                    b.Property<DateTime>("Date");

                    b.Property<string>("Description");

                    b.Property<string>("Price");

                    b.Property<DateTime>("Time");

                    b.Property<string>("Title");

                    b.Property<int>("UserID");

                    b.HasKey("AdvertID");

                    b.HasIndex("UserID");

                    b.ToTable("Advert");
                });

            modelBuilder.Entity("Proje.DataAccess.Database.AdvertStatus", b =>
                {
                    b.Property<int>("AdvertStatusID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AdvertID");

                    b.Property<string>("StatusText");

                    b.HasKey("AdvertStatusID");

                    b.HasIndex("AdvertID");

                    b.ToTable("AdvertStatus");
                });

            modelBuilder.Entity("Proje.DataAccess.Database.Avatar", b =>
                {
                    b.Property<int>("AvatarID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Photo");

                    b.Property<int>("Type");

                    b.Property<int>("UserID");

                    b.HasKey("AvatarID");

                    b.HasIndex("UserID");

                    b.ToTable("Avatar");
                });

            modelBuilder.Entity("Proje.DataAccess.Database.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AdvertID");

                    b.Property<string>("CategoryName");

                    b.HasKey("CategoryID");

                    b.HasIndex("AdvertID");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("Proje.DataAccess.Database.City", b =>
                {
                    b.Property<int>("CityID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AdvertID");

                    b.Property<string>("CityText");

                    b.Property<int>("Count");

                    b.HasKey("CityID");

                    b.HasIndex("AdvertID");

                    b.ToTable("City");
                });

            modelBuilder.Entity("Proje.DataAccess.Database.Contact", b =>
                {
                    b.Property<int>("ContactID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email");

                    b.Property<string>("Phone");

                    b.Property<int>("UserID");

                    b.HasKey("ContactID");

                    b.HasIndex("UserID");

                    b.ToTable("Contact");
                });

            modelBuilder.Entity("Proje.DataAccess.Database.Email", b =>
                {
                    b.Property<int>("EmailID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ContactID");

                    b.Property<string>("EmailText");

                    b.HasKey("EmailID");

                    b.HasIndex("ContactID");

                    b.ToTable("Email");
                });

            modelBuilder.Entity("Proje.DataAccess.Database.Message", b =>
                {
                    b.Property<int>("MessageID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Body");

                    b.Property<DateTime>("Date");

                    b.Property<int>("From");

                    b.Property<bool>("IsRead");

                    b.Property<DateTime>("Time");

                    b.Property<string>("Title");

                    b.Property<int>("To");

                    b.Property<int>("UserID");

                    b.HasKey("MessageID");

                    b.HasIndex("UserID");

                    b.ToTable("Message");
                });

            modelBuilder.Entity("Proje.DataAccess.Database.OldPassword", b =>
                {
                    b.Property<int>("OldPasswordID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("OldPass");

                    b.Property<int>("PasswordId");

                    b.Property<int>("UserID");

                    b.HasKey("OldPasswordID");

                    b.HasIndex("PasswordId");

                    b.HasIndex("UserID");

                    b.ToTable("OldPasswords");
                });

            modelBuilder.Entity("Proje.DataAccess.Database.Password", b =>
                {
                    b.Property<int>("PasswordId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Pass");

                    b.Property<int?>("UserID");

                    b.HasKey("PasswordId");

                    b.HasIndex("UserID");

                    b.ToTable("Password");
                });

            modelBuilder.Entity("Proje.DataAccess.Database.Phone", b =>
                {
                    b.Property<int>("PhoneID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ContactID");

                    b.Property<string>("PhoneText");

                    b.HasKey("PhoneID");

                    b.HasIndex("ContactID");

                    b.ToTable("Phone");
                });

            modelBuilder.Entity("Proje.DataAccess.Database.Photo", b =>
                {
                    b.Property<int>("PhotoID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date");

                    b.Property<int>("PhotoSize");

                    b.Property<string>("Photos");

                    b.Property<DateTime>("Time");

                    b.Property<string>("Type");

                    b.HasKey("PhotoID");

                    b.ToTable("Photo");
                });

            modelBuilder.Entity("Proje.DataAccess.Database.RegisterTemp", b =>
                {
                    b.Property<int>("RegisterTempID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City");

                    b.Property<string>("Code");

                    b.Property<string>("Email");

                    b.Property<bool>("Gender");

                    b.Property<bool>("IsStudent");

                    b.Property<string>("Name");

                    b.Property<string>("Password");

                    b.Property<string>("Role");

                    b.Property<string>("SurName");

                    b.HasKey("RegisterTempID");

                    b.ToTable("RegisterTemp");
                });

            modelBuilder.Entity("Proje.DataAccess.Database.Role", b =>
                {
                    b.Property<int>("RoleID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("RoleText");

                    b.Property<int>("UserID");

                    b.HasKey("RoleID");

                    b.HasIndex("UserID");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("Proje.DataAccess.Database.SharedPhoto", b =>
                {
                    b.Property<int>("SharedPhotoID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AdvertID");

                    b.Property<int>("PhotoID");

                    b.HasKey("SharedPhotoID");

                    b.HasIndex("AdvertID");

                    b.HasIndex("PhotoID");

                    b.ToTable("SharedPhoto");
                });

            modelBuilder.Entity("Proje.DataAccess.Database.UniCity", b =>
                {
                    b.Property<int?>("UniCityID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AdvertID");

                    b.Property<int>("CityID");

                    b.Property<int>("UnivercityID");

                    b.Property<int>("UserID");

                    b.HasKey("UniCityID");

                    b.HasIndex("AdvertID");

                    b.HasIndex("CityID");

                    b.HasIndex("UnivercityID");

                    b.HasIndex("UserID");

                    b.ToTable("UniCity");
                });

            modelBuilder.Entity("Proje.DataAccess.Database.Univercity", b =>
                {
                    b.Property<int>("UnivercityID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AdvertID");

                    b.Property<int>("UnivercityText");

                    b.HasKey("UnivercityID");

                    b.HasIndex("AdvertID");

                    b.ToTable("Univercity");
                });

            modelBuilder.Entity("Proje.DataAccess.Database.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Gender");

                    b.Property<string>("Name");

                    b.Property<string>("Surname");

                    b.Property<string>("Token");

                    b.HasKey("UserID");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Proje.DataAccess.Database.UserLocation", b =>
                {
                    b.Property<int>("UserLocationId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("LocationCoordinated");

                    b.Property<int>("LocationName");

                    b.Property<int>("UserID");

                    b.HasKey("UserLocationId");

                    b.HasIndex("UserID");

                    b.ToTable("UserLocation");
                });

            modelBuilder.Entity("Proje.DataAccess.Database.UserPassword", b =>
                {
                    b.Property<int>("UserPasswordID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PasswordId");

                    b.Property<int>("UserID");

                    b.HasKey("UserPasswordID");

                    b.HasIndex("PasswordId");

                    b.HasIndex("UserID");

                    b.ToTable("UserPassword");
                });

            modelBuilder.Entity("Proje.DataAccess.Database.UserStarAndComment", b =>
                {
                    b.Property<int>("UserStarAndCommentID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comment");

                    b.Property<int>("CommentToUserID");

                    b.Property<int>("CommentUserID");

                    b.Property<DateTime>("Date");

                    b.Property<int>("Rate");

                    b.Property<DateTime>("Time");

                    b.Property<int>("UserID");

                    b.HasKey("UserStarAndCommentID");

                    b.HasIndex("UserID");

                    b.ToTable("UserStarAndComment");
                });

            modelBuilder.Entity("Proje.DataAccess.Database.UserTime", b =>
                {
                    b.Property<int>("UserTimeID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("LoginDate");

                    b.Property<int>("LoginTime");

                    b.Property<int>("LogoutDate");

                    b.Property<int>("LogoutTime");

                    b.Property<int>("UserID");

                    b.HasKey("UserTimeID");

                    b.HasIndex("UserID");

                    b.ToTable("UserTime");
                });

            modelBuilder.Entity("Proje.DataAccess.Database.Advert", b =>
                {
                    b.HasOne("Proje.DataAccess.Database.User", "User")
                        .WithMany()
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Proje.DataAccess.Database.AdvertStatus", b =>
                {
                    b.HasOne("Proje.DataAccess.Database.Advert", "Advert")
                        .WithMany("AdvertStatuses")
                        .HasForeignKey("AdvertID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Proje.DataAccess.Database.Avatar", b =>
                {
                    b.HasOne("Proje.DataAccess.Database.User", "User")
                        .WithMany("Avatar")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Proje.DataAccess.Database.Category", b =>
                {
                    b.HasOne("Proje.DataAccess.Database.Advert", "Advert")
                        .WithMany("Categories")
                        .HasForeignKey("AdvertID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Proje.DataAccess.Database.City", b =>
                {
                    b.HasOne("Proje.DataAccess.Database.Advert", "Advert")
                        .WithMany("Cities")
                        .HasForeignKey("AdvertID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Proje.DataAccess.Database.Contact", b =>
                {
                    b.HasOne("Proje.DataAccess.Database.User", "User")
                        .WithMany("Contact")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Proje.DataAccess.Database.Email", b =>
                {
                    b.HasOne("Proje.DataAccess.Database.Contact", "Contact")
                        .WithMany("Emails")
                        .HasForeignKey("ContactID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Proje.DataAccess.Database.Message", b =>
                {
                    b.HasOne("Proje.DataAccess.Database.User", "User")
                        .WithMany("Message")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Proje.DataAccess.Database.OldPassword", b =>
                {
                    b.HasOne("Proje.DataAccess.Database.Password", "Password")
                        .WithMany("OldPassword")
                        .HasForeignKey("PasswordId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Proje.DataAccess.Database.User", "User")
                        .WithMany("OldPassword")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Proje.DataAccess.Database.Password", b =>
                {
                    b.HasOne("Proje.DataAccess.Database.User")
                        .WithMany("Password")
                        .HasForeignKey("UserID");
                });

            modelBuilder.Entity("Proje.DataAccess.Database.Phone", b =>
                {
                    b.HasOne("Proje.DataAccess.Database.Contact", "Contact")
                        .WithMany("Phones")
                        .HasForeignKey("ContactID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Proje.DataAccess.Database.Role", b =>
                {
                    b.HasOne("Proje.DataAccess.Database.User", "User")
                        .WithMany("Role")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Proje.DataAccess.Database.SharedPhoto", b =>
                {
                    b.HasOne("Proje.DataAccess.Database.Advert", "Advert")
                        .WithMany("SharedPhotos")
                        .HasForeignKey("AdvertID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Proje.DataAccess.Database.Photo", "Photo")
                        .WithMany("SharedPhotos")
                        .HasForeignKey("PhotoID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Proje.DataAccess.Database.UniCity", b =>
                {
                    b.HasOne("Proje.DataAccess.Database.Advert", "Advert")
                        .WithMany("UniCities")
                        .HasForeignKey("AdvertID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Proje.DataAccess.Database.City", "City")
                        .WithMany("UniCities")
                        .HasForeignKey("CityID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Proje.DataAccess.Database.Univercity", "Univercity")
                        .WithMany("UniCities")
                        .HasForeignKey("UnivercityID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Proje.DataAccess.Database.User", "User")
                        .WithMany("UniCities")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Proje.DataAccess.Database.Univercity", b =>
                {
                    b.HasOne("Proje.DataAccess.Database.Advert", "Advert")
                        .WithMany("Univercities")
                        .HasForeignKey("AdvertID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Proje.DataAccess.Database.UserLocation", b =>
                {
                    b.HasOne("Proje.DataAccess.Database.User", "User")
                        .WithMany("UserLocation")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Proje.DataAccess.Database.UserPassword", b =>
                {
                    b.HasOne("Proje.DataAccess.Database.Password", "Password")
                        .WithMany("UserPassword")
                        .HasForeignKey("PasswordId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Proje.DataAccess.Database.User", "User")
                        .WithMany("UserPassword")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Proje.DataAccess.Database.UserStarAndComment", b =>
                {
                    b.HasOne("Proje.DataAccess.Database.User", "User")
                        .WithMany("UserStarAndComments")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Proje.DataAccess.Database.UserTime", b =>
                {
                    b.HasOne("Proje.DataAccess.Database.User", "User")
                        .WithMany("UserTime")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
