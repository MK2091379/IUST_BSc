using System;

namespace matris_of_numbers
{
    class Program
    {
        public static void Matris_of_number()
        {
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            if (m > n & n > 3 & m - n < 10)
            {
                Console.Write(0 + "  ");
                for (int i = n; i <= m; i++)
                {
                    if (i >= 10)
                        Console.Write(i + " ");
                    else
                        Console.Write(i + "  ");
                }
                Console.Write("\n");
                for (int j = m; j >= n; j--)
                {
                    if (j >= 10)
                        Console.Write(j + " ");
                    else
                        Console.Write(j + "  ");
                    for (int k = n; k <= m; k++)
                    {
                        if (k + j >= 10)
                            Console.Write(k + j + " ");
                        else
                            Console.Write(k + j + "  ");
                    }
                    Console.Write("\n");

                }


            }
            else
            {
               
                Matris_of_number();
            }


        }
        static void Main(string[] args)
        {
            Matris_of_number();
        }
    }
}
