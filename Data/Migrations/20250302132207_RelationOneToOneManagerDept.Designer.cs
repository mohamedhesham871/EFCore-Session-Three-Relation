﻿// <auto-generated />
using System;
using EFCore_Session_Three_Relation;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EFCore_Session_Three_Relation.Data.Migrations
{
    [DbContext(typeof(ITIContext))]
    [Migration("20250302132207_RelationOneToOneManagerDept")]
    partial class RelationOneToOneManagerDept
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EFCore_Session_Three_Relation.Models.Course", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("topicID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("topicID");

                    b.ToTable("courses");
                });

            modelBuilder.Entity("EFCore_Session_Three_Relation.Models.Department", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateOnly>("HiringDate")
                        .HasColumnType("date");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("managerId")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("managerId")
                        .IsUnique();

                    b.ToTable("departments");
                });

            modelBuilder.Entity("EFCore_Session_Three_Relation.Models.Instructor", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("Bouns")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("HoureRate")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Salary")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("departmentId")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("departmentId");

                    b.ToTable("instructors");
                });

            modelBuilder.Entity("EFCore_Session_Three_Relation.Models.Student", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("FName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("students");
                });

            modelBuilder.Entity("EFCore_Session_Three_Relation.Models.Topic", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Topic");
                });

            modelBuilder.Entity("EFCore_Session_Three_Relation.Models.Course", b =>
                {
                    b.HasOne("EFCore_Session_Three_Relation.Models.Topic", "topic")
                        .WithMany("Course")
                        .HasForeignKey("topicID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("topic");
                });

            modelBuilder.Entity("EFCore_Session_Three_Relation.Models.Department", b =>
                {
                    b.HasOne("EFCore_Session_Three_Relation.Models.Instructor", "manager")
                        .WithOne("ManagerOfDept")
                        .HasForeignKey("EFCore_Session_Three_Relation.Models.Department", "managerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("manager");
                });

            modelBuilder.Entity("EFCore_Session_Three_Relation.Models.Instructor", b =>
                {
                    b.HasOne("EFCore_Session_Three_Relation.Models.Department", "department")
                        .WithMany("instructors")
                        .HasForeignKey("departmentId");

                    b.Navigation("department");
                });

            modelBuilder.Entity("EFCore_Session_Three_Relation.Models.Department", b =>
                {
                    b.Navigation("instructors");
                });

            modelBuilder.Entity("EFCore_Session_Three_Relation.Models.Instructor", b =>
                {
                    b.Navigation("ManagerOfDept");
                });

            modelBuilder.Entity("EFCore_Session_Three_Relation.Models.Topic", b =>
                {
                    b.Navigation("Course");
                });
#pragma warning restore 612, 618
        }
    }
}
