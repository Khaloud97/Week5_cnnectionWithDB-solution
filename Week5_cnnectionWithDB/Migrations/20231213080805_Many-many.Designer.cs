﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Week5_cnnectionWithDB.MyDbContext;

#nullable disable

namespace Week5_cnnectionWithDB.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231213080805_Many-many")]
    partial class Manymany
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EmployeeProjects", b =>
                {
                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<int>("ProjectsId")
                        .HasColumnType("int");

                    b.HasKey("EmployeeId", "ProjectsId");

                    b.HasIndex("ProjectsId");

                    b.ToTable("EmployeeProjects");
                });

            modelBuilder.Entity("Week5_cnnectionWithDB.Models.Departments", b =>
                {
                    b.Property<int>("DepId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DepId"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("floor")
                        .HasColumnType("int");

                    b.HasKey("DepId");

                    b.ToTable("Department");
                });

            modelBuilder.Entity("Week5_cnnectionWithDB.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeId"), 1L, 1);

                    b.Property<int?>("DepId")
                        .HasColumnType("int");

                    b.Property<int?>("EmployeeAge")
                        .HasColumnType("int");

                    b.Property<string>("EmployeeName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("EmployeeSalary")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("EmployeeId");

                    b.HasIndex("DepId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("Week5_cnnectionWithDB.Models.Projects", b =>
                {
                    b.Property<int>("ProjectsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProjectsId"), 1L, 1);

                    b.Property<string>("Discription")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("ProjectName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ProjectsId");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("EmployeeProjects", b =>
                {
                    b.HasOne("Week5_cnnectionWithDB.Models.Employee", null)
                        .WithMany()
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Week5_cnnectionWithDB.Models.Projects", null)
                        .WithMany()
                        .HasForeignKey("ProjectsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Week5_cnnectionWithDB.Models.Employee", b =>
                {
                    b.HasOne("Week5_cnnectionWithDB.Models.Departments", "Departments")
                        .WithMany("Employee")
                        .HasForeignKey("DepId");

                    b.Navigation("Departments");
                });

            modelBuilder.Entity("Week5_cnnectionWithDB.Models.Departments", b =>
                {
                    b.Navigation("Employee");
                });
#pragma warning restore 612, 618
        }
    }
}
