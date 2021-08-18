﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplicationHW1.Data;

namespace WebApplicationHW1.Migrations
{
    [DbContext(typeof(WebApplicationHW1Context))]
    [Migration("20210613220654_room")]
    partial class room
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApplicationHW1.Models.Course", b =>
                {
                    b.Property<int>("CourseID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CourseDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<string>("CourseNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(6)")
                        .HasMaxLength(6);

                    b.Property<string>("CourseTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<int>("Credits")
                        .HasColumnType("int");

                    b.Property<string>("Department")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("MeetingDayOne")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MeetingDayThree")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MeetingDayTwo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("MeetingEndTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("MeetingStartTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("RoomNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserInfoID")
                        .HasColumnType("int");

                    b.HasKey("CourseID");

                    b.HasIndex("UserInfoID");

                    b.ToTable("Course");
                });

            modelBuilder.Entity("WebApplicationHW1.Models.FileTable", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte[]>("UploadedFile")
                        .HasColumnType("varbinary(max)");

                    b.HasKey("ID");

                    b.ToTable("FileTable");
                });

            modelBuilder.Entity("WebApplicationHW1.Models.UserInfo", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccountType")
                        .HasColumnType("int");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("ConfirmPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("Link1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Link2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Link3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("StreetAddress")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Zip")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("ID");

                    b.ToTable("UserInfo");
                });

            modelBuilder.Entity("WebApplicationHW1.Models.Course", b =>
                {
                    b.HasOne("WebApplicationHW1.Models.UserInfo", null)
                        .WithMany("Courses")
                        .HasForeignKey("UserInfoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
