using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace tangenportalv2.Models
{
    public class BatchModel
    {

        public int ID { get; set; }
        public string batchName { get; set; }
        public string batchURL { get; set; }
        public int batchSize { get; set; }

        private RunMod SerializeFile(string fileurl)
        {
            return JsonConvert.DeserializeObject<RunMod>(System.IO.File.ReadAllText(fileurl));
        }
        
        public void AddBatch(databaseContext context)
        {
            foreach(string fileurl in Directory.GetFiles(batchURL))
            {
                SerializeFile(fileurl);
            }
            
        }

    }
}
