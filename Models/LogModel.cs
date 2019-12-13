using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tangenportalv2.Models
{
    public class LogModel
    {

        public DateTime calibDate { get; set; }
        public double top { get; set; }
        public double bot { get; set; }
        public int calibLED { get; set; }

        public string[] time { get; set; }
        public string[] plate { get; set; }
        public string[] tube { get; set; }
        public string[] diskTop { get; set; }
        public string[] diskBottom { get; set; }
        public string[] fluidTemp { get; set; }
        public string[] piezoCurrent { get; set; }
        public string[] ledCurrent { get; set; }


        public LogModel parseFile(string textfile)
        {
            return new LogModel();
        }
    }
}
