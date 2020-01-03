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
        public DbSet<StoragePath> PathTable { get; set; }

        public void bigPush(int size)
        {
            for (int i=0; i<size; i++)
            {
                DateTime start = new DateTime(2019, 1, 1);
                int range = (DateTime.Today - start).Days;
                Random gen = new Random();
                //start.AddDays(gen.Next(range));

                RunMod run = new RunMod();
                run.assayId = "1101";
                run.assayName = "Candida Neg Ctl";
                run.sampleId = "CPDEV2KRKKK";
                run.uniqueId = (new Random().Next(0, 1040)*i).ToString();
                run.dateTime = start.AddDays(gen.Next(range)).ToString("yyyy-MM-ddTHH:mm:ss.fffffffK");
                run.instrumentName = "CPDEV7";
                //run.DirPointer = "wwwroot/devRun/RUN_CPDEV2_11-26-19-05_28PM.txt";
                run.instrumentUuid = "9989898";
                run.kitLotId = "1111122";

                Add(run);
                SaveChanges();
            }
        }


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

        public void addPath(string path)
        {
            Add(new StoragePath() { path = path });
            SaveChanges();
        }

        public StoragePath[] getPaths()
        {
            return (from StoragePath in PathTable select StoragePath).ToArray();
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
                                 && RunMod.instrumentName.Equals(instrumentName)
                                 select RunMod).Skip(pagenum * 10).Take(10).ToArray();

                int count = (from RunMod in RunTable
                             where Convert.ToDateTime(RunMod.dateTime) >= startDate
                             && Convert.ToDateTime(RunMod.dateTime) <= endDate
                             && RunMod.instrumentName.Equals(instrumentName)
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

        public string getRawPath(int runID)
        {
            return (from RunMod in RunTable where RunMod.RunId == runID select RunMod.directoryPath + "\\" + RunMod.fileName).FirstOrDefault();
        }

        public RunMod getRun(int id)
        {
            return (from RunMod in RunTable 
                    where RunMod.RunId == id 
                    select RunMod).Include(p => p.results).Include(p => p.targets).Include(p => p.wells).FirstOrDefault();
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

        public RunMod[] getFromInstrument(string instrumentName)
        {
            return (from RunMod in RunTable 
                    where RunMod.instrumentName.Equals(instrumentName) 
                    select RunMod).ToArray();
        }
    }
}