using System;

namespace sum_square
{
    
    class Program
    {
        static void Square(ref int number)
        {
            number *= number;
            
        }
        static void Sum(out int sum, int[] numbers)
        {
            sum = 0;
            foreach (int i in numbers)
                sum += i;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter the size of the array you want to takes the numbers ");
            int size = int.Parse(Console.ReadLine());
            int[] buffer = new int[size];
            int number = 0;
            int sum;
            Console.WriteLine("enter the numbers you want  ");
            for (int i = 0; i < size; i++)
            {
                
                int input = int.Parse(Console.ReadLine());
                number = input;
                Square(ref number);
                buffer[i] = number;
            }
            
            Sum(out sum, buffer);
            Console.WriteLine("-------------------------");
            Console.WriteLine("{0}", sum);

        }
    }
}
