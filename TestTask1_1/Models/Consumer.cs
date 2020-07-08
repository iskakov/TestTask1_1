using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TestTask1_1.Models
{
    public class Consumer
    {
        public Guid PrimaryKey { get; set; }
        

        public int PersonalAccount { get; set; }
    }
}