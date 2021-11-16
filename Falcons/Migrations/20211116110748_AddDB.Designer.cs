﻿// <auto-generated />
using System;
using Falcons.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Falcons.Migrations
{
    [DbContext(typeof(FalconsDBContext))]
    [Migration("20211116110748_AddDB")]
    partial class AddDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Falcons.Models.Booking", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MID")
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    b.Property<int?>("SeatSID")
                        .HasColumnType("int");

                    b.Property<double>("amount")
                        .HasMaxLength(10)
                        .HasColumnType("float");

                    b.Property<DateTime>("bookingDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("movieName")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<DateTime>("showDateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("ticketTID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("SeatSID");

                    b.HasIndex("ticketTID");

                    b.ToTable("Booking");
                });

            modelBuilder.Entity("Falcons.Models.Employee", b =>
                {
                    b.Property<int>("EmpID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Department")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("LName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Salary")
                        .HasColumnType("int");

                    b.HasKey("EmpID");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("Falcons.Models.FnBOrder", b =>
                {
                    b.Property<int>("FnBOrderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FnBOrderID");

                    b.ToTable("FnBOrders");
                });

            modelBuilder.Entity("Falcons.Models.FnBOrderDetail", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("OrderID")
                        .HasColumnType("int");

                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.Property<int>("ProductPrice")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("OrderID");

                    b.HasIndex("ProductID");

                    b.ToTable("FnBOrderDetails");
                });

            modelBuilder.Entity("Falcons.Models.FoodInventory", b =>
                {
                    b.Property<int>("RecordID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<int>("FID")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(6,2)");

                    b.Property<decimal>("Quantity")
                        .HasColumnType("decimal(6,2)");

                    b.Property<string>("RecordType")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("RecordID");

                    b.HasIndex("FID");

                    b.ToTable("FoodInventories");
                });

            modelBuilder.Entity("Falcons.Models.FoodType", b =>
                {
                    b.Property<int>("FID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("FID");

                    b.ToTable("FoodTypes");
                });

            modelBuilder.Entity("Falcons.Models.Hall", b =>
                {
                    b.Property<int>("HID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("seatSID")
                        .HasColumnType("int");

                    b.HasKey("HID");

                    b.HasIndex("seatSID");

                    b.ToTable("Hall");
                });

            modelBuilder.Entity("Falcons.Models.Menu", b =>
                {
                    b.Property<int>("MenuID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasMaxLength(1000)
                        .HasColumnType("ntext");

                    b.Property<string>("ImageURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PackageName")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("MenuID");

                    b.ToTable("Menus");
                });

            modelBuilder.Entity("Falcons.Models.MenuItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MenuID")
                        .HasColumnType("int");

                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MenuID");

                    b.HasIndex("ProductID");

                    b.ToTable("MenuItems");
                });

            modelBuilder.Entity("Falcons.Models.Movies", b =>
                {
                    b.Property<int>("MovieID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cast")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Distributor")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Duration")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Language")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("MovieName")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Subtitle")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Synopsis")
                        .HasMaxLength(2000)
                        .HasColumnType("ntext");

                    b.HasKey("MovieID");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("Falcons.Models.Product", b =>
                {
                    b.Property<int>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryID")
                        .HasColumnType("int");

                    b.Property<string>("ImageURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductDescription")
                        .HasMaxLength(2000)
                        .HasColumnType("ntext");

                    b.Property<string>("ProductTitle")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("ProductID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Falcons.Models.ProductCategory", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("CategoryID");

                    b.ToTable("ProductCategories");
                });

            modelBuilder.Entity("Falcons.Models.ProductDetails", b =>
                {
                    b.Property<int>("ProductDetailID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.Property<decimal>("ProductPrice")
                        .HasColumnType("decimal(6,2)");

                    b.Property<string>("Size")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductDetailID");

                    b.HasIndex("ProductID");

                    b.ToTable("ProductDetails");
                });

            modelBuilder.Entity("Falcons.Models.Seat", b =>
                {
                    b.Property<int>("SID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BID")
                        .HasColumnType("int");

                    b.Property<int>("HID")
                        .HasColumnType("int");

                    b.Property<string>("status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SID");

                    b.ToTable("Seat");
                });

            modelBuilder.Entity("Falcons.Models.Showtime", b =>
                {
                    b.Property<int>("ShowtimeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("EndDateTime")
                        .HasColumnType("datetime2");

                    b.Property<int?>("MoviesMovieID")
                        .HasColumnType("int");

                    b.Property<int>("ShowroomNo")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("ShowtimeID");

                    b.HasIndex("MoviesMovieID");

                    b.ToTable("Showtime");
                });

            modelBuilder.Entity("Falcons.Models.Ticket", b =>
                {
                    b.Property<int>("TID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BID")
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    b.Property<double>("amount")
                        .HasMaxLength(10)
                        .HasColumnType("float");

                    b.HasKey("TID");

                    b.ToTable("Ticket");
                });

            modelBuilder.Entity("Falcons.Models.Booking", b =>
                {
                    b.HasOne("Falcons.Models.Seat", null)
                        .WithMany("booking")
                        .HasForeignKey("SeatSID");

                    b.HasOne("Falcons.Models.Ticket", "ticket")
                        .WithMany("booking")
                        .HasForeignKey("ticketTID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ticket");
                });

            modelBuilder.Entity("Falcons.Models.FnBOrderDetail", b =>
                {
                    b.HasOne("Falcons.Models.FnBOrder", "FnBOrder")
                        .WithMany("FnBOrderDetails")
                        .HasForeignKey("OrderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Falcons.Models.Product", "Product")
                        .WithMany("FnBOrderDetails")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FnBOrder");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Falcons.Models.FoodInventory", b =>
                {
                    b.HasOne("Falcons.Models.FoodType", "FoodType")
                        .WithMany("FoodInventories")
                        .HasForeignKey("FID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FoodType");
                });

            modelBuilder.Entity("Falcons.Models.Hall", b =>
                {
                    b.HasOne("Falcons.Models.Seat", "seat")
                        .WithMany("Halls")
                        .HasForeignKey("seatSID");

                    b.Navigation("seat");
                });

            modelBuilder.Entity("Falcons.Models.MenuItem", b =>
                {
                    b.HasOne("Falcons.Models.Menu", "Menu")
                        .WithMany("MenuItems")
                        .HasForeignKey("MenuID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Falcons.Models.Product", "Product")
                        .WithMany("MenuItems")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Menu");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Falcons.Models.Product", b =>
                {
                    b.HasOne("Falcons.Models.ProductCategory", "ProductCategory")
                        .WithMany("Products")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProductCategory");
                });

            modelBuilder.Entity("Falcons.Models.ProductDetails", b =>
                {
                    b.HasOne("Falcons.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Falcons.Models.Showtime", b =>
                {
                    b.HasOne("Falcons.Models.Movies", "Movies")
                        .WithMany("Showtimes")
                        .HasForeignKey("MoviesMovieID");

                    b.Navigation("Movies");
                });

            modelBuilder.Entity("Falcons.Models.FnBOrder", b =>
                {
                    b.Navigation("FnBOrderDetails");
                });

            modelBuilder.Entity("Falcons.Models.FoodType", b =>
                {
                    b.Navigation("FoodInventories");
                });

            modelBuilder.Entity("Falcons.Models.Menu", b =>
                {
                    b.Navigation("MenuItems");
                });

            modelBuilder.Entity("Falcons.Models.Movies", b =>
                {
                    b.Navigation("Showtimes");
                });

            modelBuilder.Entity("Falcons.Models.Product", b =>
                {
                    b.Navigation("FnBOrderDetails");

                    b.Navigation("MenuItems");
                });

            modelBuilder.Entity("Falcons.Models.ProductCategory", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Falcons.Models.Seat", b =>
                {
                    b.Navigation("booking");

                    b.Navigation("Halls");
                });

            modelBuilder.Entity("Falcons.Models.Ticket", b =>
                {
                    b.Navigation("booking");
                });
#pragma warning restore 612, 618
        }
    }
}
