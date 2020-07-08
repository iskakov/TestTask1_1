using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestTask1_1.Models
{
    public static class StaticData
    {
        public static List<ObjectHeatConsumption> Objects { get; set; } = new List<ObjectHeatConsumption>()
        {
            new ObjectHeatConsumption(){PrimaryKey = Guid.NewGuid(), Consumer = new Consumer(){ PrimaryKey = Guid.NewGuid(), PersonalAccount = 123456789}, DateRegistration = new DateTime(2019, 1, 1), Name = "ШШТОРЕ" }
        };
    }
}