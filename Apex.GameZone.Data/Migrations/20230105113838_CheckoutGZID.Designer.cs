﻿// <auto-generated />
using System;
using Apex.GameZone.Data.DAO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Apex.GameZone.Data.Migrations
{
    [DbContext(typeof(MainDbContext))]
    [Migration("20230105113838_CheckoutGZID")]
    partial class CheckoutGZID
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Apex.GameZone.Data.Entities.CheckoutEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("AddedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Bill")
                        .HasColumnType("int");

                    b.Property<DateTime?>("End")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ExpectedEnd")
                        .HasColumnType("datetime2");

                    b.Property<int>("GameZoneId")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("SectionId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Start")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("GameZoneId");

                    b.HasIndex("SectionId");

                    b.ToTable("Checkouts");
                });

            modelBuilder.Entity("Apex.GameZone.Data.Entities.GameZoneEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("AddedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("GameZones");
                });

            modelBuilder.Entity("Apex.GameZone.Data.Entities.ItemCheckoutEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("AddedDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Bill")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("CheckoutId")
                        .HasColumnType("int");

                    b.Property<DateTime>("End")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int?>("ItemId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Start")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CheckoutId");

                    b.HasIndex("ItemId");

                    b.ToTable("ItemCheckoutMapping");
                });

            modelBuilder.Entity("Apex.GameZone.Data.Entities.ItemEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("AddedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GameZoneId")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PricePerHour")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GameZoneId");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("Apex.GameZone.Data.Entities.ProductCheckoutEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("AddedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CheckoutId")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CheckoutId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductCheckoutMapping");
                });

            modelBuilder.Entity("Apex.GameZone.Data.Entities.ProductEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ActualPrice")
                        .HasColumnType("int");

                    b.Property<DateTime>("AddedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GameZoneId")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GameZoneId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Apex.GameZone.Data.Entities.SectionEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("AddedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GameZoneId")
                        .HasColumnType("int");

                    b.Property<bool>("IsBusy")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsVip")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PricePerHour")
                        .HasColumnType("int");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GameZoneId");

                    b.ToTable("Sections");
                });

            modelBuilder.Entity("Apex.GameZone.Data.Entities.CheckoutEntity", b =>
                {
                    b.HasOne("Apex.GameZone.Data.Entities.GameZoneEntity", "GameZone")
                        .WithMany()
                        .HasForeignKey("GameZoneId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Apex.GameZone.Data.Entities.SectionEntity", "SectionEntity")
                        .WithMany()
                        .HasForeignKey("SectionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GameZone");

                    b.Navigation("SectionEntity");
                });

            modelBuilder.Entity("Apex.GameZone.Data.Entities.ItemCheckoutEntity", b =>
                {
                    b.HasOne("Apex.GameZone.Data.Entities.CheckoutEntity", "CheckoutEntity")
                        .WithMany("ConnectedItems")
                        .HasForeignKey("CheckoutId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Apex.GameZone.Data.Entities.ItemEntity", "ItemEntity")
                        .WithMany()
                        .HasForeignKey("ItemId");

                    b.Navigation("CheckoutEntity");

                    b.Navigation("ItemEntity");
                });

            modelBuilder.Entity("Apex.GameZone.Data.Entities.ItemEntity", b =>
                {
                    b.HasOne("Apex.GameZone.Data.Entities.GameZoneEntity", "GameZoneEntity")
                        .WithMany("Items")
                        .HasForeignKey("GameZoneId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GameZoneEntity");
                });

            modelBuilder.Entity("Apex.GameZone.Data.Entities.ProductCheckoutEntity", b =>
                {
                    b.HasOne("Apex.GameZone.Data.Entities.CheckoutEntity", "CheckoutEntity")
                        .WithMany("ConnectedProducts")
                        .HasForeignKey("CheckoutId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Apex.GameZone.Data.Entities.ProductEntity", "ProductEntity")
                        .WithMany()
                        .HasForeignKey("ProductId");

                    b.Navigation("CheckoutEntity");

                    b.Navigation("ProductEntity");
                });

            modelBuilder.Entity("Apex.GameZone.Data.Entities.ProductEntity", b =>
                {
                    b.HasOne("Apex.GameZone.Data.Entities.GameZoneEntity", "GameZoneEntity")
                        .WithMany("Products")
                        .HasForeignKey("GameZoneId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GameZoneEntity");
                });

            modelBuilder.Entity("Apex.GameZone.Data.Entities.SectionEntity", b =>
                {
                    b.HasOne("Apex.GameZone.Data.Entities.GameZoneEntity", "GameZoneEntity")
                        .WithMany("Sections")
                        .HasForeignKey("GameZoneId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GameZoneEntity");
                });

            modelBuilder.Entity("Apex.GameZone.Data.Entities.CheckoutEntity", b =>
                {
                    b.Navigation("ConnectedItems");

                    b.Navigation("ConnectedProducts");
                });

            modelBuilder.Entity("Apex.GameZone.Data.Entities.GameZoneEntity", b =>
                {
                    b.Navigation("Items");

                    b.Navigation("Products");

                    b.Navigation("Sections");
                });
#pragma warning restore 612, 618
        }
    }
}
