﻿// <auto-generated />
using System;
using HrApp.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HrApp.Persistence.Migrations
{
    [DbContext(typeof(HrAppDbContext))]
    partial class HrAppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("HrApp.Domain.Entities.Advance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AdvanceTypeId")
                        .HasColumnType("int");

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("AppUserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("ApprovalDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ApprovalStatusId")
                        .HasColumnType("int");

                    b.Property<int>("CurrencyId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RequestDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AdvanceTypeId");

                    b.HasIndex("AppUserId");

                    b.HasIndex("ApprovalStatusId");

                    b.HasIndex("CurrencyId");

                    b.ToTable("Advance");
                });

            modelBuilder.Entity("HrApp.Domain.Entities.AdvanceType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AdvanceType");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Bireysel"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Kurumsal"
                        });
                });

            modelBuilder.Entity("HrApp.Domain.Entities.AppRole", b =>
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

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "a6093bb0-3d6c-46fd-a83f-8cc8709094fd",
                            ConcurrencyStamp = "2fce43f5-d4fa-414f-aa5a-581a8936f988",
                            Name = "Admin"
                        });
                });

            modelBuilder.Entity("HrApp.Domain.Entities.ApprovalStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ApprovalStatus");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Waiting..."
                        },
                        new
                        {
                            Id = 2,
                            Name = "Approved!"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Declined!"
                        });
                });

            modelBuilder.Entity("HrApp.Domain.Entities.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BirthPlace")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("BirthYear")
                        .HasColumnType("datetime2");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Department")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("GenderId")
                        .HasColumnType("int");

                    b.Property<byte[]>("ImageData")
                        .HasColumnType("varbinary(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("MobileNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("Occupation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<decimal>("Salary")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("SecondName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecondSurname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TurkishIdentificationNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<decimal>("YearlyAdvanceAmountLeft")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("YearlyLeaveDaysLeft")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GenderId");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "f64ec7c2-3104-4c8a-8605-181f9d922913",
                            AccessFailedCount = 0,
                            Address = "address1231231231232",
                            BirthPlace = "Istanbul",
                            BirthYear = new DateTime(1994, 1, 3, 11, 32, 0, 628, DateTimeKind.Local).AddTicks(2597),
                            CompanyName = "KOC",
                            ConcurrencyStamp = "fb572aba-19e0-4a0f-9e8b-367a7ca2d710",
                            Department = "IT",
                            Email = "user@gmail.com",
                            EmailConfirmed = true,
                            GenderId = 2,
                            LockoutEnabled = false,
                            MobileNumber = "5554443322",
                            Name = "user",
                            NormalizedEmail = "USER@GMAIL.COM",
                            NormalizedUserName = "USER1",
                            Occupation = "Formatçı",
                            PasswordHash = "AQAAAAEAACcQAAAAEE9dMjsXDht1cB8Ww9XRJZyaQ4+3pMZLexF3MSEU4kr/Og/hV/IVGXeeLQJx/h6qmw==",
                            PhoneNumberConfirmed = false,
                            Salary = 20000m,
                            SecurityStamp = "082a0376-a964-4664-af9a-0d47a0cb9337",
                            StartDate = new DateTime(2014, 1, 3, 11, 32, 0, 628, DateTimeKind.Local).AddTicks(2613),
                            Surname = "usersurname",
                            TurkishIdentificationNumber = "11111111111",
                            TwoFactorEnabled = false,
                            UserName = "user1",
                            YearlyAdvanceAmountLeft = 0m,
                            YearlyLeaveDaysLeft = 0
                        },
                        new
                        {
                            Id = "5044c498-2d3c-4aab-b08c-da4277d87e15",
                            AccessFailedCount = 0,
                            Address = "adminaddress1231231231232",
                            BirthPlace = "Ankara",
                            BirthYear = new DateTime(1974, 1, 3, 11, 32, 0, 637, DateTimeKind.Local).AddTicks(7069),
                            CompanyName = "KOC",
                            ConcurrencyStamp = "db0a8755-677a-49bc-ac07-b5e68c0964f4",
                            Department = "PATRON",
                            Email = "admin@gmail.com",
                            EmailConfirmed = true,
                            GenderId = 1,
                            LockoutEnabled = false,
                            MobileNumber = "5325323232",
                            Name = "adminname",
                            NormalizedEmail = "ADMIN@GMAIL.COM",
                            NormalizedUserName = "ADMIN",
                            Occupation = "PATRON",
                            PasswordHash = "AQAAAAEAACcQAAAAEB0DWxeMSV5pM0f8W0C8qWnvvf3yd2w2Ok5CYXNKar/lEJr2HGmqvNgL2wGIcJW06A==",
                            PhoneNumberConfirmed = false,
                            Salary = 500000m,
                            SecurityStamp = "2d6ac3d7-d214-426d-a6b6-132cf57e0381",
                            StartDate = new DateTime(2009, 1, 3, 11, 32, 0, 637, DateTimeKind.Local).AddTicks(7082),
                            Surname = "adminsurname",
                            TurkishIdentificationNumber = "22222222222",
                            TwoFactorEnabled = false,
                            UserName = "admin",
                            YearlyAdvanceAmountLeft = 0m,
                            YearlyLeaveDaysLeft = 0
                        });
                });

            modelBuilder.Entity("HrApp.Domain.Entities.Currency", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Currency");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "₺"
                        },
                        new
                        {
                            Id = 2,
                            Name = "€"
                        },
                        new
                        {
                            Id = 3,
                            Name = "$"
                        },
                        new
                        {
                            Id = 4,
                            Name = "£"
                        });
                });

            modelBuilder.Entity("HrApp.Domain.Entities.Expense", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("AppUserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("ApprovalDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ApprovalStatusId")
                        .HasColumnType("int");

                    b.Property<int>("CurrencyId")
                        .HasColumnType("int");

                    b.Property<byte[]>("Document")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<int>("ExpenseTypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AppUserId");

                    b.HasIndex("ApprovalStatusId");

                    b.HasIndex("CurrencyId");

                    b.HasIndex("ExpenseTypeId");

                    b.ToTable("Expense");
                });

            modelBuilder.Entity("HrApp.Domain.Entities.ExpenseType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ExpenseType");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Yeme-içme"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Eğitim"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Konaklama"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Seyahat"
                        });
                });

            modelBuilder.Entity("HrApp.Domain.Entities.Gender", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Gender");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Erkek"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Kadın"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Diğer"
                        });
                });

            modelBuilder.Entity("HrApp.Domain.Entities.Leave", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("AppUserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("ApprovalDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ApprovalStatusId")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("LeaveTypeId")
                        .HasColumnType("int");

                    b.Property<int>("NumDays")
                        .HasColumnType("int");

                    b.Property<DateTime>("RequestDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AppUserId");

                    b.HasIndex("ApprovalStatusId");

                    b.HasIndex("LeaveTypeId");

                    b.ToTable("Leave");
                });

            modelBuilder.Entity("HrApp.Domain.Entities.LeaveType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("LeaveTypeFocusId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumDays")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LeaveTypeFocusId");

                    b.ToTable("LeaveType");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            LeaveTypeFocusId = 3,
                            Name = "Yıllık",
                            NumDays = 1
                        },
                        new
                        {
                            Id = 2,
                            LeaveTypeFocusId = 2,
                            Name = "Doğum",
                            NumDays = 56
                        },
                        new
                        {
                            Id = 3,
                            LeaveTypeFocusId = 3,
                            Name = "Ölüm",
                            NumDays = 3
                        },
                        new
                        {
                            Id = 4,
                            LeaveTypeFocusId = 1,
                            Name = "Babalık",
                            NumDays = 5
                        },
                        new
                        {
                            Id = 5,
                            LeaveTypeFocusId = 3,
                            Name = "Evlilik",
                            NumDays = 3
                        });
                });

            modelBuilder.Entity("HrApp.Domain.Entities.LeaveTypeFocus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("LeaveTypeFocus");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Erkek"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Kadın"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Herkes"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "5044c498-2d3c-4aab-b08c-da4277d87e15",
                            RoleId = "a6093bb0-3d6c-46fd-a83f-8cc8709094fd"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("HrApp.Domain.Entities.Advance", b =>
                {
                    b.HasOne("HrApp.Domain.Entities.AdvanceType", "AdvanceType")
                        .WithMany("Advances")
                        .HasForeignKey("AdvanceTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HrApp.Domain.Entities.AppUser", "AppUser")
                        .WithMany("Advances")
                        .HasForeignKey("AppUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HrApp.Domain.Entities.ApprovalStatus", "ApprovalStatus")
                        .WithMany("Advances")
                        .HasForeignKey("ApprovalStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HrApp.Domain.Entities.Currency", "Currency")
                        .WithMany("Advances")
                        .HasForeignKey("CurrencyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AdvanceType");

                    b.Navigation("AppUser");

                    b.Navigation("ApprovalStatus");

                    b.Navigation("Currency");
                });

            modelBuilder.Entity("HrApp.Domain.Entities.AppUser", b =>
                {
                    b.HasOne("HrApp.Domain.Entities.Gender", "Gender")
                        .WithMany("AppUsers")
                        .HasForeignKey("GenderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Gender");
                });

            modelBuilder.Entity("HrApp.Domain.Entities.Expense", b =>
                {
                    b.HasOne("HrApp.Domain.Entities.AppUser", "AppUser")
                        .WithMany("Expenses")
                        .HasForeignKey("AppUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HrApp.Domain.Entities.ApprovalStatus", "ApprovalStatus")
                        .WithMany("Expenses")
                        .HasForeignKey("ApprovalStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HrApp.Domain.Entities.Currency", "Currency")
                        .WithMany("Expenses")
                        .HasForeignKey("CurrencyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HrApp.Domain.Entities.ExpenseType", "ExpenseType")
                        .WithMany("Expenses")
                        .HasForeignKey("ExpenseTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppUser");

                    b.Navigation("ApprovalStatus");

                    b.Navigation("Currency");

                    b.Navigation("ExpenseType");
                });

            modelBuilder.Entity("HrApp.Domain.Entities.Leave", b =>
                {
                    b.HasOne("HrApp.Domain.Entities.AppUser", "AppUser")
                        .WithMany("Leaves")
                        .HasForeignKey("AppUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HrApp.Domain.Entities.ApprovalStatus", "ApprovalStatus")
                        .WithMany("Leaves")
                        .HasForeignKey("ApprovalStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HrApp.Domain.Entities.LeaveType", "LeaveType")
                        .WithMany("Leaves")
                        .HasForeignKey("LeaveTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppUser");

                    b.Navigation("ApprovalStatus");

                    b.Navigation("LeaveType");
                });

            modelBuilder.Entity("HrApp.Domain.Entities.LeaveType", b =>
                {
                    b.HasOne("HrApp.Domain.Entities.LeaveTypeFocus", "LeaveTypeFocus")
                        .WithMany("LeaveTypes")
                        .HasForeignKey("LeaveTypeFocusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LeaveTypeFocus");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("HrApp.Domain.Entities.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("HrApp.Domain.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("HrApp.Domain.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("HrApp.Domain.Entities.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HrApp.Domain.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("HrApp.Domain.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HrApp.Domain.Entities.AdvanceType", b =>
                {
                    b.Navigation("Advances");
                });

            modelBuilder.Entity("HrApp.Domain.Entities.ApprovalStatus", b =>
                {
                    b.Navigation("Advances");

                    b.Navigation("Expenses");

                    b.Navigation("Leaves");
                });

            modelBuilder.Entity("HrApp.Domain.Entities.AppUser", b =>
                {
                    b.Navigation("Advances");

                    b.Navigation("Expenses");

                    b.Navigation("Leaves");
                });

            modelBuilder.Entity("HrApp.Domain.Entities.Currency", b =>
                {
                    b.Navigation("Advances");

                    b.Navigation("Expenses");
                });

            modelBuilder.Entity("HrApp.Domain.Entities.ExpenseType", b =>
                {
                    b.Navigation("Expenses");
                });

            modelBuilder.Entity("HrApp.Domain.Entities.Gender", b =>
                {
                    b.Navigation("AppUsers");
                });

            modelBuilder.Entity("HrApp.Domain.Entities.LeaveType", b =>
                {
                    b.Navigation("Leaves");
                });

            modelBuilder.Entity("HrApp.Domain.Entities.LeaveTypeFocus", b =>
                {
                    b.Navigation("LeaveTypes");
                });
#pragma warning restore 612, 618
        }
    }
}
