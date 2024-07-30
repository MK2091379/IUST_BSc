using System;
using System.Collections.Generic;
using System.Linq;

namespace BasketVWeave
{
    class Program
    {
        public static void print_array(List<List<double>> array)
        {
            foreach (var i in array)
            {
                foreach (var j in i)
                {
                    Console.Write(j);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
        public static double? basketWeave(List<List<double>> ar)
        {
            if (ar.Count == 0)
                return 1;
            else if (ar.Count == 1)
                return ar[0][0];
            else if (ar.Count == 2)
                return (ar[0][0] * ar[1][1]) - (ar[0][1] * ar[1][0]);
            else if (ar.Count == 3)
                return
                    (ar[0][0] * ar[1][1] * ar[2][2])
                    + (ar[0][1] * ar[1][2] * ar[2][0])
                    + (ar[0][2] * ar[1][0] * ar[2][1])
                    - (ar[0][2] * ar[1][1] * ar[2][0])
                    - (ar[1][2] * ar[2][1] * ar[0][0])
                    - (ar[0][1] * ar[1][0] * ar[2][2])
                    ;
            else
            {
                Console.WriteLine("this method does not support arrays bigger than 3*3");
                return null;
            }
        }
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            var arr = new List<List<double>>();
            for(int i = 0; i < n; i++)
            {
                var col = new List<double>();
                for(int j = 0; j < n; j++)
                {
                    col.Add(new Random().Next(1, 3));
                }
                arr.Add(col);
            }
            print_array(arr);
            Console.WriteLine(basketWeave(arr));
        }
    }
}
