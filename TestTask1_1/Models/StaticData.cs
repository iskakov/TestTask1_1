using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestTask1_1.Models
{
    public static class StaticData
    {
        public static List<ObjectHeatConsumption> Objects { get; set; } = new List<ObjectHeatConsumption>();

        private static string GenerateSt(string Alpha, int length)
        {
            var st = "";
            var random = new Random();
            for(int i = 0; i< length; i++)
            {
                int pos = random.Next(0, Alpha.Length);
                st += Alpha[pos];
            }

            return st;
        }


        public static void Generate()
        {
            var random = new Random();
            var list = new List<Consumer>();
            for(int i = 0; i < 5; i++)
            {
                list.Add(new Consumer() { PrimaryKey = Guid.NewGuid(), PersonalAccount = GenerateSt(random, "0123456789", 8) });
            }

            for(int i = 0; i<50; i++)
            {
                Objects.Add(new ObjectHeatConsumption() 
                {
                    PrimaryKey = Guid.NewGuid(),
                    Consumer = list[random.Next(0, list.Count)],
                    DateRegistration = new DateTime(random.Next(2018, 2021), random.Next(1, 12), random.Next(1, 28)), 
                    Name = GenerateSt(random, "АБВГДЕЖЗИКЛМНОПРСТУФХЦШЩЭЮЯ", 6)
                });
            }
        }


        private static string GenerateSt(Random random, string Alpha, int length)
        {
            var st = "";
            
            for (int i = 0; i < length; i++)
            {
                int pos = random.Next(0, Alpha.Length);
                st += Alpha[pos];
            }

            return st;
        }
    }
}