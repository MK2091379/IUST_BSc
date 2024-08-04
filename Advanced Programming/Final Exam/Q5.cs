using System;
using System.Collections.Generic;
using System.Linq;

namespace FinalExam6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string> { "moeinaaaaaaaa kazemi", "aliiiiiiiiiiiiiiii zarrokhi", "alireza mardani" };
            var output = names.Select(x => x.Split(" ")).ToList().OrderBy(x => x[1]).Where(x => x[0].Length > 5);
            foreach(var element in output)
            {
                Console.WriteLine(element[1]);
            }
            
            
            
        }
    }
}
