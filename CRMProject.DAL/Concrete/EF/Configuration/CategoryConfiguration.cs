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
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(t0 => t0.CategoryId);

            builder.Property(t0=>t0.CategoryDescription).HasMaxLength(1000);

            builder.Property(t0=>t0.CategoryName).HasMaxLength(100);
            
        }
        
    }
}
