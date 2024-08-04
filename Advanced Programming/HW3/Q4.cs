using System;

namespace SumArray
{
    public class AddMany
    {
        private double NumersSum;
       public void AddNumbers(params double[] arr)
        {
            double buffer = 0;
            foreach (double elemnt in arr)
                buffer = buffer + elemnt;
            this.NumersSum = buffer;
        }
        public AddMany()
        {

        }
        public double GetSum()
        {
            return NumersSum;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("how many numbers you have considered?");
            int Numbers_numbre = int.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------------");
            double[] MyArray = new double[Numbers_numbre];
            Console.WriteLine("please enter the numbers");
            for (int i = 0; i < Numbers_numbre; i++)
            {
                MyArray[i] = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("------------------------------------");
            AddMany array_1 = new AddMany();
            array_1.AddNumbers(MyArray);
            Console.WriteLine($"{array_1.GetSum()}");
        }
    }
}
