using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tangen-dataportal-version2.Models
{
    public class RunMod
    {

        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [JsonIgnore]
        public int ID { get; set; }
        public string sampleID { get; set; }
        public string uniqueID { get; set; }
        public string downloadDateTime { get; set; }
        public string assayID { get; set; }
        public string kitLotID { get; set; }
        public string instrumentUUID { get; set; }
        public string instrumentName { get; set; }

        [JsonIgnore]
        public string rawAddress { get; set; }

        [JsonIgnore]
        //public ICollection<modelTag> tags { get; set; }

        //public ICollection<modelTarget> targets { get; set; }
        //public ICollection<modelWell> wells { get; set; }

    }
}
