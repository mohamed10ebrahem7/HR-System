﻿// <auto-generated />
using System;
using HRSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HRSystem.Migrations
{
    [DbContext(typeof(HRSystemContext))]
    partial class HRSystemContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.14")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HRSystem.Models.AttendanceReport", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AttendanceTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Date")
                        .HasColumnType("date");

                    b.Property<int>("EmpId")
                        .HasColumnType("int");

                    b.Property<DateTime>("LeavingTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("EmpId");

                    b.ToTable("attendanceReports");
                });

            modelBuilder.Entity("HRSystem.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("departments");
                });

            modelBuilder.Entity("HRSystem.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("AttendanceTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOfContract")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DeptID")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LeavingTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("NationalID")
                        .HasColumnType("bigint");

                    b.Property<string>("Nationality")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Salary")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("DeptID");

                    b.ToTable("employees");
                });

            modelBuilder.Entity("HRSystem.Models.GeneralSetting", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DiscountHours")
                        .HasColumnType("int");

                    b.Property<int>("ExtraHours")
                        .HasColumnType("int");

                    b.Property<int>("OffDAy1")
                        .HasColumnType("int");

                    b.Property<int>("OffDAy2")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("generalSettings");
                });

            modelBuilder.Entity("HRSystem.Models.OfficialHolidays", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("date");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("officialHolidays");
                });

            modelBuilder.Entity("HRSystem.Models.AttendanceReport", b =>
                {
                    b.HasOne("HRSystem.Models.Employee", "Employee")
                        .WithMany("attendanceReports")
                        .HasForeignKey("EmpId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("HRSystem.Models.Employee", b =>
                {
                    b.HasOne("HRSystem.Models.Department", "Department")
                        .WithMany("employees")
                        .HasForeignKey("DeptID");

                    b.Navigation("Department");
                });

            modelBuilder.Entity("HRSystem.Models.Department", b =>
                {
                    b.Navigation("employees");
                });

            modelBuilder.Entity("HRSystem.Models.Employee", b =>
                {
                    b.Navigation("attendanceReports");
                });
#pragma warning restore 612, 618
        }
    }
}