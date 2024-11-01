﻿// <auto-generated />
using System;
using DeliveryService.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DeliveryService.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241101073307_Initital")]
    partial class Initital
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("DeliveryService.Models.Delivery", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<long>("DistrictId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("LastDeliveryFilterTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<long>("OrderId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("DistrictId");

                    b.HasIndex("OrderId");

                    b.ToTable("Deliveries");
                });

            modelBuilder.Entity("DeliveryService.Models.District", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Districts");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Name = "Tasmania"
                        },
                        new
                        {
                            Id = 2L,
                            Name = "Colorado"
                        },
                        new
                        {
                            Id = 3L,
                            Name = "Arizona"
                        },
                        new
                        {
                            Id = 4L,
                            Name = "Western Australia"
                        },
                        new
                        {
                            Id = 5L,
                            Name = "Yukon"
                        },
                        new
                        {
                            Id = 6L,
                            Name = "Australian Capital Territory"
                        },
                        new
                        {
                            Id = 7L,
                            Name = "Tasmania"
                        },
                        new
                        {
                            Id = 8L,
                            Name = "Pennsylvania"
                        },
                        new
                        {
                            Id = 9L,
                            Name = "Western Australia"
                        },
                        new
                        {
                            Id = 10L,
                            Name = "Alaska"
                        },
                        new
                        {
                            Id = 11L,
                            Name = "Alberta"
                        },
                        new
                        {
                            Id = 12L,
                            Name = "Northern Territory"
                        },
                        new
                        {
                            Id = 13L,
                            Name = "Yukon"
                        },
                        new
                        {
                            Id = 14L,
                            Name = "Colorado"
                        },
                        new
                        {
                            Id = 15L,
                            Name = "Victoria"
                        });
                });

            modelBuilder.Entity("DeliveryService.Models.Order", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("DeliveryTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<long>("DistrictId")
                        .HasColumnType("bigint");

                    b.Property<double>("Weight")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.HasIndex("DistrictId");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            DeliveryTime = new DateTime(2024, 10, 28, 12, 2, 13, 0, DateTimeKind.Unspecified),
                            DistrictId = 10L,
                            Weight = 0.90000000000000002
                        },
                        new
                        {
                            Id = 2L,
                            DeliveryTime = new DateTime(2024, 10, 28, 12, 5, 42, 0, DateTimeKind.Unspecified),
                            DistrictId = 9L,
                            Weight = 1.0
                        },
                        new
                        {
                            Id = 3L,
                            DeliveryTime = new DateTime(2024, 10, 28, 12, 8, 21, 0, DateTimeKind.Unspecified),
                            DistrictId = 1L,
                            Weight = 0.69999999999999996
                        },
                        new
                        {
                            Id = 4L,
                            DeliveryTime = new DateTime(2024, 10, 28, 12, 10, 56, 0, DateTimeKind.Unspecified),
                            DistrictId = 7L,
                            Weight = 0.59999999999999998
                        },
                        new
                        {
                            Id = 5L,
                            DeliveryTime = new DateTime(2024, 10, 28, 12, 13, 29, 0, DateTimeKind.Unspecified),
                            DistrictId = 2L,
                            Weight = 1.0
                        },
                        new
                        {
                            Id = 6L,
                            DeliveryTime = new DateTime(2024, 10, 28, 12, 15, 35, 0, DateTimeKind.Unspecified),
                            DistrictId = 5L,
                            Weight = 0.69999999999999996
                        },
                        new
                        {
                            Id = 7L,
                            DeliveryTime = new DateTime(2024, 10, 28, 12, 18, 10, 0, DateTimeKind.Unspecified),
                            DistrictId = 2L,
                            Weight = 1.2
                        },
                        new
                        {
                            Id = 8L,
                            DeliveryTime = new DateTime(2024, 10, 28, 12, 20, 47, 0, DateTimeKind.Unspecified),
                            DistrictId = 15L,
                            Weight = 0.90000000000000002
                        },
                        new
                        {
                            Id = 9L,
                            DeliveryTime = new DateTime(2024, 10, 28, 12, 22, 59, 0, DateTimeKind.Unspecified),
                            DistrictId = 6L,
                            Weight = 1.0
                        },
                        new
                        {
                            Id = 10L,
                            DeliveryTime = new DateTime(2024, 10, 28, 12, 25, 32, 0, DateTimeKind.Unspecified),
                            DistrictId = 8L,
                            Weight = 1.0
                        },
                        new
                        {
                            Id = 11L,
                            DeliveryTime = new DateTime(2024, 10, 28, 12, 28, 18, 0, DateTimeKind.Unspecified),
                            DistrictId = 7L,
                            Weight = 1.3999999999999999
                        },
                        new
                        {
                            Id = 12L,
                            DeliveryTime = new DateTime(2024, 10, 28, 12, 30, 44, 0, DateTimeKind.Unspecified),
                            DistrictId = 8L,
                            Weight = 0.90000000000000002
                        },
                        new
                        {
                            Id = 13L,
                            DeliveryTime = new DateTime(2024, 10, 28, 12, 32, 9, 0, DateTimeKind.Unspecified),
                            DistrictId = 5L,
                            Weight = 1.2
                        },
                        new
                        {
                            Id = 14L,
                            DeliveryTime = new DateTime(2024, 10, 28, 12, 34, 26, 0, DateTimeKind.Unspecified),
                            DistrictId = 3L,
                            Weight = 1.3
                        },
                        new
                        {
                            Id = 15L,
                            DeliveryTime = new DateTime(2024, 10, 28, 12, 36, 49, 0, DateTimeKind.Unspecified),
                            DistrictId = 8L,
                            Weight = 1.5
                        },
                        new
                        {
                            Id = 16L,
                            DeliveryTime = new DateTime(2024, 10, 28, 12, 38, 52, 0, DateTimeKind.Unspecified),
                            DistrictId = 4L,
                            Weight = 0.69999999999999996
                        },
                        new
                        {
                            Id = 17L,
                            DeliveryTime = new DateTime(2024, 10, 28, 12, 40, 33, 0, DateTimeKind.Unspecified),
                            DistrictId = 5L,
                            Weight = 1.1000000000000001
                        },
                        new
                        {
                            Id = 18L,
                            DeliveryTime = new DateTime(2024, 10, 28, 12, 42, 14, 0, DateTimeKind.Unspecified),
                            DistrictId = 8L,
                            Weight = 1.1000000000000001
                        },
                        new
                        {
                            Id = 19L,
                            DeliveryTime = new DateTime(2024, 10, 28, 12, 43, 58, 0, DateTimeKind.Unspecified),
                            DistrictId = 12L,
                            Weight = 1.0
                        },
                        new
                        {
                            Id = 20L,
                            DeliveryTime = new DateTime(2024, 10, 28, 12, 46, 20, 0, DateTimeKind.Unspecified),
                            DistrictId = 12L,
                            Weight = 0.90000000000000002
                        },
                        new
                        {
                            Id = 21L,
                            DeliveryTime = new DateTime(2024, 10, 28, 12, 47, 45, 0, DateTimeKind.Unspecified),
                            DistrictId = 9L,
                            Weight = 0.90000000000000002
                        },
                        new
                        {
                            Id = 22L,
                            DeliveryTime = new DateTime(2024, 10, 28, 12, 49, 6, 0, DateTimeKind.Unspecified),
                            DistrictId = 14L,
                            Weight = 1.3999999999999999
                        },
                        new
                        {
                            Id = 23L,
                            DeliveryTime = new DateTime(2024, 10, 28, 12, 50, 57, 0, DateTimeKind.Unspecified),
                            DistrictId = 4L,
                            Weight = 0.90000000000000002
                        },
                        new
                        {
                            Id = 24L,
                            DeliveryTime = new DateTime(2024, 10, 28, 12, 52, 33, 0, DateTimeKind.Unspecified),
                            DistrictId = 3L,
                            Weight = 1.0
                        },
                        new
                        {
                            Id = 25L,
                            DeliveryTime = new DateTime(2024, 10, 28, 12, 54, 10, 0, DateTimeKind.Unspecified),
                            DistrictId = 4L,
                            Weight = 1.1000000000000001
                        },
                        new
                        {
                            Id = 26L,
                            DeliveryTime = new DateTime(2024, 10, 28, 12, 55, 44, 0, DateTimeKind.Unspecified),
                            DistrictId = 6L,
                            Weight = 0.90000000000000002
                        },
                        new
                        {
                            Id = 27L,
                            DeliveryTime = new DateTime(2024, 10, 28, 12, 57, 18, 0, DateTimeKind.Unspecified),
                            DistrictId = 1L,
                            Weight = 1.2
                        },
                        new
                        {
                            Id = 28L,
                            DeliveryTime = new DateTime(2024, 10, 28, 12, 58, 54, 0, DateTimeKind.Unspecified),
                            DistrictId = 2L,
                            Weight = 1.2
                        },
                        new
                        {
                            Id = 29L,
                            DeliveryTime = new DateTime(2024, 10, 28, 13, 0, 23, 0, DateTimeKind.Unspecified),
                            DistrictId = 5L,
                            Weight = 0.90000000000000002
                        },
                        new
                        {
                            Id = 30L,
                            DeliveryTime = new DateTime(2024, 10, 28, 13, 1, 39, 0, DateTimeKind.Unspecified),
                            DistrictId = 5L,
                            Weight = 1.2
                        },
                        new
                        {
                            Id = 31L,
                            DeliveryTime = new DateTime(2024, 10, 28, 13, 2, 58, 0, DateTimeKind.Unspecified),
                            DistrictId = 6L,
                            Weight = 1.1000000000000001
                        },
                        new
                        {
                            Id = 32L,
                            DeliveryTime = new DateTime(2024, 10, 28, 13, 4, 23, 0, DateTimeKind.Unspecified),
                            DistrictId = 13L,
                            Weight = 1.3
                        },
                        new
                        {
                            Id = 33L,
                            DeliveryTime = new DateTime(2024, 10, 28, 13, 5, 44, 0, DateTimeKind.Unspecified),
                            DistrictId = 5L,
                            Weight = 0.80000000000000004
                        },
                        new
                        {
                            Id = 34L,
                            DeliveryTime = new DateTime(2024, 10, 28, 13, 7, 15, 0, DateTimeKind.Unspecified),
                            DistrictId = 2L,
                            Weight = 1.3
                        },
                        new
                        {
                            Id = 35L,
                            DeliveryTime = new DateTime(2024, 10, 28, 13, 8, 37, 0, DateTimeKind.Unspecified),
                            DistrictId = 13L,
                            Weight = 1.2
                        },
                        new
                        {
                            Id = 36L,
                            DeliveryTime = new DateTime(2024, 10, 28, 13, 9, 58, 0, DateTimeKind.Unspecified),
                            DistrictId = 13L,
                            Weight = 1.0
                        },
                        new
                        {
                            Id = 37L,
                            DeliveryTime = new DateTime(2024, 10, 28, 13, 11, 14, 0, DateTimeKind.Unspecified),
                            DistrictId = 7L,
                            Weight = 0.90000000000000002
                        },
                        new
                        {
                            Id = 38L,
                            DeliveryTime = new DateTime(2024, 10, 28, 13, 12, 36, 0, DateTimeKind.Unspecified),
                            DistrictId = 10L,
                            Weight = 0.80000000000000004
                        },
                        new
                        {
                            Id = 39L,
                            DeliveryTime = new DateTime(2024, 10, 28, 13, 13, 57, 0, DateTimeKind.Unspecified),
                            DistrictId = 6L,
                            Weight = 1.0
                        },
                        new
                        {
                            Id = 40L,
                            DeliveryTime = new DateTime(2024, 10, 28, 13, 15, 28, 0, DateTimeKind.Unspecified),
                            DistrictId = 12L,
                            Weight = 1.2
                        },
                        new
                        {
                            Id = 41L,
                            DeliveryTime = new DateTime(2024, 10, 28, 13, 17, 5, 0, DateTimeKind.Unspecified),
                            DistrictId = 3L,
                            Weight = 1.1000000000000001
                        },
                        new
                        {
                            Id = 42L,
                            DeliveryTime = new DateTime(2024, 10, 28, 13, 18, 47, 0, DateTimeKind.Unspecified),
                            DistrictId = 12L,
                            Weight = 1.0
                        },
                        new
                        {
                            Id = 43L,
                            DeliveryTime = new DateTime(2024, 10, 28, 13, 19, 29, 0, DateTimeKind.Unspecified),
                            DistrictId = 14L,
                            Weight = 1.0
                        },
                        new
                        {
                            Id = 44L,
                            DeliveryTime = new DateTime(2024, 10, 28, 13, 21, 58, 0, DateTimeKind.Unspecified),
                            DistrictId = 7L,
                            Weight = 1.0
                        },
                        new
                        {
                            Id = 45L,
                            DeliveryTime = new DateTime(2024, 10, 28, 13, 23, 21, 0, DateTimeKind.Unspecified),
                            DistrictId = 9L,
                            Weight = 1.3
                        },
                        new
                        {
                            Id = 46L,
                            DeliveryTime = new DateTime(2024, 10, 28, 13, 24, 43, 0, DateTimeKind.Unspecified),
                            DistrictId = 2L,
                            Weight = 1.3999999999999999
                        },
                        new
                        {
                            Id = 47L,
                            DeliveryTime = new DateTime(2024, 10, 28, 13, 26, 4, 0, DateTimeKind.Unspecified),
                            DistrictId = 11L,
                            Weight = 0.90000000000000002
                        },
                        new
                        {
                            Id = 48L,
                            DeliveryTime = new DateTime(2024, 10, 28, 13, 27, 46, 0, DateTimeKind.Unspecified),
                            DistrictId = 3L,
                            Weight = 1.2
                        },
                        new
                        {
                            Id = 49L,
                            DeliveryTime = new DateTime(2024, 10, 28, 13, 29, 7, 0, DateTimeKind.Unspecified),
                            DistrictId = 7L,
                            Weight = 1.1000000000000001
                        },
                        new
                        {
                            Id = 50L,
                            DeliveryTime = new DateTime(2024, 10, 28, 13, 30, 43, 0, DateTimeKind.Unspecified),
                            DistrictId = 4L,
                            Weight = 1.2
                        },
                        new
                        {
                            Id = 51L,
                            DeliveryTime = new DateTime(2024, 10, 28, 13, 32, 24, 0, DateTimeKind.Unspecified),
                            DistrictId = 5L,
                            Weight = 0.80000000000000004
                        },
                        new
                        {
                            Id = 52L,
                            DeliveryTime = new DateTime(2024, 10, 28, 13, 33, 39, 0, DateTimeKind.Unspecified),
                            DistrictId = 3L,
                            Weight = 1.3999999999999999
                        },
                        new
                        {
                            Id = 53L,
                            DeliveryTime = new DateTime(2024, 10, 28, 13, 35, 7, 0, DateTimeKind.Unspecified),
                            DistrictId = 6L,
                            Weight = 1.1000000000000001
                        },
                        new
                        {
                            Id = 54L,
                            DeliveryTime = new DateTime(2024, 10, 28, 13, 36, 51, 0, DateTimeKind.Unspecified),
                            DistrictId = 5L,
                            Weight = 1.0
                        },
                        new
                        {
                            Id = 55L,
                            DeliveryTime = new DateTime(2024, 10, 28, 13, 38, 20, 0, DateTimeKind.Unspecified),
                            DistrictId = 2L,
                            Weight = 1.2
                        },
                        new
                        {
                            Id = 56L,
                            DeliveryTime = new DateTime(2024, 10, 28, 13, 39, 42, 0, DateTimeKind.Unspecified),
                            DistrictId = 3L,
                            Weight = 1.1000000000000001
                        },
                        new
                        {
                            Id = 57L,
                            DeliveryTime = new DateTime(2024, 10, 28, 13, 41, 15, 0, DateTimeKind.Unspecified),
                            DistrictId = 8L,
                            Weight = 0.90000000000000002
                        },
                        new
                        {
                            Id = 58L,
                            DeliveryTime = new DateTime(2024, 10, 28, 13, 43, 2, 0, DateTimeKind.Unspecified),
                            DistrictId = 9L,
                            Weight = 1.2
                        },
                        new
                        {
                            Id = 59L,
                            DeliveryTime = new DateTime(2024, 10, 28, 13, 44, 23, 0, DateTimeKind.Unspecified),
                            DistrictId = 12L,
                            Weight = 0.80000000000000004
                        },
                        new
                        {
                            Id = 60L,
                            DeliveryTime = new DateTime(2024, 10, 28, 13, 45, 58, 0, DateTimeKind.Unspecified),
                            DistrictId = 5L,
                            Weight = 0.90000000000000002
                        },
                        new
                        {
                            Id = 61L,
                            DeliveryTime = new DateTime(2024, 10, 28, 13, 47, 21, 0, DateTimeKind.Unspecified),
                            DistrictId = 3L,
                            Weight = 1.0
                        },
                        new
                        {
                            Id = 62L,
                            DeliveryTime = new DateTime(2024, 10, 28, 13, 49, 44, 0, DateTimeKind.Unspecified),
                            DistrictId = 10L,
                            Weight = 1.3
                        },
                        new
                        {
                            Id = 63L,
                            DeliveryTime = new DateTime(2024, 10, 28, 13, 50, 55, 0, DateTimeKind.Unspecified),
                            DistrictId = 8L,
                            Weight = 1.2
                        },
                        new
                        {
                            Id = 64L,
                            DeliveryTime = new DateTime(2024, 10, 28, 13, 52, 13, 0, DateTimeKind.Unspecified),
                            DistrictId = 7L,
                            Weight = 1.1000000000000001
                        },
                        new
                        {
                            Id = 65L,
                            DeliveryTime = new DateTime(2024, 10, 28, 13, 53, 47, 0, DateTimeKind.Unspecified),
                            DistrictId = 3L,
                            Weight = 1.2
                        },
                        new
                        {
                            Id = 66L,
                            DeliveryTime = new DateTime(2024, 10, 28, 13, 54, 32, 0, DateTimeKind.Unspecified),
                            DistrictId = 9L,
                            Weight = 1.1000000000000001
                        },
                        new
                        {
                            Id = 67L,
                            DeliveryTime = new DateTime(2024, 10, 28, 13, 56, 20, 0, DateTimeKind.Unspecified),
                            DistrictId = 11L,
                            Weight = 1.0
                        },
                        new
                        {
                            Id = 68L,
                            DeliveryTime = new DateTime(2024, 10, 28, 13, 57, 44, 0, DateTimeKind.Unspecified),
                            DistrictId = 5L,
                            Weight = 1.3999999999999999
                        },
                        new
                        {
                            Id = 69L,
                            DeliveryTime = new DateTime(2024, 10, 28, 13, 59, 31, 0, DateTimeKind.Unspecified),
                            DistrictId = 2L,
                            Weight = 1.3
                        },
                        new
                        {
                            Id = 70L,
                            DeliveryTime = new DateTime(2024, 10, 28, 13, 1, 3, 0, DateTimeKind.Unspecified),
                            DistrictId = 13L,
                            Weight = 1.0
                        },
                        new
                        {
                            Id = 71L,
                            DeliveryTime = new DateTime(2024, 10, 28, 13, 2, 57, 0, DateTimeKind.Unspecified),
                            DistrictId = 6L,
                            Weight = 1.1000000000000001
                        },
                        new
                        {
                            Id = 72L,
                            DeliveryTime = new DateTime(2024, 10, 28, 13, 4, 13, 0, DateTimeKind.Unspecified),
                            DistrictId = 2L,
                            Weight = 1.2
                        },
                        new
                        {
                            Id = 73L,
                            DeliveryTime = new DateTime(2024, 10, 28, 13, 5, 28, 0, DateTimeKind.Unspecified),
                            DistrictId = 5L,
                            Weight = 1.1000000000000001
                        },
                        new
                        {
                            Id = 74L,
                            DeliveryTime = new DateTime(2024, 10, 28, 13, 7, 19, 0, DateTimeKind.Unspecified),
                            DistrictId = 8L,
                            Weight = 0.80000000000000004
                        },
                        new
                        {
                            Id = 75L,
                            DeliveryTime = new DateTime(2024, 10, 28, 13, 8, 39, 0, DateTimeKind.Unspecified),
                            DistrictId = 6L,
                            Weight = 0.90000000000000002
                        },
                        new
                        {
                            Id = 76L,
                            DeliveryTime = new DateTime(2024, 10, 28, 13, 10, 53, 0, DateTimeKind.Unspecified),
                            DistrictId = 11L,
                            Weight = 0.80000000000000004
                        },
                        new
                        {
                            Id = 77L,
                            DeliveryTime = new DateTime(2024, 10, 28, 13, 12, 7, 0, DateTimeKind.Unspecified),
                            DistrictId = 8L,
                            Weight = 0.90000000000000002
                        },
                        new
                        {
                            Id = 78L,
                            DeliveryTime = new DateTime(2024, 10, 28, 13, 13, 45, 0, DateTimeKind.Unspecified),
                            DistrictId = 3L,
                            Weight = 1.2
                        },
                        new
                        {
                            Id = 79L,
                            DeliveryTime = new DateTime(2024, 10, 28, 13, 15, 23, 0, DateTimeKind.Unspecified),
                            DistrictId = 4L,
                            Weight = 1.3
                        },
                        new
                        {
                            Id = 80L,
                            DeliveryTime = new DateTime(2024, 10, 28, 13, 17, 32, 0, DateTimeKind.Unspecified),
                            DistrictId = 7L,
                            Weight = 1.0
                        },
                        new
                        {
                            Id = 81L,
                            DeliveryTime = new DateTime(2024, 10, 28, 13, 19, 18, 0, DateTimeKind.Unspecified),
                            DistrictId = 9L,
                            Weight = 0.90000000000000002
                        },
                        new
                        {
                            Id = 82L,
                            DeliveryTime = new DateTime(2024, 10, 28, 13, 20, 47, 0, DateTimeKind.Unspecified),
                            DistrictId = 5L,
                            Weight = 1.1000000000000001
                        },
                        new
                        {
                            Id = 83L,
                            DeliveryTime = new DateTime(2024, 10, 28, 13, 22, 31, 0, DateTimeKind.Unspecified),
                            DistrictId = 10L,
                            Weight = 1.2
                        },
                        new
                        {
                            Id = 84L,
                            DeliveryTime = new DateTime(2024, 10, 28, 13, 24, 8, 0, DateTimeKind.Unspecified),
                            DistrictId = 12L,
                            Weight = 1.1000000000000001
                        },
                        new
                        {
                            Id = 85L,
                            DeliveryTime = new DateTime(2024, 10, 28, 13, 26, 29, 0, DateTimeKind.Unspecified),
                            DistrictId = 7L,
                            Weight = 1.3
                        },
                        new
                        {
                            Id = 86L,
                            DeliveryTime = new DateTime(2024, 10, 28, 13, 28, 5, 0, DateTimeKind.Unspecified),
                            DistrictId = 4L,
                            Weight = 0.90000000000000002
                        },
                        new
                        {
                            Id = 87L,
                            DeliveryTime = new DateTime(2024, 10, 28, 13, 29, 51, 0, DateTimeKind.Unspecified),
                            DistrictId = 3L,
                            Weight = 1.2
                        },
                        new
                        {
                            Id = 88L,
                            DeliveryTime = new DateTime(2024, 10, 28, 13, 31, 43, 0, DateTimeKind.Unspecified),
                            DistrictId = 9L,
                            Weight = 1.1000000000000001
                        },
                        new
                        {
                            Id = 89L,
                            DeliveryTime = new DateTime(2024, 10, 28, 13, 33, 28, 0, DateTimeKind.Unspecified),
                            DistrictId = 13L,
                            Weight = 1.0
                        },
                        new
                        {
                            Id = 90L,
                            DeliveryTime = new DateTime(2024, 10, 28, 13, 35, 12, 0, DateTimeKind.Unspecified),
                            DistrictId = 8L,
                            Weight = 1.3999999999999999
                        },
                        new
                        {
                            Id = 91L,
                            DeliveryTime = new DateTime(2024, 10, 28, 13, 36, 59, 0, DateTimeKind.Unspecified),
                            DistrictId = 10L,
                            Weight = 1.3
                        },
                        new
                        {
                            Id = 92L,
                            DeliveryTime = new DateTime(2024, 10, 28, 13, 38, 47, 0, DateTimeKind.Unspecified),
                            DistrictId = 7L,
                            Weight = 1.1000000000000001
                        },
                        new
                        {
                            Id = 93L,
                            DeliveryTime = new DateTime(2024, 10, 28, 13, 40, 22, 0, DateTimeKind.Unspecified),
                            DistrictId = 5L,
                            Weight = 1.2
                        },
                        new
                        {
                            Id = 94L,
                            DeliveryTime = new DateTime(2024, 10, 28, 13, 42, 5, 0, DateTimeKind.Unspecified),
                            DistrictId = 11L,
                            Weight = 0.90000000000000002
                        },
                        new
                        {
                            Id = 95L,
                            DeliveryTime = new DateTime(2024, 10, 28, 13, 43, 51, 0, DateTimeKind.Unspecified),
                            DistrictId = 3L,
                            Weight = 1.0
                        },
                        new
                        {
                            Id = 96L,
                            DeliveryTime = new DateTime(2024, 10, 28, 13, 45, 38, 0, DateTimeKind.Unspecified),
                            DistrictId = 4L,
                            Weight = 1.3
                        },
                        new
                        {
                            Id = 97L,
                            DeliveryTime = new DateTime(2024, 10, 28, 13, 47, 26, 0, DateTimeKind.Unspecified),
                            DistrictId = 9L,
                            Weight = 1.2
                        },
                        new
                        {
                            Id = 98L,
                            DeliveryTime = new DateTime(2024, 10, 28, 13, 49, 3, 0, DateTimeKind.Unspecified),
                            DistrictId = 8L,
                            Weight = 0.90000000000000002
                        },
                        new
                        {
                            Id = 99L,
                            DeliveryTime = new DateTime(2024, 10, 28, 13, 50, 47, 0, DateTimeKind.Unspecified),
                            DistrictId = 6L,
                            Weight = 1.0
                        },
                        new
                        {
                            Id = 100L,
                            DeliveryTime = new DateTime(2024, 10, 28, 13, 52, 35, 0, DateTimeKind.Unspecified),
                            DistrictId = 2L,
                            Weight = 1.1000000000000001
                        });
                });

            modelBuilder.Entity("DeliveryService.Models.Delivery", b =>
                {
                    b.HasOne("DeliveryService.Models.District", "District")
                        .WithMany("Deliveries")
                        .HasForeignKey("DistrictId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DeliveryService.Models.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("District");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("DeliveryService.Models.Order", b =>
                {
                    b.HasOne("DeliveryService.Models.District", "District")
                        .WithMany("Orders")
                        .HasForeignKey("DistrictId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("District");
                });

            modelBuilder.Entity("DeliveryService.Models.District", b =>
                {
                    b.Navigation("Deliveries");

                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}