﻿// <auto-generated />
using System;
using FilRouge_Test_CodeFirst.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FilRougeTestCodeFirst.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230209230344_CreatedValidedEntity")]
    partial class CreatedValidedEntity
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FilRouge_Test_CodeFirst.Data.Entity.Level", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("LevelName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("levels");
                });

            modelBuilder.Entity("FilRouge_Test_CodeFirst.Data.Entity.Question", b =>
                {
                    b.Property<int>("QuestionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("QuestionId"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LevelId")
                        .HasColumnType("int");

                    b.Property<string>("QuestionAnswerIdentityUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("QuestionAnswerQuestionId")
                        .HasColumnType("int");

                    b.Property<int?>("QuestionAnswerTheAnswerId")
                        .HasColumnType("int");

                    b.Property<int>("Sujetid")
                        .HasColumnType("int");

                    b.HasKey("QuestionId");

                    b.HasIndex("LevelId");

                    b.HasIndex("Sujetid");

                    b.HasIndex("QuestionAnswerQuestionId", "QuestionAnswerTheAnswerId", "QuestionAnswerIdentityUserId");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("FilRouge_Test_CodeFirst.Data.Entity.QuestionAnswer", b =>
                {
                    b.Property<int>("QuestionId")
                        .HasColumnType("int");

                    b.Property<int>("TheAnswerId")
                        .HasColumnType("int");

                    b.Property<string>("IdentityUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("DateValidation")
                        .HasColumnType("datetime2");

                    b.HasKey("QuestionId", "TheAnswerId", "IdentityUserId");

                    b.HasIndex("IdentityUserId");

                    b.ToTable("QuestionsAnswers");
                });

            modelBuilder.Entity("FilRouge_Test_CodeFirst.Data.Entity.Quiz", b =>
                {
                    b.Property<int>("QuizzId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("QuizzId"));

                    b.Property<int?>("Average")
                        .HasColumnType("int");

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("LevelId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Sujetid")
                        .HasColumnType("int");

                    b.HasKey("QuizzId");

                    b.HasIndex("LevelId");

                    b.HasIndex("Sujetid");

                    b.ToTable("Quiz");
                });

            modelBuilder.Entity("FilRouge_Test_CodeFirst.Data.Entity.Sujet", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("SujetName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("sujets");
                });

            modelBuilder.Entity("FilRouge_Test_CodeFirst.Data.Entity.Tested", b =>
                {
                    b.Property<int>("QuizzId")
                        .HasColumnType("int");

                    b.Property<string>("IdentityUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("TestedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("QuizzId", "IdentityUserId");

                    b.HasIndex("IdentityUserId");

                    b.ToTable("tests");
                });

            modelBuilder.Entity("FilRouge_Test_CodeFirst.Data.Entity.TheAnswer", b =>
                {
                    b.Property<int>("TheAnswerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TheAnswerId"));

                    b.Property<string>("Answers")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QuestionAnswerIdentityUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("QuestionAnswerQuestionId")
                        .HasColumnType("int");

                    b.Property<int?>("QuestionAnswerTheAnswerId")
                        .HasColumnType("int");

                    b.Property<string>("ValidedIdentityUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("ValidedTheAnswerId")
                        .HasColumnType("int");

                    b.HasKey("TheAnswerId");

                    b.HasIndex("ValidedTheAnswerId", "ValidedIdentityUserId");

                    b.HasIndex("QuestionAnswerQuestionId", "QuestionAnswerTheAnswerId", "QuestionAnswerIdentityUserId");

                    b.ToTable("theAnswers");
                });

            modelBuilder.Entity("FilRouge_Test_CodeFirst.Data.Entity.Valided", b =>
                {
                    b.Property<int>("TheAnswerId")
                        .HasColumnType("int");

                    b.Property<string>("IdentityUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("ValidedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("TheAnswerId", "IdentityUserId");

                    b.HasIndex("IdentityUserId");

                    b.ToTable("valides");
                });

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

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

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

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

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

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("QuestionQuiz", b =>
                {
                    b.Property<int>("QuestionsQuestionId")
                        .HasColumnType("int");

                    b.Property<int>("QuizzId")
                        .HasColumnType("int");

                    b.HasKey("QuestionsQuestionId", "QuizzId");

                    b.HasIndex("QuizzId");

                    b.ToTable("QuestionQuiz");
                });

            modelBuilder.Entity("FilRouge_Test_CodeFirst.Data.Entity.Question", b =>
                {
                    b.HasOne("FilRouge_Test_CodeFirst.Data.Entity.Level", "Level")
                        .WithMany()
                        .HasForeignKey("LevelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FilRouge_Test_CodeFirst.Data.Entity.Sujet", "Sujet")
                        .WithMany()
                        .HasForeignKey("Sujetid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FilRouge_Test_CodeFirst.Data.Entity.QuestionAnswer", null)
                        .WithMany("Questions")
                        .HasForeignKey("QuestionAnswerQuestionId", "QuestionAnswerTheAnswerId", "QuestionAnswerIdentityUserId");

                    b.Navigation("Level");

                    b.Navigation("Sujet");
                });

            modelBuilder.Entity("FilRouge_Test_CodeFirst.Data.Entity.QuestionAnswer", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "IdentityUser")
                        .WithMany()
                        .HasForeignKey("IdentityUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("IdentityUser");
                });

            modelBuilder.Entity("FilRouge_Test_CodeFirst.Data.Entity.Quiz", b =>
                {
                    b.HasOne("FilRouge_Test_CodeFirst.Data.Entity.Level", "Level")
                        .WithMany()
                        .HasForeignKey("LevelId");

                    b.HasOne("FilRouge_Test_CodeFirst.Data.Entity.Sujet", "Sujet")
                        .WithMany()
                        .HasForeignKey("Sujetid");

                    b.Navigation("Level");

                    b.Navigation("Sujet");
                });

            modelBuilder.Entity("FilRouge_Test_CodeFirst.Data.Entity.Tested", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "IdentityUser")
                        .WithMany()
                        .HasForeignKey("IdentityUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FilRouge_Test_CodeFirst.Data.Entity.Quiz", "Quiz")
                        .WithMany()
                        .HasForeignKey("QuizzId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("IdentityUser");

                    b.Navigation("Quiz");
                });

            modelBuilder.Entity("FilRouge_Test_CodeFirst.Data.Entity.TheAnswer", b =>
                {
                    b.HasOne("FilRouge_Test_CodeFirst.Data.Entity.Valided", null)
                        .WithMany("TheAnswers")
                        .HasForeignKey("ValidedTheAnswerId", "ValidedIdentityUserId");

                    b.HasOne("FilRouge_Test_CodeFirst.Data.Entity.QuestionAnswer", null)
                        .WithMany("TheAnswers")
                        .HasForeignKey("QuestionAnswerQuestionId", "QuestionAnswerTheAnswerId", "QuestionAnswerIdentityUserId");
                });

            modelBuilder.Entity("FilRouge_Test_CodeFirst.Data.Entity.Valided", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "IdentityUser")
                        .WithMany()
                        .HasForeignKey("IdentityUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("IdentityUser");
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

            modelBuilder.Entity("QuestionQuiz", b =>
                {
                    b.HasOne("FilRouge_Test_CodeFirst.Data.Entity.Question", null)
                        .WithMany()
                        .HasForeignKey("QuestionsQuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FilRouge_Test_CodeFirst.Data.Entity.Quiz", null)
                        .WithMany()
                        .HasForeignKey("QuizzId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FilRouge_Test_CodeFirst.Data.Entity.QuestionAnswer", b =>
                {
                    b.Navigation("Questions");

                    b.Navigation("TheAnswers");
                });

            modelBuilder.Entity("FilRouge_Test_CodeFirst.Data.Entity.Valided", b =>
                {
                    b.Navigation("TheAnswers");
                });
#pragma warning restore 612, 618
        }
    }
}
