using Newtonsoft.Json;
using System.Collections.Generic;
using tangenportalv2.Models;

namespace tangenportalv2
{
    public class RunMod
    {
        public int Id { get; set; }
        public string sampleId { get; set; }
        public string uniqueId { get; set; }
        public string downloadDateTime { get; set; }
        public string assayId { get; set; }
        public string assayName { get; set; }
        public string kitLotId { get; set; }
        public string instrumentUuid { get; set; }
        public string instrumentName { get; set; }

        public ICollection<ResultMod> results { get; set; }
        public ICollection<TargetMod> targets { get; set; }
        public ICollection<WellMod> wells { get; set; }

        [JsonIgnore]
        public string DirPointer { get; set; }


    }
}