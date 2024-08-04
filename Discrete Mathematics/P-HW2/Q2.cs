using System;
using System.Collections.Generic;

namespace NumberAsFibonacci
{
    class Program
    {
        public static int nearestSmallerEqFib(int n)
        {
            if (n == 0 || n == 1)
                return n;
            int f1 = 1, f2 = 1, f3 = 2;
            while (f3 <= n)
            {
                f1 = f2;
                f2 = f3;
                f3 = f1 + f2;
            }
            return f2;
        }
        public static void printFibRepresntation(int n)
        {
            List<int> output = new List<int>();
            while (n > 0)
            {
                int f = nearestSmallerEqFib(n);
                output.Add(f);
                n = n - f;
            }
            for (int i = output.Count - 1; i >= 0; i--)
                Console.Write(output[i] + " ");
        }
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            printFibRepresntation(n);
        }
    }
}
