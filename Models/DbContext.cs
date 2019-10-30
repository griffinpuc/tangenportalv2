using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Tools;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace tangen.Models
{
    public class DbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public DbContext(DbContextOptions<DbContext> options)
            : base(options)
        {
        }

        public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<DbContext>
        {
            public DbContext CreateDbContext(string[] args)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json")
                    .Build();
                var builder = new DbContextOptionsBuilder<DbContext>();
                var connectionString = configuration.GetConnectionString("dbConnection");
                builder.UseSqlServer(connectionString);
                return new DbContext(builder.Options);
            }
        }

        public DbSet<RunMod> RunTable { get; set; }


        public void AddEntry(object obj)
        {
            Add(obj);
            SaveChanges();
        }

        /* Remove entry */
        public void RemoveEntry(object obj)
        {
            Remove(obj);
            SaveChanges();
        }

        /* Modify entry */
        public void UpdateEntry(object obj)
        {
            Update(obj);
            SaveChanges();
        } 
    }
}