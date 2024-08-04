using System;

namespace random_array
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
        static void Main(string[] args)
        {
            Random generator = new Random();
            int[] my_array = new int[10];

            
            for (int i = 0; i < 10; i++)
            {
                my_array[i] = generator.Next();
            }
            Console.WriteLine("main array");
            for (int i = 0; i < 10; i++)
            {
               
                Console.WriteLine(my_array[i]);
            }
            Sort(my_array);
            Console.WriteLine("--------------------------");
            Console.WriteLine("sorted array");
            for (int i = 0; i < 10; i++)
            {
                
                Console.WriteLine(my_array[i]);
            }
            Console.WriteLine("--------------------------");
            Console.WriteLine($"the minimum of array is {my_array[0]}");
            Console.WriteLine($"the maximum of array is {my_array[9]}");
        }
    }
}
