using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Collections.Generic;
using System;

namespace tangenportalv2.Models
{
    public class databaseContext : DbContext
    {

        public databaseContext(DbContextOptions options) : base(options) { }

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
            return (from BatchModel in BatchTable 
                    select BatchModel).ToArray();
        }

        public BatchModel getBatch(int id)
        {
            return(from BatchModel in BatchTable 
                   where BatchModel.ID == id 
                   select BatchModel).FirstOrDefault();
        }

        public Tuple<RunMod[], double> getAll(string? instrumentName, string? sd, string? ed, int pagenum)
        {
            Tuple<RunMod[], double> retval = null;
            DateTime startDate = Convert.ToDateTime(sd);
            DateTime endDate = Convert.ToDateTime(ed).AddHours(23);

            if (instrumentName != null && sd == null)
            {
                RunMod[] runs = (from RunMod in RunTable
                                 orderby RunMod.dateTime descending
                                 where RunMod.instrumentName.Equals(instrumentName)
                                 select RunMod).Skip(pagenum * 10).Take(10).ToArray();

                int count = (from RunMod in RunTable
                             orderby RunMod.dateTime descending
                             where RunMod.instrumentName.Equals(instrumentName)
                             select RunMod).Count();

                retval = Tuple.Create(runs, (double)count);
            }

            else if (instrumentName == null && sd != null)
            {
                RunMod[] runs = (from RunMod in RunTable
                                 where Convert.ToDateTime(RunMod.dateTime) >= startDate
                                 && Convert.ToDateTime(RunMod.dateTime) <= endDate
                                 select RunMod).Skip(pagenum * 10).Take(10).ToArray();

                int count = (from RunMod in RunTable
                             where Convert.ToDateTime(RunMod.dateTime) >= startDate
                             && Convert.ToDateTime(RunMod.dateTime) <= endDate
                             select RunMod).Count();

                retval = Tuple.Create(runs, (double)count);
            }

            else if (instrumentName != null && sd != null)
            {
                RunMod[] runs = (from RunMod in RunTable
                                 where Convert.ToDateTime(RunMod.dateTime) >= startDate 
                                 && Convert.ToDateTime(RunMod.dateTime) <= endDate
                                 select RunMod).Skip(pagenum * 10).Take(10).ToArray();

                int count = (from RunMod in RunTable
                             where Convert.ToDateTime(RunMod.dateTime) >= startDate
                             && Convert.ToDateTime(RunMod.dateTime) <= endDate
                             select RunMod).Count();

                retval = Tuple.Create(runs, (double)count);
            }
            else
            {
                RunMod[] runs = (from RunMod in RunTable
                                 orderby RunMod.dateTime descending
                                 select RunMod).Skip(pagenum * 10).Take(10).ToArray();

                int count = (from RunMod in RunTable
                             orderby RunMod.dateTime descending
                             select RunMod).Count();

                retval = Tuple.Create(runs, (double)count);
            }

            return retval;
        }

        public void toggleInstrument(int instrumentID)
        {
            InstrumentMod instrument = (from InstrumentMod in InstrumentTable 
                                        where InstrumentMod.ID == instrumentID 
                                        select InstrumentMod).FirstOrDefault();

            instrument.isActive = !instrument.isActive;
            Update(instrument);
            SaveChanges();
        }

        //public RunMod[] getRuns(int pagenum)
        //{
        //    return (from RunMod in RunTable 
        //            orderby RunMod.dateTime descending 
        //            select RunMod).Skip(pagenum*10).Take(10).ToArray();
        //}

        //public RunMod[] getRunsInstrument(int pagenum, string instrumentName)
        //{
        //    return (from RunMod in RunTable 
        //            orderby RunMod.dateTime descending 
        //            where RunMod.instrumentName.Equals(instrumentName) 
        //            select RunMod).Skip(pagenum * 10).Take(10).ToArray();
        //}

        public RunMod getRun(int id)
        {
            return (from RunMod in RunTable 
                    where RunMod.Id == id 
                    select RunMod).Include(p => p.targets).FirstOrDefault();
        }

        public InstrumentMod[] getInstruments()
        {
            return (from InstrumentMod in InstrumentTable 
                    select InstrumentMod).ToArray();
        }

        public string[] getInstrumentNames()
        {
            return (from RunMod in RunTable
                    select RunMod.instrumentName).Distinct().ToArray();
        }
        
        public void removeInstrument(int id)
        {
            Remove((from InstrumentMod in InstrumentTable 
                    where InstrumentMod.ID == id 
                    select InstrumentMod).First());
            SaveChanges();
        }

        //public void removeRuns()
        //{
        //    foreach(RunMod run in getRuns(1))
        //    {
        //        RemoveEntry(run);
        //    }
        //}

        public RunMod[] getFromInstrument(string instrumentName)
        {
            return (from RunMod in RunTable 
                    where RunMod.instrumentName.Equals(instrumentName) 
                    select RunMod).ToArray();
        }

        //public RunMod[] getWithinTimeFrame(DateTime startDate, DateTime endDate)
        //{
        //    return (from RunMod in RunTable
        //            where Convert.ToDateTime(RunMod.dateTime) >= startDate && Convert.ToDateTime(RunMod.dateTime) <= endDate
        //            select RunMod).ToArray();
        //}

    }
}