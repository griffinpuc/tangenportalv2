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

    }
}
