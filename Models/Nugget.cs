using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tangenportalv2.Models
{
    public class Nugget
    {

        public BatchModel[] batches { get; set; }
        public InstrumentMod[] instruments { get; set; }
        public RunMod[] runs { get; set; }
        public RunMod run { get; set; }
        public string jsonrun { get; set; }
        public int pagenum { get; set; }
        public double pagetotal { get; set; }
        public double totalRuns { get; set; }
        public string[] instrumentNames { get; set; }
        public string error { get; set; }
        public LogModel logmodel { get; set; }
        public StoragePath[] paths { get; set; }

    }
}
