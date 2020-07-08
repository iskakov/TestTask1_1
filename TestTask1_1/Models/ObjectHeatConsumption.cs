﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestTask1_1.Models
{
    public class ObjectHeatConsumption
    {
        public Guid PrimaryKey { get; set; }
        public DateTime DateRegistration { get; set; }
        public string Name { get; set; }
        public Consumer Consumer { get; set; }
    }
}