using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMProject.DAL.Concrete.EF.Context
{
    using CRMProject.DAL.Concrete.EF.Configuration;
    using CRMProject.Entities.Abstract;
    using Entities.Concrete;
    using Microsoft.EntityFrameworkCore.ChangeTracking;

    public class CRMContext : DbContext
    {
        public CRMContext(DbContextOptions options) : base(options)
        {

        }

        /// <summary>
        /// Kullanıcı Tablosu
        /// </summary>
        public DbSet<UserAccount> UserAccount { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Product> Categories { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserAccountConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new SupplierConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());


        }
        public override int SaveChanges()
        {
            var entites = ChangeTracker.Entries().Where(t0 => t0.Entity is BaseEntity && t0.State == EntityState.Modified).ToList();
            if (entites != null)
                if (entites.Count > 0)
                    foreach (var item in entites)
                    {
                        ((BaseEntity)item.Entity).ModifiedDate = DateTime.Now;
                    }
            var newRecord = ChangeTracker.Entries().Where(t0 => t0.Entity is BaseEntity && t0.State == EntityState.Added).ToList();
            if (entites != null)
                if (entites.Count > 0)
                    foreach (var item in entites)
                    {
                        ((BaseEntity)item.Entity).ModifiedDate = DateTime.Now;
                    }
            return base.SaveChanges();
        }

    }
}
