using System;

namespace fibonacci
{
    class Program
    {
        static int Fibonacci(int number)
        {

            if (number <= 0)
                Console.WriteLine("incorrect number");
            if (number == 1)
                return 1;
            if (number == 2)
                return 1;
            if (number > 2)
                return Fibonacci(number - 1) + Fibonacci(number - 2);
            return 0;
        }
        static int sumFibo(int number)
        {
            if (number <= 0)
                Console.WriteLine("incorrect number");
            else
            {
                int sum = 0;
                for (int i = 1; i <= number; i++)
                {
                    sum += Fibonacci(i);
                }
                return sum;
            }
            return 0;
        }
        static int firstDigit(int number)
        {
            if (number <= 0)
                Console.WriteLine("incorrect number");
            else
            { 
                int token=sumFibo(number);
                while (token>=10)
                {
                    token = token % 10;
                }
                return token;
            }
            return 0;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}", firstDigit(input));
            

        }
    }
}
