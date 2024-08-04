using System;
using static System.Math;
namespace Circle2
{
    class circle
    {
        public int X;
        public int Y;
        public double Radious;
        public circle(int x, int y, double radiuos)
        {
            this.X = x;
            this.Y = y;
            this.Radious = radiuos;
        }
        public circle()
        {
            
        }
        public static double Circumference(circle circle)
        {
            double circumference = 2 * PI * circle.Radious;
            return circumference;
        }
        public static double Area(circle circle)
        {
            double area = PI * Pow(circle.Radious, 2);
            return area;
        }
        public static double CenterDistanceFromO(circle circle)
        {
            double distance = Math.Sqrt(Pow(circle.X, 2) + Pow(circle.Y, 2));
            return distance;
        }
        public static circle copy(circle circle)
        {
            circle copCir = new circle();
            copCir.X = circle.X - 2;
            copCir.Y = circle.Y + 1;
            copCir.Radious = Math.Sqrt(2 * circle.Radious - 3);
            return copCir;
        }
    }
    class Program
    {
        static void Sort(double[] arr)
        {
            int i, j, minIndex;
            double tmp;
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
            Console.WriteLine("please enter the number of circles");
            int numbers = int.Parse(Console.ReadLine());
            Console.WriteLine("-------------------------");
            circle[] Mycircles_1 = new circle[numbers];
            circle[] Mycircles_2 = new circle[numbers * 2];
            int[] Xs = new int[numbers];
            int[] Ys = new int[numbers];
            double[] Radiouses = new double[numbers];
            double[] Areas = new double[numbers * 2];
            double[] Circumferences = new double[numbers * 2];
            double[] Distances = new double[numbers * 2];
            for (int i =0; i < numbers; i++)
            {
                Console.WriteLine($"enter the x of center of circle {i+1}");
                Xs[i] = int.Parse(Console.ReadLine());
                Console.WriteLine($"enter the y of center of circle {i + 1}");
                Ys[i] = int.Parse(Console.ReadLine());
                Console.WriteLine($"enter the radios of circle {i + 1}");
                Radiouses[i] = double.Parse(Console.ReadLine());
                Console.WriteLine("-------------------------");
                Mycircles_1[i] = new circle(Xs[i],Ys[i],Radiouses[i]);
            }
            int counter = 0;
            for (int j = 0; j < numbers ;j++)
            {
                Mycircles_2[counter] = Mycircles_1[j];
                    counter++;
                    Mycircles_2[counter] = circle.copy(Mycircles_1[j]);
                    counter++;
                
            }
            for(int i =0; i < numbers * 2; i++)
            {
                Areas[i] = circle.Area(Mycircles_2[i]);
                Circumferences[i] = circle.Circumference(Mycircles_2[i]);
                Distances[i] = circle.CenterDistanceFromO(Mycircles_2[i]);
            }
            Sort(Areas);
            Sort(Circumferences);
            Sort(Distances);
            Console.WriteLine("1 : sorted by area - 2 : sorted by circumference - 3 : sorted by distance");
            Console.WriteLine("please choose one of above numbers");
            int choosedNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("-------------------------");
            for (int i =0; i < numbers * 2; i++)
            {
                if (choosedNumber == 1)
                {
                    Console.WriteLine($"Number{i + 1} : ");
                    Console.WriteLine($"area : {Areas[i]}");
                    Console.WriteLine("-------------------------");
                }
                if (choosedNumber == 2)
                {
                    Console.WriteLine($"Number{i + 1} : ");
                    Console.WriteLine($"circumferences : {Circumferences[i]}");
                    Console.WriteLine("-------------------------");
                }
                if (choosedNumber == 3)
                {
                    Console.WriteLine($"Number{i + 1} : ");
                    Console.WriteLine($"distance : {Distances[i]}");
                    Console.WriteLine("-------------------------");
                }
            }
        }
    }
}

