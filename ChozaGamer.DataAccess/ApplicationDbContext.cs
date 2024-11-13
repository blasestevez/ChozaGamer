﻿using ChozaGamer.DataAccess.Models.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChozaGamer.DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-JSV8JHV;Database=ChozaGamer;Trusted_Connection=True;TrustServerCertificate=True;MultipleActiveResultSets=true");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .HasOne(p => p.Brand)
                .WithMany(b => b.Products)
                .HasForeignKey(p => p.idBrand)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Product>()
                .HasOne(p => p.Category)
                .WithMany(c => c.Products)
                .HasForeignKey(p => p.idCategory)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Product>()
                .HasMany(p => p.ProductImages)
                .WithOne(pi => pi.Product)
                .HasForeignKey(pi => pi.idProduct)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<SubCategory>()
                .HasMany(sc => sc.Products)
                .WithOne(p => p.SubCategory)
                .HasForeignKey(p => p.idSubCategory)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<SubCategory>()
                .HasOne(sc => sc.Category)
                .WithMany(c => c.SubCategories)
                .HasForeignKey(sc => sc.idCategory)
                .OnDelete(DeleteBehavior.Restrict);

            base.OnModelCreating(modelBuilder);
        }
    }
}
