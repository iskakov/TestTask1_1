using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestTask1_1.Models
{
    public class Building
    {
        public Guid PrimaryKey { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int Number { get; set; }
    }
}