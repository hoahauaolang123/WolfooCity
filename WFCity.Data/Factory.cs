using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using WFCity.Data.EF;

namespace WF.Data
{
    public class Factory : IDesignTimeDbContextFactory<dbContext>
    {
        public dbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

            var con = configuration.GetConnectionString("WFDatabase"); //WFDatabase trong file appsettings.json
            var optionsBuilder = new DbContextOptionsBuilder<dbContext>();
            optionsBuilder.UseSqlServer(con);

            return new dbContext(optionsBuilder.Options);
        }
    }
}
