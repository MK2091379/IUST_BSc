using System;
using System.Collections.Generic;
using System.Linq;

namespace HW8_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> persons = new Dictionary<int, string>
            {
                {1,"Eeyore" },
                {2,"Roo" },
                {3,"Tiger" },
                {4,"Piglet" },
                {5,"Pooh" },
            };
            /*while (true)
            {
                Console.WriteLine("please enter the name and rate");
                string name = Console.ReadLine();
                int rate = int.Parse(Console.ReadLine());
                persons.Add(rate, name);
                Console.WriteLine("there is another one to add");
                string answer = Console.ReadLine();
                if (answer.ToLower() == "yes")
                    continue;
                else
                    break;
            }*/
            if(persons.ContainsValue("Pooh") && persons.ContainsValue("Roo"))
            {
                int PoohRate = 0;
                int RooRate = 0;
                foreach (var element in persons)
                {
                    if (element.Value == "Pooh")
                        PoohRate = element.Key;
                    if (element.Value == "Roo")
                        RooRate = element.Key;
                }
                persons.Remove(PoohRate);
                persons.Remove(RooRate);
                persons.Add(PoohRate, "Roo");
                persons.Add(RooRate, "Pooh");
            }
            if(persons.ContainsValue("Piglet") && persons.ContainsValue("Tiger"))
            {
                int PigletRate = 0;
                int TigerRate = 0;
                foreach (var element in persons)
                {
                    if (element.Value == "Piglet")
                        PigletRate = element.Key;
                    if (element.Value == "Tiger")
                        TigerRate = element.Key;
                }
                persons.Remove(TigerRate);
                persons.Remove(PigletRate);
                persons.Add(PigletRate, "Tiger");
                persons.Add(TigerRate, "Piglet");
            }
            if (persons.ContainsValue("Eeyore") && persons.ContainsValue("Tiger"))
            {
                int EeyoreRate = 0;
                int TigerRate = 0;
                foreach (var element in persons)
                {
                    if (element.Value == "Eeyore")
                        EeyoreRate = element.Key;
                    if (element.Value == "Tiger")
                        TigerRate = element.Key;
                }
                persons.Remove(TigerRate);
                persons.Remove(EeyoreRate);
                persons.Add(EeyoreRate, "Tiger");
                persons.Add(TigerRate, "Eeyore");
            }
            var list = persons.Keys.ToList().OrderBy(x=>x);
            foreach (var key in list)
                Console.WriteLine($"{persons[key]}");
        }
    }
}
