using System;

namespace get_binary
{
    class Program
    {
        static void get_binary()
        {
            int x = int.Parse(Console.ReadLine());
            if (x < 0)
            {
                Console.WriteLine("again");
                get_binary();
            }
            else
            {
                int i = 0;
                int[] binary = new int[8];
                while (x > 0)
                {
                    binary[i] = x % 2;
                    x = x / 2;
                    i++;
                }
                for (int j = 7; j >= 0; j--)
                {
                    Console.Write(binary[j]);
                }
                
            }
        }
        static void Main(string[] args)
        {

            get_binary();
        }
    }
    
}
