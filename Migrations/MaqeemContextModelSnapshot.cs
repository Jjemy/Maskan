﻿// <auto-generated />
using System;
using Maqeem.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Maqeem.Migrations
{
    [DbContext(typeof(MaqeemContext))]
    partial class MaqeemContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Maqeem.Models.Admin", b =>
                {
                    b.Property<long>("AdminID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("AdminID"), 1L, 1);

                    b.Property<string>("AdminName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("AdminID");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("Maqeem.Models.Buyer", b =>
                {
                    b.Property<long>("BuyerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("BuyerID"), 1L, 1);

                    b.Property<long>("AdminID")
                        .HasColumnType("bigint");

                    b.Property<string>("BuyerAddress")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("BuyerEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BuyerName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("NationalID")
                        .HasColumnType("decimal(20,0)");

                    b.Property<string>("PhoneNum")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BuyerID");

                    b.HasIndex("AdminID");

                    b.ToTable("Buyers");
                });

            modelBuilder.Entity("Maqeem.Models.Category", b =>
                {
                    b.Property<long>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("CategoryID"), 1L, 1);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("CategoryID");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Maqeem.Models.CategoryGroup", b =>
                {
                    b.Property<int>("CategoryGroupID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryGroupID"), 1L, 1);

                    b.Property<long>("CategoryID")
                        .HasColumnType("bigint");

                    b.Property<long>("PropertyID")
                        .HasColumnType("bigint");

                    b.HasKey("CategoryGroupID");

                    b.HasIndex("CategoryID");

                    b.HasIndex("PropertyID");

                    b.ToTable("CategoryGroups");
                });

            modelBuilder.Entity("Maqeem.Models.Country", b =>
                {
                    b.Property<long>("CountryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("CountryID"), 1L, 1);

                    b.Property<string>("CountryName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("CountryID");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("Maqeem.Models.Deal", b =>
                {
                    b.Property<long>("DealID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("DealID"), 1L, 1);

                    b.Property<long>("BuyerID")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("DealTypeID")
                        .HasColumnType("int");

                    b.Property<long>("Price")
                        .HasColumnType("bigint");

                    b.Property<long>("SellerID")
                        .HasColumnType("bigint");

                    b.HasKey("DealID");

                    b.HasIndex("BuyerID");

                    b.HasIndex("DealTypeID");

                    b.HasIndex("SellerID");

                    b.ToTable("Deals");
                });

            modelBuilder.Entity("Maqeem.Models.DealType", b =>
                {
                    b.Property<int>("DealTypeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DealTypeID"), 1L, 1);

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("DealTypeID");

                    b.ToTable("DealTypes");
                });

            modelBuilder.Entity("Maqeem.Models.Property", b =>
                {
                    b.Property<long>("PropertyID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("PropertyID"), 1L, 1);

                    b.Property<long>("Area")
                        .HasColumnType("bigint");

                    b.Property<long>("BedsNum")
                        .HasColumnType("bigint");

                    b.Property<long>("CountryID")
                        .HasColumnType("bigint");

                    b.Property<long>("DealID")
                        .HasColumnType("bigint");

                    b.Property<string>("GoogleMapsLink")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ImageLink")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<long>("PathsNum")
                        .HasColumnType("bigint");

                    b.Property<long>("Price")
                        .HasColumnType("bigint");

                    b.Property<long>("RoomsNum")
                        .HasColumnType("bigint");

                    b.HasKey("PropertyID");

                    b.HasIndex("CountryID");

                    b.HasIndex("DealID");

                    b.ToTable("Properties");
                });

            modelBuilder.Entity("Maqeem.Models.Seller", b =>
                {
                    b.Property<long>("SellerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("SellerID"), 1L, 1);

                    b.Property<long>("AdminID")
                        .HasColumnType("bigint");

                    b.Property<decimal>("NationalID")
                        .HasColumnType("decimal(20,0)");

                    b.Property<string>("PhoneNum")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SellerAddress")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("SellerEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SellerName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("SellerID");

                    b.HasIndex("AdminID");

                    b.ToTable("Sellers");
                });

            modelBuilder.Entity("Maqeem.Models.Buyer", b =>
                {
                    b.HasOne("Maqeem.Models.Admin", "Admin")
                        .WithMany("Buyers")
                        .HasForeignKey("AdminID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Admin");
                });

            modelBuilder.Entity("Maqeem.Models.CategoryGroup", b =>
                {
                    b.HasOne("Maqeem.Models.Category", "Category")
                        .WithMany("CategoryGroups")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Maqeem.Models.Property", "Property")
                        .WithMany("CategoryGroups")
                        .HasForeignKey("PropertyID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Property");
                });

            modelBuilder.Entity("Maqeem.Models.Deal", b =>
                {
                    b.HasOne("Maqeem.Models.Buyer", "Buyer")
                        .WithMany("Deals")
                        .HasForeignKey("BuyerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Maqeem.Models.DealType", "DealType")
                        .WithMany("Deals")
                        .HasForeignKey("DealTypeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Maqeem.Models.Seller", "Seller")
                        .WithMany("Deals")
                        .HasForeignKey("SellerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Buyer");

                    b.Navigation("DealType");

                    b.Navigation("Seller");
                });

            modelBuilder.Entity("Maqeem.Models.Property", b =>
                {
                    b.HasOne("Maqeem.Models.Country", "Country")
                        .WithMany("Properties")
                        .HasForeignKey("CountryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Maqeem.Models.Deal", "Deal")
                        .WithMany()
                        .HasForeignKey("DealID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");

                    b.Navigation("Deal");
                });

            modelBuilder.Entity("Maqeem.Models.Seller", b =>
                {
                    b.HasOne("Maqeem.Models.Admin", "Admin")
                        .WithMany("Sellers")
                        .HasForeignKey("AdminID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Admin");
                });

            modelBuilder.Entity("Maqeem.Models.Admin", b =>
                {
                    b.Navigation("Buyers");

                    b.Navigation("Sellers");
                });

            modelBuilder.Entity("Maqeem.Models.Buyer", b =>
                {
                    b.Navigation("Deals");
                });

            modelBuilder.Entity("Maqeem.Models.Category", b =>
                {
                    b.Navigation("CategoryGroups");
                });

            modelBuilder.Entity("Maqeem.Models.Country", b =>
                {
                    b.Navigation("Properties");
                });

            modelBuilder.Entity("Maqeem.Models.DealType", b =>
                {
                    b.Navigation("Deals");
                });

            modelBuilder.Entity("Maqeem.Models.Property", b =>
                {
                    b.Navigation("CategoryGroups");
                });

            modelBuilder.Entity("Maqeem.Models.Seller", b =>
                {
                    b.Navigation("Deals");
                });
#pragma warning restore 612, 618
        }
    }
}
