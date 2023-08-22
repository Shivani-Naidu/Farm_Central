﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ST10084788_PROG7311_POE.Data;

namespace ST10084788_PROG7311_POE.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230529021036_AdminUser")]
    partial class AdminUser
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = "1",
                            ConcurrencyStamp = "0f04af19-0973-477c-8be3-73c829483872",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "2",
                            ConcurrencyStamp = "54acff12-76bf-48fd-9262-658eb1a264db",
                            Name = "Employee",
                            NormalizedName = "EMPLOYEE"
                        },
                        new
                        {
                            Id = "3",
                            ConcurrencyStamp = "b5f2016f-efb2-479e-b62f-e5666aa4fe60",
                            Name = "Farmer",
                            NormalizedName = "FARMER"
                        },
                        new
                        {
                            Id = "4",
                            ConcurrencyStamp = "cf51fb41-9452-4ea0-b469-c578eb8e04c7",
                            Name = "Customer",
                            NormalizedName = "CUSTOMER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new
                        {
                            Id = "1",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "e847fc76-d601-4208-a8ee-d66f8adbbea5",
                            Email = "admin1@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN1@GMAIL.COM",
                            NormalizedUserName = "ADMIN1",
                            PasswordHash = "AQAAAAEAACcQAAAAEGcqBGuHH8mz04yYQJMwPIAomaVW5kIIpcr+XPqD8JcGJenEdCb6EPe4o6mB8juQHA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "f0f101d1-a47d-4bce-9d2e-cf38a8c7c019",
                            TwoFactorEnabled = false,
                            UserName = "Admin1"
                        },
                        new
                        {
                            Id = "2",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "9ab15f93-46da-4e6f-9676-76c5d7eb72c3",
                            Email = "employee1@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "EMPLOYEE1@GMAIL.COM",
                            NormalizedUserName = "EMPLOYEE1",
                            PasswordHash = "AQAAAAEAACcQAAAAEGOYUkjO8GnVFdU0rHYroHzt7ZaibuhByPNH/w6p3BaRgHr+Mo7JQJBqcgjR64EOFQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "e839e992-f2b8-4382-a44e-4060011251c3",
                            TwoFactorEnabled = false,
                            UserName = "Employee1"
                        },
                        new
                        {
                            Id = "3",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "d6f2d03c-75bb-40e7-844c-04625a1a4e31",
                            Email = "farmer1@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "FARMER1@GMAIL.COM",
                            NormalizedUserName = "FARMER1",
                            PasswordHash = "AQAAAAEAACcQAAAAEC2PQvSdBq7z++Bx/rCRMqTd672/m+FLyUvU31mhZ8fmSp7Kt23Zt2gNovB/kInEFA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "87a6046d-4d33-4bf8-bf3c-3073d1e9e7a2",
                            TwoFactorEnabled = false,
                            UserName = "Farmer1"
                        },
                        new
                        {
                            Id = "4",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "f93a2f42-6fba-4edc-a71c-deaeab392804",
                            Email = "farmer2@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "FARMER2@GMAIL.COM",
                            NormalizedUserName = "FARMER2",
                            PasswordHash = "AQAAAAEAACcQAAAAEGZI/CgwHCdFgCW4j04RrhMvKmvEOaNVzQorLEPFEHVF9gxhcVn0rPpsKZz+RQAFKA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "0b4dcd47-aa66-4c02-9daa-a81bf7cadeba",
                            TwoFactorEnabled = false,
                            UserName = "Farmer2"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");

                    b.HasData(
                        new
                        {
                            UserId = "1",
                            RoleId = "1"
                        },
                        new
                        {
                            UserId = "2",
                            RoleId = "2"
                        },
                        new
                        {
                            UserId = "3",
                            RoleId = "3"
                        },
                        new
                        {
                            UserId = "4",
                            RoleId = "3"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("ST10084788_PROG7311_POE.Models.Product", b =>
                {
                    b.Property<int>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("datetime2");

                    b.Property<string>("FarmerID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ProductCategory")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductDesc")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<string>("ProductImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("ProductID");

                    b.ToTable("Product");

                    b.HasData(
                        new
                        {
                            ProductID = 1,
                            DateAdded = new DateTime(2023, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FarmerID = "3",
                            Price = 30m,
                            ProductCategory = "Vegetable",
                            ProductDesc = "Freshly Harvested Spring Onions",
                            ProductImage = "https://www.foodandwine.com/thmb/mlUUeD3gpRZQq2qUs8nead6QAYY=/1500x0/filters:no_upscale():max_bytes(150000):strip_icc()/The-Difference-Between-Green-Onions-FT-3-BLOG0622-3e3086b7871d44309f4d64dfe8536e00.jpg",
                            ProductName = "Spring Onions",
                            Quantity = 15
                        },
                        new
                        {
                            ProductID = 2,
                            DateAdded = new DateTime(2023, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FarmerID = "3",
                            Price = 20m,
                            ProductCategory = "Fruit",
                            ProductDesc = "Freshly Harvested Strawberries",
                            ProductImage = "https://www.dispatch.com/gcdn/presto/2022/05/10/NCOD/0a1efdfc-bc59-40bb-9007-f6a875ae1b0a-strawberries_in_rows.JPG",
                            ProductName = "Strawberries",
                            Quantity = 30
                        },
                        new
                        {
                            ProductID = 3,
                            DateAdded = new DateTime(2023, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FarmerID = "3",
                            Price = 25m,
                            ProductCategory = "Fruit",
                            ProductDesc = "Freshly Harvested Pineapples",
                            ProductImage = "https://media6.ppl-media.com/mediafiles/blogs/pineapple_6439817058.jpg",
                            ProductName = "Pineapples",
                            Quantity = 20
                        },
                        new
                        {
                            ProductID = 4,
                            DateAdded = new DateTime(2023, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FarmerID = "3",
                            Price = 10m,
                            ProductCategory = "Fruit",
                            ProductDesc = "Freshly Harvested Peaches",
                            ProductImage = "https://extension.usu.edu/nutrition/images/peaches.png",
                            ProductName = "Peaches",
                            Quantity = 20
                        },
                        new
                        {
                            ProductID = 5,
                            DateAdded = new DateTime(2023, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FarmerID = "4",
                            Price = 15m,
                            ProductCategory = "Vegetable",
                            ProductDesc = "Freshly Harvested Carrots",
                            ProductImage = "https://www.almanac.com/sites/default/files/styles/or/public/image_nodes/carrots-table_popidar-ss.jpg?itok=-6KDefXK",
                            ProductName = "Carrots",
                            Quantity = 50
                        },
                        new
                        {
                            ProductID = 6,
                            DateAdded = new DateTime(2023, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FarmerID = "4",
                            Price = 25m,
                            ProductCategory = "Flowers and Plants",
                            ProductDesc = "Fresh Sunflowers",
                            ProductImage = "https://cdn.wikifarmer.com/wp-content/uploads/2022/06/Sunflower-History-Uses-and-Plant-information.jpg",
                            ProductName = "Sunflowers",
                            Quantity = 35
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}