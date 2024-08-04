using System;
using System.Collections.Generic;

namespace ReverseOfNumbers
{
    class Program
    {
        public static void myFunction(int number)
        {
            List<int> myList = new List<int>();
            int holy = number * number;
            for(int i = 1; i < number; i++)
            {
                if(holy % i == 0)
                {
                    myList.Add(i);
                    myList.Add(holy / i);
                }
            }
            myList.Add(number);
            Console.WriteLine((myList.Count + 1) / 2);
            for(int i = 0; i < myList.Count; i += 2)
            {
                int a = myList[i] + number;
                int b;
                if (i == myList.Count - 1)
                {
                    b = myList[i] + number;
                }
                else
                {
                    b = myList[i + 1] + number;
                }
                Console.WriteLine($"1/{number} = 1/{b} + 1/{a}");
            }
        }
        static void Main(string[] args)
        {
            while (true)
            {
                int number = int.Parse(Console.ReadLine());
                if (number == -1)
                    break;
                else
                    myFunction(number);
            }
        }
    }
}
