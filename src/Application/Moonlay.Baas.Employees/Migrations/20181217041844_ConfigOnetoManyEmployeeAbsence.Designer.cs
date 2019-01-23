﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Moonlay.Employees.Infrastructure;

namespace Moonlay.Baas.Employees.Migrations
{
    [DbContext(typeof(EmployeeDbContext))]
    [Migration("20181217041844_ConfigOnetoManyEmployeeAbsence")]
    partial class ConfigOnetoManyEmployeeAbsence
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Moonlay.Employees.Domain.ReadModels.AttendanceReadModel", b =>
                {
                    b.Property<Guid>("Identity")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CheckInDate");

                    b.Property<DateTime?>("CheckOutDate");

                    b.Property<TimeSpan?>("Duration");

                    b.Property<Guid>("EmployeeId");

                    b.Property<int>("LocationCheckIn");

                    b.HasKey("Identity");

                    b.HasIndex("EmployeeId");

                    b.ToTable("EmployeeAbsence");
                });

            modelBuilder.Entity("Moonlay.Employees.Domain.ReadModels.EmployeeReadModel", b =>
                {
                    b.Property<Guid>("Identity")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("CompanyId");

                    b.Property<Guid>("PersonId");

                    b.Property<DateTime>("RegisDate");

                    b.Property<DateTime?>("ResignDate");

                    b.HasKey("Identity");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("Moonlay.Employees.Domain.ReadModels.AttendanceReadModel", b =>
                {
                    b.HasOne("Moonlay.Employees.Domain.ReadModels.EmployeeReadModel", "Employee")
                        .WithMany("Attendances")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
