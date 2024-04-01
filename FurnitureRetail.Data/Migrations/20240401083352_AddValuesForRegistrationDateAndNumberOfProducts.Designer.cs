﻿// <auto-generated />
using System;
using FurnitureRetail.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FurnitureRetail.Data.Migrations
{
    [DbContext(typeof(FurnitureRetailDbContext))]
    [Migration("20240401083352_AddValuesForRegistrationDateAndNumberOfProducts")]
    partial class AddValuesForRegistrationDateAndNumberOfProducts
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FurnitureRetail.Core.Customers", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberOfSelledProducts")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateOnly>("RegistrationDate")
                        .HasColumnType("date");

                    b.HasKey("Id");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            Id = new Guid("99c78841-c4a9-485a-943d-1f2291d86a82"),
                            Email = "alice.johnson@example1.com",
                            FirstName = "Alice",
                            LastName = "Johnson",
                            NumberOfSelledProducts = 31,
                            Password = "f7745f4df4394027716de160fb2acd6aac36699576a8be586b75ac09acf6a0df",
                            RegistrationDate = new DateOnly(2020, 10, 20)
                        },
                        new
                        {
                            Id = new Guid("49b04f59-8ac7-4ab8-8fae-80f7ce165000"),
                            Email = "john.smith@example2.org",
                            FirstName = "John",
                            LastName = "Smith",
                            NumberOfSelledProducts = 32,
                            Password = "245b22dce938051efc28cf4364928fa26e171db139755311a93703ba65fd6d07",
                            RegistrationDate = new DateOnly(2022, 2, 24)
                        },
                        new
                        {
                            Id = new Guid("a91bd871-ba4d-4c0b-afcf-0f765a26f978"),
                            Email = "emily.davis@example3.net",
                            FirstName = "Emily",
                            LastName = "Davis",
                            NumberOfSelledProducts = 100,
                            Password = "e493c394a28652900d73f0fc7e6713840b1af0ab1f3fd9c5878d82e5f753c6c1",
                            RegistrationDate = new DateOnly(2020, 10, 18)
                        },
                        new
                        {
                            Id = new Guid("5212a8a1-4b4e-4356-8c02-b7a87655a689"),
                            Email = "michael.brown@example4.com",
                            FirstName = "Michael",
                            LastName = "Brown",
                            NumberOfSelledProducts = 43,
                            Password = "2ed06766795d58a4f22d511a672f20a6b096d3fe5b56af3a744678a9a356fd82",
                            RegistrationDate = new DateOnly(2022, 1, 16)
                        },
                        new
                        {
                            Id = new Guid("40c23afc-8c4e-4fa1-99c5-4b5e1495e83c"),
                            Email = "olivia.rodrigo@example5.ro",
                            FirstName = "Olivia",
                            LastName = "Rodrigo",
                            NumberOfSelledProducts = 3,
                            Password = "59c225b0465d04c2cffc0886328c954caac0243b87cca027f5196ab13acef430",
                            RegistrationDate = new DateOnly(2021, 7, 2)
                        },
                        new
                        {
                            Id = new Guid("1583f3d3-3599-4b4e-b5f0-600e9ef02646"),
                            Email = "david.martinez@example6.net",
                            FirstName = "David",
                            LastName = "Martinez",
                            NumberOfSelledProducts = 1,
                            Password = "ef797c8118f02dfb649607dd5d3f8c7623048c9c063d532cc95c5ed7a898a64f",
                            RegistrationDate = new DateOnly(2020, 5, 14)
                        },
                        new
                        {
                            Id = new Guid("2738a17a-a696-478c-a817-446a0d2701d5"),
                            Email = "jessica.anderson@example7.com",
                            FirstName = "Jessica",
                            LastName = "Anderson",
                            NumberOfSelledProducts = 53,
                            Password = "27cc6994fc1c01ce6659c6bddca9b69c4c6a9418065e612c69d110b3f7b11f8a",
                            RegistrationDate = new DateOnly(1995, 1, 5)
                        },
                        new
                        {
                            Id = new Guid("48fe8061-7f7d-46cb-96e3-3cd42c33bf47"),
                            Email = "christopher.lee@example8.org",
                            FirstName = "Christopher",
                            LastName = "Lee",
                            NumberOfSelledProducts = 3,
                            Password = "86de60b988397b1d344c42fc7f6e3aa607036b9deb32d693a8e527e18e39e8f5",
                            RegistrationDate = new DateOnly(2000, 10, 27)
                        },
                        new
                        {
                            Id = new Guid("8ab0f995-2489-4ae4-bf50-2896be2175b3"),
                            Email = "sarah_wilson@example9.org",
                            FirstName = "Sarah",
                            LastName = "Wilson",
                            NumberOfSelledProducts = 3,
                            Password = "97c94ebe5d767a353b77f3c0ce2d429741f2e8c99473c3c150e2faa3d14c9da6",
                            RegistrationDate = new DateOnly(2014, 7, 21)
                        },
                        new
                        {
                            Id = new Guid("22990a82-b99e-441f-9c4c-d9e4aa18250f"),
                            Email = "ethan.adams@example10.com",
                            FirstName = "Ethan",
                            LastName = "Adams",
                            NumberOfSelledProducts = 10,
                            Password = "1699a71dcf40f92bf361c1860bfc616da003db42a44cec1e0450b16f7fbc43ee",
                            RegistrationDate = new DateOnly(2022, 1, 24)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
