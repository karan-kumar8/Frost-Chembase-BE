﻿// <auto-generated />
using System;
using Frost_Chembase_BE_Context_Stock.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Frost_Chembase_BE_Repository_Stock.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230417122803_first")]
    partial class first
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Frost_Chembase_BE_Entities_Stock.Products.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Created_At")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("Created_By")
                        .HasColumnType("integer");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("IsLinked")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Parent_Id")
                        .HasColumnType("integer");

                    b.Property<int>("SortOrder")
                        .HasColumnType("integer");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<DateTime>("Updated_At")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("Updated_By")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Frost_Chembase_BE_Entities_Stock.Products.MainCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("Created_At")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("Created_By")
                        .HasColumnType("integer");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("SortOrder")
                        .HasColumnType("integer");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<DateTime>("Updated_At")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("Updated_By")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("MainCategories");
                });

            modelBuilder.Entity("Frost_Chembase_BE_Entities_Stock.Products.Manufacturer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Created_At")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("Created_By")
                        .HasColumnType("integer");

                    b.Property<string>("DisplayName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Estab_Year")
                        .HasColumnType("integer");

                    b.Property<string>("Icon")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Ownership")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("SortOrder")
                        .HasColumnType("integer");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<DateTime>("Updated_At")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("Updated_By")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Manufacturers");
                });

            modelBuilder.Entity("Frost_Chembase_BE_Entities_Stock.Products.Master", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Created_At")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("Created_By")
                        .HasColumnType("integer");

                    b.Property<double>("Existing_Capacity")
                        .HasColumnType("double precision");

                    b.Property<int>("MainCategoryId")
                        .HasColumnType("integer");

                    b.Property<int>("ManufacturerId")
                        .HasColumnType("integer");

                    b.Property<int>("ProductId")
                        .HasColumnType("integer");

                    b.Property<int>("ProductTypeId")
                        .HasColumnType("integer");

                    b.Property<int>("ProvinceId")
                        .HasColumnType("integer");

                    b.Property<string>("ShowProdType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<string>("Unit")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double>("Upcoming_Capacity")
                        .HasColumnType("double precision");

                    b.Property<DateTime>("Updated_At")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("Updated_By")
                        .HasColumnType("integer");

                    b.Property<int>("Year")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("MainCategoryId");

                    b.HasIndex("ManufacturerId");

                    b.HasIndex("ProductId");

                    b.HasIndex("ProductTypeId");

                    b.HasIndex("ProvinceId");

                    b.ToTable("Masters");
                });

            modelBuilder.Entity("Frost_Chembase_BE_Entities_Stock.Products.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Created_At")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("Created_By")
                        .HasColumnType("integer");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("SortOrder")
                        .HasColumnType("integer");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<DateTime>("Updated_At")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("Updated_By")
                        .HasColumnType("integer");

                    b.Property<string>("UrlName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Frost_Chembase_BE_Entities_Stock.Products.ProductType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Created_At")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("Created_By")
                        .HasColumnType("integer");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("SortOrder")
                        .HasColumnType("integer");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<DateTime>("Updated_At")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("Updated_By")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("ProductTypes");
                });

            modelBuilder.Entity("Frost_Chembase_BE_Entities_Stock.Products.Province", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Created_At")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("Created_By")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("SortOrder")
                        .HasColumnType("integer");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<DateTime>("Updated_At")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("Updated_By")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Provinces");
                });

            modelBuilder.Entity("Frost_Chembase_BE_Entities_Stock.Products.MainCategory", b =>
                {
                    b.HasOne("Frost_Chembase_BE_Entities_Stock.Products.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Frost_Chembase_BE_Entities_Stock.Products.Master", b =>
                {
                    b.HasOne("Frost_Chembase_BE_Entities_Stock.Products.MainCategory", "MainCategory")
                        .WithMany()
                        .HasForeignKey("MainCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Frost_Chembase_BE_Entities_Stock.Products.Manufacturer", "Manufacturer")
                        .WithMany()
                        .HasForeignKey("ManufacturerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Frost_Chembase_BE_Entities_Stock.Products.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Frost_Chembase_BE_Entities_Stock.Products.ProductType", "ProductType")
                        .WithMany()
                        .HasForeignKey("ProductTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Frost_Chembase_BE_Entities_Stock.Products.Province", "Province")
                        .WithMany()
                        .HasForeignKey("ProvinceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MainCategory");

                    b.Navigation("Manufacturer");

                    b.Navigation("Product");

                    b.Navigation("ProductType");

                    b.Navigation("Province");
                });
#pragma warning restore 612, 618
        }
    }
}