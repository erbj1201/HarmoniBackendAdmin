﻿// <auto-generated />
using System;
using HarmoniBackendAdmin.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HarmoniBackendAdmin.Migrations
{
    [DbContext(typeof(HarmoniDbContext))]
    [Migration("20240317092601_InitialCreate6")]
    partial class InitialCreate6
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.2");

            modelBuilder.Entity("HarmoniBackendAdmin.Models.Booking", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("BookingDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("BookingEmail")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("BookingName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("BookingPhone")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("TreatmentId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("TreatmentId");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("HarmoniBackendAdmin.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ProductCategory")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ProductPrice")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("HarmoniBackendAdmin.Models.Staff", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("StaffName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Staffs");
                });

            modelBuilder.Entity("HarmoniBackendAdmin.Models.Treatment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("TreatmentCategory")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("TreatmentDescription")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("TreatmentName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("TreatmentPrice")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Treatments");
                });

            modelBuilder.Entity("HarmoniBackendAdmin.Models.Booking", b =>
                {
                    b.HasOne("HarmoniBackendAdmin.Models.Treatment", "Treatments")
                        .WithMany("Bookingss")
                        .HasForeignKey("TreatmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Treatments");
                });

            modelBuilder.Entity("HarmoniBackendAdmin.Models.Treatment", b =>
                {
                    b.Navigation("Bookingss");
                });
#pragma warning restore 612, 618
        }
    }
}