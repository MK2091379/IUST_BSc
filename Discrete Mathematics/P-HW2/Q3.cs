using System;
using System.Collections.Generic;

namespace NumberAsTwoPowers
{
    class Program
    {
        static void block()
        {
            List<int> v = new List<int>();
            int x = int.Parse(Console.ReadLine());
            while (x > 0)
            {
                v.Add((int)x % 2);
                x = x / 2;
            }
            for (int i = 0; i < v.Count; i++)
            {
                if (v[i] == 1)
                {
                    Console.Write(i);

                    if (i != v.Count - 1)
                        Console.Write(" ");
                }
            }

            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            block();
        }
    }
}
