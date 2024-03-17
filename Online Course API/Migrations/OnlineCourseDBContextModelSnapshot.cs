﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Online_Course_API.Model;

#nullable disable

namespace Online_Course_API.Migrations
{
    [DbContext(typeof(OnlineCourseDBContext))]
    partial class OnlineCourseDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

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

            modelBuilder.Entity("Online_Course_API.Model.ApplicationUser", b =>
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

            modelBuilder.Entity("Online_Course_API.Model.Choise", b =>
                {
                    b.Property<int>("Choise_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Choise_ID"));

                    b.Property<bool>("IsCorrect")
                        .HasColumnType("bit");

                    b.Property<int>("Question_ID")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Choise_ID");

                    b.HasIndex("Question_ID");

                    b.ToTable("Choises");
                });

            modelBuilder.Entity("Online_Course_API.Model.Course", b =>
                {
                    b.Property<int>("Course_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Course_ID"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<int>("Grade_ID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.HasKey("Course_ID");

                    b.HasIndex("Grade_ID");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("Online_Course_API.Model.Grade", b =>
                {
                    b.Property<int>("Grade_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Grade_ID"));

                    b.Property<string>("Grade_Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Grade_ID");

                    b.ToTable("Grades");
                });

            modelBuilder.Entity("Online_Course_API.Model.Group", b =>
                {
                    b.Property<int>("Group_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Group_ID"));

                    b.Property<int>("Course_ID")
                        .HasColumnType("int");

                    b.Property<DateOnly>("Creation_Date")
                        .HasColumnType("date");

                    b.Property<DateOnly>("End_Date")
                        .HasColumnType("date");

                    b.Property<string>("GroupName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Instructor_ID")
                        .HasColumnType("int");

                    b.Property<int>("Num_Students")
                        .HasColumnType("int");

                    b.HasKey("Group_ID");

                    b.HasIndex("Course_ID");

                    b.HasIndex("Instructor_ID");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("Online_Course_API.Model.Instructor", b =>
                {
                    b.Property<int>("Instructor_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Instructor_ID"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("First_Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Last_Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Instructor_ID");

                    b.ToTable("Instructors");
                });

            modelBuilder.Entity("Online_Course_API.Model.Instructor_Course", b =>
                {
                    b.Property<int>("Instructor_ID")
                        .HasColumnType("int")
                        .HasColumnOrder(0);

                    b.Property<int>("Course_ID")
                        .HasColumnType("int")
                        .HasColumnOrder(1);

                    b.HasKey("Instructor_ID", "Course_ID");

                    b.HasIndex("Course_ID");

                    b.ToTable("Instructor_Courses");
                });

            modelBuilder.Entity("Online_Course_API.Model.Parent", b =>
                {
                    b.Property<int>("Parent_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Parent_ID"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("First_Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Last_Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Parent_ID");

                    b.ToTable("Parents");
                });

            modelBuilder.Entity("Online_Course_API.Model.Question", b =>
                {
                    b.Property<int>("Question_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Question_ID"));

                    b.Property<string>("Question_Text")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("Quiz_ID")
                        .HasColumnType("int");

                    b.HasKey("Question_ID");

                    b.HasIndex("Quiz_ID");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("Online_Course_API.Model.Quiz", b =>
                {
                    b.Property<int>("Quiz_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Quiz_ID"));

                    b.Property<int>("Course_ID")
                        .HasColumnType("int");

                    b.Property<int>("Instructor_ID")
                        .HasColumnType("int");

                    b.Property<string>("Quiz_Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Quiz_ID");

                    b.HasIndex("Course_ID");

                    b.HasIndex("Instructor_ID");

                    b.ToTable("Quizzes");
                });

            modelBuilder.Entity("Online_Course_API.Model.Session", b =>
                {
                    b.Property<int>("Session_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Session_ID"));

                    b.Property<DateTime>("End_at")
                        .HasColumnType("datetime2");

                    b.Property<int>("Group_ID")
                        .HasColumnType("int");

                    b.Property<int?>("Instructor_ID")
                        .HasColumnType("int");

                    b.Property<float>("Rate")
                        .HasColumnType("real");

                    b.Property<string>("SessionName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("Start_Date")
                        .HasColumnType("datetime2");

                    b.HasKey("Session_ID");

                    b.HasIndex("Group_ID");

                    b.HasIndex("Instructor_ID");

                    b.ToTable("Sessions");
                });

            modelBuilder.Entity("Online_Course_API.Model.Student", b =>
                {
                    b.Property<int>("Student_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Student_ID"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("First_Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Last_Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Parent_ID")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Student_ID");

                    b.HasIndex("Parent_ID");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("Online_Course_API.Model.Student_Course", b =>
                {
                    b.Property<int>("Student_ID")
                        .HasColumnType("int")
                        .HasColumnOrder(0);

                    b.Property<int>("Course_ID")
                        .HasColumnType("int")
                        .HasColumnOrder(1);

                    b.Property<DateTime>("Enroll_Date")
                        .HasColumnType("datetime2");

                    b.HasKey("Student_ID", "Course_ID");

                    b.HasIndex("Course_ID");

                    b.ToTable("Student_Courses");
                });

            modelBuilder.Entity("Online_Course_API.Model.Student_Group", b =>
                {
                    b.Property<int>("Student_ID")
                        .HasColumnType("int")
                        .HasColumnOrder(0);

                    b.Property<int>("Group_ID")
                        .HasColumnType("int")
                        .HasColumnOrder(1);

                    b.HasKey("Student_ID", "Group_ID");

                    b.HasIndex("Group_ID");

                    b.ToTable("Student_Groups");
                });

            modelBuilder.Entity("Online_Course_API.Model.Student_Question", b =>
                {
                    b.Property<int>("Student_ID")
                        .HasColumnType("int")
                        .HasColumnOrder(0);

                    b.Property<int>("Question_ID")
                        .HasColumnType("int")
                        .HasColumnOrder(1);

                    b.Property<string>("St_Answer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Student_ID", "Question_ID");

                    b.HasIndex("Question_ID");

                    b.ToTable("Student_Questions");
                });

            modelBuilder.Entity("Online_Course_API.Model.Student_Quiz", b =>
                {
                    b.Property<int>("Student_ID")
                        .HasColumnType("int")
                        .HasColumnOrder(0);

                    b.Property<int>("Quiz_ID")
                        .HasColumnType("int")
                        .HasColumnOrder(1);

                    b.Property<float>("Grade")
                        .HasColumnType("real");

                    b.HasKey("Student_ID", "Quiz_ID");

                    b.HasIndex("Quiz_ID");

                    b.ToTable("Student_Quizzes");
                });

            modelBuilder.Entity("Online_Course_API.Model.Student_Session", b =>
                {
                    b.Property<int>("Student_ID")
                        .HasColumnType("int")
                        .HasColumnOrder(0);

                    b.Property<int>("Session_ID")
                        .HasColumnType("int")
                        .HasColumnOrder(1);

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<float>("Rate")
                        .HasColumnType("real");

                    b.HasKey("Student_ID", "Session_ID");

                    b.HasIndex("Session_ID");

                    b.ToTable("Student_Sessions");
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
                    b.HasOne("Online_Course_API.Model.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Online_Course_API.Model.ApplicationUser", null)
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

                    b.HasOne("Online_Course_API.Model.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Online_Course_API.Model.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Online_Course_API.Model.Choise", b =>
                {
                    b.HasOne("Online_Course_API.Model.Question", "Question")
                        .WithMany("Choises")
                        .HasForeignKey("Question_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Question");
                });

            modelBuilder.Entity("Online_Course_API.Model.Course", b =>
                {
                    b.HasOne("Online_Course_API.Model.Grade", "Grade")
                        .WithMany("Courses")
                        .HasForeignKey("Grade_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Grade");
                });

            modelBuilder.Entity("Online_Course_API.Model.Group", b =>
                {
                    b.HasOne("Online_Course_API.Model.Course", "Course")
                        .WithMany("Groups")
                        .HasForeignKey("Course_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Online_Course_API.Model.Instructor", "Instructor")
                        .WithMany("Groups")
                        .HasForeignKey("Instructor_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Instructor");
                });

            modelBuilder.Entity("Online_Course_API.Model.Instructor_Course", b =>
                {
                    b.HasOne("Online_Course_API.Model.Course", "Course")
                        .WithMany("Instructor_Courses")
                        .HasForeignKey("Course_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Online_Course_API.Model.Instructor", "Instructor")
                        .WithMany("Instructor_Courses")
                        .HasForeignKey("Instructor_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Instructor");
                });

            modelBuilder.Entity("Online_Course_API.Model.Question", b =>
                {
                    b.HasOne("Online_Course_API.Model.Quiz", "Quiz")
                        .WithMany("Questions")
                        .HasForeignKey("Quiz_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Quiz");
                });

            modelBuilder.Entity("Online_Course_API.Model.Quiz", b =>
                {
                    b.HasOne("Online_Course_API.Model.Course", "Course")
                        .WithMany("Quizzes")
                        .HasForeignKey("Course_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Online_Course_API.Model.Instructor", "Instructor")
                        .WithMany("Quizzes")
                        .HasForeignKey("Instructor_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Instructor");
                });

            modelBuilder.Entity("Online_Course_API.Model.Session", b =>
                {
                    b.HasOne("Online_Course_API.Model.Group", "Group")
                        .WithMany("Sessions")
                        .HasForeignKey("Group_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Online_Course_API.Model.Instructor", "Instructor")
                        .WithMany("Sessions")
                        .HasForeignKey("Instructor_ID");

                    b.Navigation("Group");

                    b.Navigation("Instructor");
                });

            modelBuilder.Entity("Online_Course_API.Model.Student", b =>
                {
                    b.HasOne("Online_Course_API.Model.Parent", "Parent")
                        .WithMany("Students")
                        .HasForeignKey("Parent_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Parent");
                });

            modelBuilder.Entity("Online_Course_API.Model.Student_Course", b =>
                {
                    b.HasOne("Online_Course_API.Model.Course", "Course")
                        .WithMany("StudentCourses")
                        .HasForeignKey("Course_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Online_Course_API.Model.Student", "Student")
                        .WithMany("StudentCourses")
                        .HasForeignKey("Student_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Online_Course_API.Model.Student_Group", b =>
                {
                    b.HasOne("Online_Course_API.Model.Group", "Group")
                        .WithMany("StudentGroups")
                        .HasForeignKey("Group_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Online_Course_API.Model.Student", "Student")
                        .WithMany("StudentGroups")
                        .HasForeignKey("Student_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Group");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Online_Course_API.Model.Student_Question", b =>
                {
                    b.HasOne("Online_Course_API.Model.Question", "Question")
                        .WithMany("StudentQuestions")
                        .HasForeignKey("Question_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Online_Course_API.Model.Student", "Student")
                        .WithMany("StudentQuestions")
                        .HasForeignKey("Student_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Question");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Online_Course_API.Model.Student_Quiz", b =>
                {
                    b.HasOne("Online_Course_API.Model.Quiz", "Quiz")
                        .WithMany("StudentQuizzes")
                        .HasForeignKey("Quiz_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Online_Course_API.Model.Student", "Student")
                        .WithMany("StudentQuizzes")
                        .HasForeignKey("Student_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Quiz");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Online_Course_API.Model.Student_Session", b =>
                {
                    b.HasOne("Online_Course_API.Model.Session", "Session")
                        .WithMany("StudentSessions")
                        .HasForeignKey("Session_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Online_Course_API.Model.Student", "Student")
                        .WithMany("StudentSessions")
                        .HasForeignKey("Student_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Session");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Online_Course_API.Model.Course", b =>
                {
                    b.Navigation("Groups");

                    b.Navigation("Instructor_Courses");

                    b.Navigation("Quizzes");

                    b.Navigation("StudentCourses");
                });

            modelBuilder.Entity("Online_Course_API.Model.Grade", b =>
                {
                    b.Navigation("Courses");
                });

            modelBuilder.Entity("Online_Course_API.Model.Group", b =>
                {
                    b.Navigation("Sessions");

                    b.Navigation("StudentGroups");
                });

            modelBuilder.Entity("Online_Course_API.Model.Instructor", b =>
                {
                    b.Navigation("Groups");

                    b.Navigation("Instructor_Courses");

                    b.Navigation("Quizzes");

                    b.Navigation("Sessions");
                });

            modelBuilder.Entity("Online_Course_API.Model.Parent", b =>
                {
                    b.Navigation("Students");
                });

            modelBuilder.Entity("Online_Course_API.Model.Question", b =>
                {
                    b.Navigation("Choises");

                    b.Navigation("StudentQuestions");
                });

            modelBuilder.Entity("Online_Course_API.Model.Quiz", b =>
                {
                    b.Navigation("Questions");

                    b.Navigation("StudentQuizzes");
                });

            modelBuilder.Entity("Online_Course_API.Model.Session", b =>
                {
                    b.Navigation("StudentSessions");
                });

            modelBuilder.Entity("Online_Course_API.Model.Student", b =>
                {
                    b.Navigation("StudentCourses");

                    b.Navigation("StudentGroups");

                    b.Navigation("StudentQuestions");

                    b.Navigation("StudentQuizzes");

                    b.Navigation("StudentSessions");
                });
#pragma warning restore 612, 618
        }
    }
}
