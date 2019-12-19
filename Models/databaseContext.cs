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

        public BatchModel getBatch(int id)
        {
            return(from BatchModel in BatchTable where BatchModel.ID == id select BatchModel).FirstOrDefault();
        }

        public double countRuns()
        {
            return (from RunMod in RunTable select RunMod).Count();
        }

        public RunMod[] getRuns(int pagenum)
        {
            return (from RunMod in RunTable select RunMod).Skip(pagenum*10).Take(10).ToArray();
        }

        public RunMod getRun(int id)
        {
            return (from RunMod in RunTable where RunMod.Id == id select RunMod).Include(p => p.targets).FirstOrDefault();
        }

        public InstrumentMod[] getInstruments()
        {
            return (from InstrumentMod in InstrumentTable select InstrumentMod).ToArray();
        }
        
        public void removeInstrument(int id)
        {
            Remove((from InstrumentMod in InstrumentTable where InstrumentMod.ID == id select InstrumentMod).First());
            SaveChanges();
        }

        public void removeRuns()
        {
            foreach(RunMod run in getRuns(1))
            {
                RemoveEntry(run);
            }
        }

        //public bool ClearAllRuns()
        //{
        //    bool retval = false;
        //    RunMod[] =from modelTarget in modelTarget where modelTarget.DataID == dataTableID select modelTarget).ToList().ToArray();
        //}
    }
}