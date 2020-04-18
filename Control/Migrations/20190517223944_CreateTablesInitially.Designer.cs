﻿// <auto-generated />
using System;
using Control.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Control.Migrations
{
    [DbContext(typeof(ControlContext))]
    [Migration("20190517223944_CreateTablesInitially")]
    partial class CreateTablesInitially
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Control.Models.Admin", b =>
                {
                    b.Property<int>("AdminId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<string>("Password");

                    b.Property<string>("UserName");

                    b.HasKey("AdminId");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("Control.Models.Attendance", b =>
                {
                    b.Property<short>("AttendanceId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date");

                    b.Property<short>("StudentId");

                    b.HasKey("AttendanceId");

                    b.ToTable("Attendances");
                });

            modelBuilder.Entity("Control.Models.Course", b =>
                {
                    b.Property<short>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CourseDescription");

                    b.Property<string>("CourseName");

                    b.HasKey("CourseId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("Control.Models.Event", b =>
                {
                    b.Property<short>("EventId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<DateTime>("EventDate");

                    b.Property<string>("EventName");

                    b.Property<string>("Url");

                    b.HasKey("EventId");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("Control.Models.Student", b =>
                {
                    b.Property<short>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<short>("Age");

                    b.Property<string>("FutureCareerChoice");

                    b.Property<byte>("GceALevels");

                    b.Property<byte>("GceOLevels");

                    b.Property<string>("Name");

                    b.Property<string>("Password");

                    b.Property<string>("School");

                    b.Property<string>("Sex");

                    b.Property<string>("UserName");

                    b.Property<DateTime>("YearOfAttendance");

                    b.HasKey("StudentId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("Control.Models.Teach", b =>
                {
                    b.Property<short>("TeachId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<short>("CourseId");

                    b.Property<DateTime>("year");

                    b.HasKey("TeachId");

                    b.ToTable("Teaches");
                });

            modelBuilder.Entity("Control.Models.TestScore", b =>
                {
                    b.Property<int>("TestScoreId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CourseId");

                    b.Property<DateTime>("Date");

                    b.Property<int>("StudentId");

                    b.Property<float>("StudentScore");

                    b.HasKey("TestScoreId");

                    b.ToTable("TestScores");
                });

            modelBuilder.Entity("Control.Models.Tutor", b =>
                {
                    b.Property<short>("TutorId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Sex")
                        .IsRequired()
                        .HasConversion(new ValueConverter<string, string>(v => default(string), v => default(string), new ConverterMappingHints(size: 1)));

                    b.Property<short?>("TeachId");

                    b.Property<string>("TutorName");

                    b.Property<string>("Type");

                    b.HasKey("TutorId");

                    b.HasIndex("TeachId");

                    b.ToTable("Tutors");
                });

            modelBuilder.Entity("Control.Models.Tutor", b =>
                {
                    b.HasOne("Control.Models.Teach")
                        .WithMany("Tutors")
                        .HasForeignKey("TeachId");
                });
#pragma warning restore 612, 618
        }
    }
}
