using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CRMProject.DAL.Concrete.EF.Configuration
{
    using Entities.Concrete;

    public class UserAccountConfiguration : IEntityTypeConfiguration<UserAccount>
    {
        public void Configure(EntityTypeBuilder<UserAccount> builder)
        {
            builder.HasKey(e => e.UserId);
            builder.Property(e => e.UserName).HasMaxLength(255);
            builder.Property(e => e.Password).HasMaxLength(255);
            builder.Property(e => e.Fullname).HasMaxLength(255);
            builder.HasData(new UserAccount() { UserId = 1, Fullname = "Admin", ModifiedDate = DateTime.Now, Password = "1", RecordDate = DateTime.Now, UserName = "admin" });

        }
    }
}
