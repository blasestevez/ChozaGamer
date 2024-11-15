﻿// <auto-generated />
using ChozaGamer.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ChozaGamer.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241115132557_AddNullables")]
    partial class AddNullables
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ChozaGamer.DataAccess.Models.Domain.Brand", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("warranty")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Brands");
                });

            modelBuilder.Entity("ChozaGamer.DataAccess.Models.Domain.Category", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("ChozaGamer.DataAccess.Models.Domain.Product", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<decimal>("defaultPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("idBrand")
                        .HasColumnType("int");

                    b.Property<int?>("idCategory")
                        .HasColumnType("int");

                    b.Property<int?>("idSubCategory")
                        .HasColumnType("int");

                    b.Property<decimal?>("iva")
                        .HasColumnType("decimal(3,2)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("productCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("productImage")
                        .HasColumnType("varbinary(max)");

                    b.Property<bool?>("sale")
                        .HasColumnType("bit");

                    b.Property<decimal?>("specialPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("stock")
                        .HasColumnType("int");

                    b.Property<int?>("warranty")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("idBrand");

                    b.HasIndex("idCategory");

                    b.HasIndex("idSubCategory");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("ChozaGamer.DataAccess.Models.Domain.SubCategory", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int?>("idCategory")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("idCategory");

                    b.ToTable("SubCategories");
                });

            modelBuilder.Entity("ChozaGamer.DataAccess.Models.Domain.User", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("hashedPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("userType")
                        .HasColumnType("bit");

                    b.Property<string>("username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ChozaGamer.DataAccess.Models.Domain.Product", b =>
                {
                    b.HasOne("ChozaGamer.DataAccess.Models.Domain.Brand", "Brand")
                        .WithMany("Products")
                        .HasForeignKey("idBrand")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("ChozaGamer.DataAccess.Models.Domain.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("idCategory")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("ChozaGamer.DataAccess.Models.Domain.SubCategory", "SubCategory")
                        .WithMany("Products")
                        .HasForeignKey("idSubCategory")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Brand");

                    b.Navigation("Category");

                    b.Navigation("SubCategory");
                });

            modelBuilder.Entity("ChozaGamer.DataAccess.Models.Domain.SubCategory", b =>
                {
                    b.HasOne("ChozaGamer.DataAccess.Models.Domain.Category", "Category")
                        .WithMany("SubCategories")
                        .HasForeignKey("idCategory")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Category");
                });

            modelBuilder.Entity("ChozaGamer.DataAccess.Models.Domain.Brand", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("ChozaGamer.DataAccess.Models.Domain.Category", b =>
                {
                    b.Navigation("Products");

                    b.Navigation("SubCategories");
                });

            modelBuilder.Entity("ChozaGamer.DataAccess.Models.Domain.SubCategory", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
