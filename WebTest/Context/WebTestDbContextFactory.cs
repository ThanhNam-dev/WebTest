using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace WebTest.Context
{
    public class WebTestDbContextFactory : IDesignTimeDbContextFactory<WebTestDbContext>
    {
        public WebTestDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("ConnectionString");

            var optionsBuilder = new DbContextOptionsBuilder<WebTestDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new WebTestDbContext(optionsBuilder.Options);
        }
    }
}
