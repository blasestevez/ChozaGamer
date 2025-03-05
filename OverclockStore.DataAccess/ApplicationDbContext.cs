using OverclockStore.DataAccess.Models.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverclockStore.DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Invoice> Invoices { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
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

            modelBuilder.Entity<Invoice>()
                .HasOne(i => i.Product)
                .WithMany(p => p.Invoices)
                .HasForeignKey(i => i.idProduct);

            modelBuilder.Entity<Invoice>()
                .HasOne(i => i.User)
                .WithMany(u => u.Invoices)
                .HasForeignKey(i => i.idUser);

            base.OnModelCreating(modelBuilder);
        }
    }
}
