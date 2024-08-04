using System;

namespace dollar_raise
{
    class Program
    {
        static void Sort(int[] arr)
        {
            int i, j, minIndex, tmp;
            int n = arr.Length;
            for (i = 0; i < n - 1; i++)
            {
                minIndex = i;
                for (j = i + 1; j < n; j++)
                    if (arr[j] < arr[minIndex])
                        minIndex = j;
                if (minIndex != i)
                {
                    tmp = arr[i];
                    arr[i] = arr[minIndex];
                    arr[minIndex] = tmp;
                }
            }
        }
        static void changeNumber(int changenumber)
        {
            int[] dollar = new int[changenumber];
            Console.WriteLine("enter the prices");
            for (int i = 0; i < changenumber; i++)
                dollar[i] = int.Parse(Console.ReadLine());
            int minimum = dollar[0];
            int index_min = 0;
            for (int i = 1; i < changenumber; i++)
            {
                if (dollar[i] < minimum)
                {
                    minimum = dollar[i];
                    index_min = i;
                }
            }
            int token = minimum;
            int counter = 1;

            for(int i=index_min;i<changenumber-1;i++)
            {
                if (dollar[i] < dollar[i + 1])
                    counter++;
                else
                    break;
                
            }
            Sort(dollar);
           
            
            Console.WriteLine("------------------------");
            Console.WriteLine("the minimum number is : {0}", dollar[0]);
            Console.WriteLine("the changes domain is : {0}", counter);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int input = int.Parse(Console.ReadLine());
            changeNumber(input);
        }
    }
}
