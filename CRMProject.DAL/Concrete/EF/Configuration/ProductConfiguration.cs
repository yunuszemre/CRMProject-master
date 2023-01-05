using CRMProject.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMProject.DAL.Concrete.EF.Configuration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(t0 => t0.ProductId);
            builder.Property(t1 => t1.ProductDescription).HasMaxLength(1000);
            builder.Property(t2 => t2.ProductName).HasMaxLength(100);

            builder.HasOne(p => p.Category).WithMany(p1 => p1.Products).HasForeignKey(p2 => p2.CategoryId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Supplier).WithMany(p1 => p1.Products).HasForeignKey(p2 => p2.SupplierId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
