﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tangenportalv2.Models
{
    public class InstrumentMod
    {

        public int ID { get; set; }
        public string name { get; set; }
        public string localAddress { get; set; }
        public string status { get; set; }
        public string lastPing { get; set; }
        public DateTime dateAdded { get; set; }
        public bool isActive { get; set; }
        public string username { get; set; }
        public string password { get; set; }

    }
}
