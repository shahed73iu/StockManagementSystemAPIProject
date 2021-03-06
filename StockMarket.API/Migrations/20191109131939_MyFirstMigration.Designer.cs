﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StockMarket.Data;

namespace StockMarket.API.Migrations
{
    [DbContext(typeof(StockMarketContext))]
    [Migration("20191109131939_MyFirstMigration")]
    partial class MyFirstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("StockMarket.Data.Entity.Company2", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<string>("Symbol");

                    b.HasKey("Id");

                    b.ToTable("Company2s");
                });

            modelBuilder.Entity("StockMarket.Data.Entity.StockPrice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ComapnyId");

                    b.Property<decimal>("MaxPrice");

                    b.Property<decimal>("MinPrice");

                    b.Property<DateTime>("TradingDay");

                    b.HasKey("Id");

                    b.HasIndex("ComapnyId");

                    b.ToTable("StockPrices");
                });

            modelBuilder.Entity("StockMarket.Data.Entity.StockPrice", b =>
                {
                    b.HasOne("StockMarket.Data.Entity.Company2", "Company2")
                        .WithMany("StockPrices")
                        .HasForeignKey("ComapnyId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
