using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Tools;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;
using JetBrains.Annotations;
using System.Linq;
using System.Collections.Generic;

namespace tangenportalv2.Models
{
    public class databaseContext : DbContext
    {
        public databaseContext(DbContextOptions options)
            : base(options)
        {
        }

        public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<databaseContext>
        {
            public databaseContext CreateDbContext(string[] args)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json")
                    .Build();
                var builder = new DbContextOptionsBuilder<databaseContext>();
                var connectionString = configuration.GetConnectionString("dbConnection");
                builder.UseSqlServer(connectionString);
                return new databaseContext(builder.Options);
            }
        }

        public DbSet<RunMod> RunTable { get; set; }
        public DbSet<InstrumentMod> InstrumentTable { get; set; }
        public DbSet<BatchModel> BatchTable { get; set; }


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

        public BatchModel[] getBatches()
        {
            return (from BatchModel in BatchTable select BatchModel).ToArray();
        }

        //public bool ClearAllRuns()
        //{
        //    bool retval = false;
        //    RunMod[] =from modelTarget in modelTarget where modelTarget.DataID == dataTableID select modelTarget).ToList().ToArray();
        //}
    }
}