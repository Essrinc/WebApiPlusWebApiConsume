﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Udemy.WebApi.Data;

namespace Udemy.WebApi.Migrations
{
    [DbContext(typeof(ProductContext))]
    [Migration("20221129224549_seeddata")]
    partial class seeddata
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Udemy.WebApi.Data.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2022, 11, 27, 1, 45, 49, 207, DateTimeKind.Local).AddTicks(335),
                            Name = "Bilgisayar",
                            Price = 15000m,
                            Stock = 300
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2022, 10, 31, 1, 45, 49, 208, DateTimeKind.Local).AddTicks(1704),
                            Name = "Telefon",
                            Price = 10000m,
                            Stock = 500
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2022, 10, 1, 1, 45, 49, 208, DateTimeKind.Local).AddTicks(1720),
                            Name = "Klavye",
                            Price = 100m,
                            Stock = 1000
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
