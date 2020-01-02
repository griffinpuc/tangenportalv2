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


        public string axisX { get; set; }
        public string time { get; set; }
        public string plate { get; set; }
        public string tube { get; set; }
        public string diskTop { get; set; }
        public string diskBottom { get; set; }
        public string fluidTemp { get; set; }
        public string piezoCurrent { get; set; }
        public string ledCurrent { get; set; }


        public LogModel parseFile(string filepath)
        {
            int itx = 0;
            int fileLength = System.IO.File.ReadLines(filepath).ToArray().Length;

            foreach (string line in System.IO.File.ReadLines(filepath))
            {

                if ((itx > 4 && itx < fileLength - 3) && (!line.Equals("")))
                {
                    var splitLine = line.Split(",");

                    for (int i = 0; i <= splitLine.Length - 1; i++)
                    {
                        if (splitLine[i] == null || splitLine[i].Equals(" "))
                        {
                            splitLine[i] = "0";
                        }
                    }

                    this.axisX += String.Format(splitLine[0] + ",");
                    this.plate += String.Format(splitLine[1] + ",");
                    this.tube += String.Format(splitLine[2] + ",");
                    this.diskTop += String.Format(splitLine[3] + ",");
                    this.diskBottom += String.Format(splitLine[4] + ",");
                    this.fluidTemp += String.Format(splitLine[5] + ",");
                    this.piezoCurrent += String.Format(splitLine[6] + ",");
                    //graph.ledCurrent += String.Format(splitLine[7] + ",");

                }

                else if (itx == fileLength - 3)
                {
                    break;
                }

                itx++;
            }

            return this;
        }
    }
}
