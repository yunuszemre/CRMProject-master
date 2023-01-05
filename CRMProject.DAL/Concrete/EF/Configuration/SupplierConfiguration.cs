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
    public class SupplierConfiguration : IEntityTypeConfiguration<Supplier>
    {
        public void Configure(EntityTypeBuilder<Supplier> builder)
        {
            builder.HasKey(t0 => t0.SupplierId);
            builder.Property(t0 => t0.ContactName).HasMaxLength(50);
            builder.Property(t0 => t0.CompanyName).HasMaxLength(256);

        }
    }
}
