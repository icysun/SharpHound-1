﻿using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharpHound.BaseClasses
{
    public class Computer : DBObject
    {
        public new string Type = "computer";
        public string LocalSID { get; set; }
        [BsonIndex]
        public string DNSHostName { get; set; }
    }
}
