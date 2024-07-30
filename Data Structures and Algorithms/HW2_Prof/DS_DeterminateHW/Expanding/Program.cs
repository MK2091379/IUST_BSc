using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Expanding
{
    public class Point
    {
        public double x;
        public double y;
        public Point(double x,double y)
        {
            this.x = x;
            this.y = y;
        }
    }
    class Program
    {
        public static void print_array(List<List<double>> array)
        {
            foreach (var i in array)
            {
                foreach (var j in i)
                {
                    Console.Write(j);
                    if(j>=10)
                        Console.Write(" ");
                    else
                        Console.Write("  ");
                }
                Console.WriteLine();
            }
        }
        public static List<List<double>> kahad(List<List<double>> arraye , List<Point> points)
        {
            List<List<double>> newAr = new List<List<double>>();
            for(int i = 0; i < arraye.Count; i++)
            {
                bool okX = true;
                foreach(var k in points)
                {
                    if (i == k.x)
                        okX = false;
                }
                if (okX)
                {
                    var col = new List<double>();
                    for (int j = 0; j < arraye[i].Count; j++)
                    {
                        bool oky = true;
                        foreach (var k in points)
                        {
                            if (j == k.y)
                                oky = false;
                        }
                        if (oky)
                            col.Add(arraye[i][j]);
                    }
                    newAr.Add(col);
                }
            }
            return newAr;
        }
        public static double expandingDet(List<List<double>> ar)
        {
            if (ar.Count == 0)
                return 1;
            else if (ar.Count == 1)
                return ar[0][0];
            else if (ar.Count == 2)
                return (ar[0][0] * ar[1][1]) - (ar[0][1] * ar[1][0]);
            int i = 0;
            double sum = 0;
            for(int j = 0; j < ar.Count; j++)
            {
                var zarib = Math.Pow(-1, j);
                sum += zarib * ar[i][j] * expandingDet(kahad(ar,new List<Point>() { new Point(i, j) }));
            }
            return sum;
        }
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            var arr = new List<List<double>>();
            for (int i = 0; i < n; i++)
            {
                var col = new List<double>();
                for (int j = 0; j < n; j++)
                {
                    col.Add(new Random().Next(1, 20));
                }
                arr.Add(col);
            }
            print_array(arr);
            Console.WriteLine(expandingDet(arr));
        }
    }
}
