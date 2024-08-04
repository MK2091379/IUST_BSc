using System;
using static System.Math;
namespace circle
{
    class circle
    {
        public int X;
        int Y;
        double Radious;
        public circle(int x,int y,double radiuos)
        {
            this.X = x;
            this.Y = y;
            this.Radious = radiuos;
        }
        public void Circumference()
        {
            double circumference = 2*PI*this.Radious;
            Console.WriteLine("the cicumference of circle is : {0}", circumference);
        }
        public void Area()
        {
            double area = PI * Pow(this.Radious, 2);
            Console.WriteLine("the area of circle is : {0}", area);
        }
        public void Distance (int x , int y)
        {
            double distance = Math.Sqrt(Pow(x, 2) + Pow(y, 2));
            Console.WriteLine("the distance from O is : {0}", distance);
        }
        /*public void DistanceFromCenter(int x, int y)
        {
            double distance_from_center = Math.Sqrt(Pow(x-this.X, 2) + Pow(y-this.Y, 2));
            Console.WriteLine("the distance from center of circle is :{0}", distance_from_center);
        }*/
        public void Point(int x, int y)
        {
            double distance_from_center = Math.Sqrt(Pow(x - this.X, 2) + Pow(y - this.Y, 2));
            Console.WriteLine("distance from center of circle is : {0}",distance_from_center);
            if (distance_from_center > this.Radious)
                Console.WriteLine("the point is out of circle");
            if (distance_from_center == this.Radious)
                Console.WriteLine("the point is on the circle");
            if (distance_from_center < this.Radious)
                Console.WriteLine("the point is in the circle");
        }
        public void Lap(circle P)
        {
            double centers_distance = Math.Sqrt(Pow(this.X - P.X, 2) + Pow(this.Y - P.Y, 2));
            if (centers_distance >= P.Radious + this.Radious || (Math.Abs(P.Radious - this.Radious) < centers_distance && centers_distance < P.Radious + this.Radious))
                Console.WriteLine("false");
            
            else
                Console.WriteLine("true"); 

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("enter the x of first circle center ");
            int input_1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the y of first circle center ");
            int input_2 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the radious of first circle  ");
            double input_3 = double.Parse(Console.ReadLine());
            circle c1 = new circle(input_1,input_2,input_3);
            Console.WriteLine("-------------------------");
            c1.Circumference();
            c1.Area();
            Console.WriteLine("-------------------------");
            Console.WriteLine("enter the x of point ");
            int input_7 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the y of point ");
            int input_8 = int.Parse(Console.ReadLine());
            Console.WriteLine("-------------------------");
            c1.Point(input_7, input_8);
            Console.WriteLine("-------------------------");
            Console.WriteLine("enter the x of second circle center ");
            int input_4 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the y of second circle center ");
            int input_5 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the radious of second circle  ");
            double input_6 = double.Parse(Console.ReadLine());
            circle c2 = new circle(input_4, input_5, input_6);
            c1.Lap(c2);
        }
    }
}

