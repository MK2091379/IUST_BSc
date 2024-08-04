using System;

namespace triangle_of_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int s = x;
            int l = 1;
            int a = 1;
            while(s>0)
            {
                Console.WriteLine("\n");
                for (int i = 0; i < s; i++)
                    Console.Write("   ");
                for (int i = 0; i < 2 * l - 1; i++)
                    Console.Write(a + "  ");
                for (int i = 0; i < s; i++)
                    Console.Write("   ");

                a++;
                s--;
                l++;
            }
        }
    }
}
