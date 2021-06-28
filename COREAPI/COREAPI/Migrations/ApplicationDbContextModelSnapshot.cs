﻿// <auto-generated />
using System;
using COREAPI;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace COREAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("COREAPI.Models.Department", b =>
                {
                    b.Property<int>("DepartmentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DepartmentName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DepartmentID");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            DepartmentID = 1,
                            DepartmentName = "IT"
                        },
                        new
                        {
                            DepartmentID = 2,
                            DepartmentName = "HR"
                        },
                        new
                        {
                            DepartmentID = 3,
                            DepartmentName = "Payroll"
                        },
                        new
                        {
                            DepartmentID = 4,
                            DepartmentName = "Admin"
                        });
                });

            modelBuilder.Entity("COREAPI.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DOB")
                        .HasColumnType("datetime2");

                    b.Property<int>("DepartmentID")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmployeeID");

                    b.HasIndex("DepartmentID");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            EmployeeID = 1,
                            Address = "London",
                            DOB = new DateTime(1980, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DepartmentID = 1,
                            Email = "David@pragimtech.com",
                            FirstName = "John",
                            Gender = 1,
                            LastName = "Hastings"
                        },
                        new
                        {
                            EmployeeID = 2,
                            Address = "Dhaka",
                            DOB = new DateTime(1981, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DepartmentID = 2,
                            Email = "Sam@pragimtech.com",
                            FirstName = "Sam",
                            Gender = 1,
                            LastName = "Galloway"
                        },
                        new
                        {
                            EmployeeID = 3,
                            Address = "Istambul",
                            DOB = new DateTime(1979, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DepartmentID = 1,
                            Email = "mary@pragimtech.com",
                            FirstName = "Mary",
                            Gender = 2,
                            LastName = "Smith"
                        },
                        new
                        {
                            EmployeeID = 4,
                            Address = "New York",
                            DOB = new DateTime(1982, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DepartmentID = 3,
                            Email = "sara@pragimtech.com",
                            FirstName = "Sara",
                            Gender = 2,
                            LastName = "Longway"
                        });
                });

            modelBuilder.Entity("COREAPI.Models.Employee", b =>
                {
                    b.HasOne("COREAPI.Models.Department", "Department")
                        .WithMany("Employees")
                        .HasForeignKey("DepartmentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("COREAPI.Models.Department", b =>
                {
                    b.Navigation("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}
