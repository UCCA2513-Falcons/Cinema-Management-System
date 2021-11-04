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
    [Migration("20211104155447_Add FnBOrder, FnBOrderDetail")]
    partial class AddFnBOrderFnBOrderDetail
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Falcons.Models.FnBOrder", b =>
                {
                    b.Property<int>("FnBOrderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserUID")
                        .HasColumnType("int");

                    b.HasKey("FnBOrderID");

                    b.HasIndex("UserUID");

                    b.ToTable("FnBOrder");
                });

            modelBuilder.Entity("Falcons.Models.FnBOrderDetail", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("FnBOrderID")
                        .HasColumnType("int");

                    b.Property<int?>("ProductID")
                        .HasColumnType("int");

                    b.Property<int>("ProductPrice")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("FnBOrderID");

                    b.HasIndex("ProductID");

                    b.ToTable("FnBOrderDetail");
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

                    b.Property<int>("FoodTypeFID")
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

                    b.HasIndex("FoodTypeFID");

                    b.ToTable("FoodInventory");
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

                    b.ToTable("FoodType");
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

                    b.Property<string>("PackageName")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("MenuID");

                    b.ToTable("Menu");
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

                    b.ToTable("MenuItem");
                });

            modelBuilder.Entity("Falcons.Models.Product", b =>
                {
                    b.Property<int>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ProductCategoryCategoryID")
                        .HasColumnType("int");

                    b.Property<string>("ProductDescription")
                        .HasMaxLength(2000)
                        .HasColumnType("ntext");

                    b.Property<decimal>("ProductPrice")
                        .HasColumnType("decimal(6,2)");

                    b.Property<string>("ProductTitle")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("ProductID");

                    b.HasIndex("ProductCategoryCategoryID");

                    b.ToTable("Product");
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

                    b.ToTable("ProductCategory");
                });

            modelBuilder.Entity("Falcons.Models.Role", b =>
                {
                    b.Property<int>("RoleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Position")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("RoleTitle")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("ntext");

                    b.HasKey("RoleID");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("Falcons.Models.User", b =>
                {
                    b.Property<int>("UID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("ApprovalStatus")
                        .HasColumnType("bit");

                    b.Property<bool>("BlockSuspicious")
                        .HasColumnType("bit");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("PhoneNo")
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.Property<int>("RoleID")
                        .HasColumnType("int");

                    b.HasKey("UID");

                    b.HasIndex("RoleID");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Falcons.Models.FnBOrder", b =>
                {
                    b.HasOne("Falcons.Models.User", "User")
                        .WithMany("FnBOrders")
                        .HasForeignKey("UserUID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Falcons.Models.FnBOrderDetail", b =>
                {
                    b.HasOne("Falcons.Models.FnBOrder", "FnBOrder")
                        .WithMany("FnBOrderDetails")
                        .HasForeignKey("FnBOrderID");

                    b.HasOne("Falcons.Models.Product", "Product")
                        .WithMany("FnBOrderDetails")
                        .HasForeignKey("ProductID");

                    b.Navigation("FnBOrder");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Falcons.Models.FoodInventory", b =>
                {
                    b.HasOne("Falcons.Models.FoodType", "FoodType")
                        .WithMany("FoodInventories")
                        .HasForeignKey("FoodTypeFID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FoodType");
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
                        .HasForeignKey("ProductCategoryCategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProductCategory");
                });

            modelBuilder.Entity("Falcons.Models.User", b =>
                {
                    b.HasOne("Falcons.Models.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
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

            modelBuilder.Entity("Falcons.Models.Product", b =>
                {
                    b.Navigation("FnBOrderDetails");

                    b.Navigation("MenuItems");
                });

            modelBuilder.Entity("Falcons.Models.ProductCategory", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Falcons.Models.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("Falcons.Models.User", b =>
                {
                    b.Navigation("FnBOrders");
                });
#pragma warning restore 612, 618
        }
    }
}
