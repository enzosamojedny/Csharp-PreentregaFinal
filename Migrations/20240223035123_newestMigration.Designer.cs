﻿// <auto-generated />
using C__Coderhouse_MAIN.database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace C__Coderhouse_MAIN.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20240223035123_newestMigration")]
    partial class newestMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("C__Coderhouse_MAIN.models.ProductSold", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.Property<int>("SaleID")
                        .HasColumnType("int");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ProductID");

                    b.HasIndex("SaleID");

                    b.ToTable("ProductSold");
                });

            modelBuilder.Entity("C__Coderhouse_MAIN.models.Products", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<double>("BuyPrice")
                        .HasColumnType("float");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Cost")
                        .HasColumnType("money");

                    b.Property<string>("Description")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("SellPrice")
                        .HasColumnType("money");

                    b.Property<decimal>("Stock")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("TotalProduct")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("UserID");

                    b.ToTable("Products", (string)null);
                });

            modelBuilder.Entity("C__Coderhouse_MAIN.models.Sales", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Comments")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("UserID");

                    b.ToTable("Sales");
                });

            modelBuilder.Entity("C__Coderhouse_MAIN.models.Users", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Users", (string)null);
                });

            modelBuilder.Entity("C__Coderhouse_MAIN.models.ProductSold", b =>
                {
                    b.HasOne("C__Coderhouse_MAIN.models.Products", "IdProductNavigation")
                        .WithMany("ProductSold")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_ProductSold_Products");

                    b.HasOne("C__Coderhouse_MAIN.models.Sales", "IdSaleNavigation")
                        .WithMany("ProductSold")
                        .HasForeignKey("SaleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_ProductSold_Sale");

                    b.Navigation("IdProductNavigation");

                    b.Navigation("IdSaleNavigation");
                });

            modelBuilder.Entity("C__Coderhouse_MAIN.models.Products", b =>
                {
                    b.HasOne("C__Coderhouse_MAIN.models.Users", "IdUserNavigation")
                        .WithMany("Products")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Products_Users");

                    b.Navigation("IdUserNavigation");
                });

            modelBuilder.Entity("C__Coderhouse_MAIN.models.Sales", b =>
                {
                    b.HasOne("C__Coderhouse_MAIN.models.Users", "IdUserNavigation")
                        .WithMany("Sales")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Sales_Users");

                    b.Navigation("IdUserNavigation");
                });

            modelBuilder.Entity("C__Coderhouse_MAIN.models.Products", b =>
                {
                    b.Navigation("ProductSold");
                });

            modelBuilder.Entity("C__Coderhouse_MAIN.models.Sales", b =>
                {
                    b.Navigation("ProductSold");
                });

            modelBuilder.Entity("C__Coderhouse_MAIN.models.Users", b =>
                {
                    b.Navigation("Products");

                    b.Navigation("Sales");
                });
#pragma warning restore 612, 618
        }
    }
}
