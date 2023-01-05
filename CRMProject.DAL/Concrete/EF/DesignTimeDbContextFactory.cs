using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMProject.DAL.Concrete.EF
{
    using Context;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Migrations;
    using Microsoft.Extensions.Configuration;
    using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<CRMContext>
    {
        public CRMContext CreateDbContext(string[] args)
        {
            //add - migration init - o Concrete / EF / Migrations
            var config = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();

            var builder = new DbContextOptionsBuilder<CRMContext>();
            string connectionString = config.GetConnectionString("DB");
            builder.UseSqlServer(connectionString);
            return new CRMContext(builder.Options);
        }
    }
}
