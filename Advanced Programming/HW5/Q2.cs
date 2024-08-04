using System;
using static System.Math;

namespace Math
{
    class Point
    {
        protected double x;
        protected double y;
        public virtual void init()
        {
            Console.WriteLine("Please enter the x");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the y");
            double y = double.Parse(Console.ReadLine());
            this.x = x;
            this.y = y;
        }
        public virtual void Print()
        {
            Console.WriteLine($"x : {this.x} , y : {this.y}");
        }
        public virtual void IDShape()
        {
            Console.WriteLine($"ID : {this.x + this.y}");
        }
    }
    class Circle : Point
    {
        protected double radious;
        public override void init()
        {
            Console.WriteLine("Please enter the x");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the y");
            double y = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the radious");
            double radious = double.Parse(Console.ReadLine());
            if(radious == 0)
            {
                do
                {
                    Console.WriteLine("the radious can not take 0");
                    double editedRadious = double.Parse(Console.ReadLine());
                    radious = editedRadious;
                } while (radious == 0);
            }
            this.x = x;
            this.y = y;
            this.radious=Program.Abs(radious);
        }
        public virtual void environment()
        {
            Console.WriteLine($"environment : {2 * PI * this.radious}");
        }
        public virtual void area()
        {
            Console.WriteLine($"area : {PI*this.radious*this.radious}");
        }
        public override void Print()
        {
            Console.WriteLine($"x : {this.x} , y : {this.y} , radios : {this.radious}");
        }
        public override void IDShape()
        {
            Console.WriteLine($"ID : {this.x + this.y + this.radious}");
        }
    }
    class Cylinder : Circle
    {
        double height;
        public override void init()
        {
            Console.WriteLine("Please enter the x");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the y");
            double y = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the radious");
            double radious = double.Parse(Console.ReadLine());
            if (radious == 0)
            {
                do
                {
                    Console.WriteLine("the radious can not take 0");
                    double editedRadious = double.Parse(Console.ReadLine());
                    radious = editedRadious;
                } while (radious == 0);
            }
            Console.WriteLine("Please enter the height");
            double height = double.Parse(Console.ReadLine());
            if (height == 0)
            {
                do
                {
                    Console.WriteLine("the height can not take 0");
                    double editedHeight = double.Parse(Console.ReadLine());
                    radious = editedHeight;
                } while (height == 0);
            }
            this.x = x;
            this.y = y;
            this.radious = Program.Abs(radious);
            this.height = Program.Abs(height);
        }
        public override void Print()
        {
            Console.WriteLine($"x : {this.x} , y : {this.y} , radios : {this.radious} , height : {this.height}");
        }
        public override void IDShape()
        {
            Console.WriteLine($"ID : {this.x + this.y + this.radious + this.height}");
        }
        public override void environment()
        {
            Console.WriteLine($"environment : {2 * PI * this.radious}");
        }
        public override void area()
        {
            Console.WriteLine($"area : { (2 * PI * this.radious * this.radious) + (2 * PI * this.radious * this.height)}");
        }
        public void capacity()
        {
            Console.WriteLine($"capacity : {PI * this.radious * this.radious * this.height}");
        }
    }
    class Program
    {
        public static double Abs(double n)
        {
            double nABS = 0;
            if (n >= 0)
                nABS = n;
            else
                nABS = -n;
            return nABS;
        }
        public static void Menu()
        {
            while (true)
            {
                Console.WriteLine("Choose --Point-- , --Circle-- , --Cylinder-- , --exite--");
                string input = Console.ReadLine();
                if (input.ToLower() == "point")
                {
                    Point point = new Point();
                    point.init();
                    point.Print();
                    point.IDShape();
                }
                if (input.ToLower() == "circle")
                {
                    Circle circle = new Circle();
                    circle.init();
                    circle.Print();
                    circle.IDShape();
                    circle.environment();
                    circle.area();
                }
                if (input.ToLower() == "cylinder")
                {
                    Cylinder cylinder = new Cylinder();
                    cylinder.init();
                    cylinder.Print();
                    cylinder.IDShape();
                    cylinder.environment();
                    cylinder.area();
                    cylinder.capacity();
                }
                if (input.ToLower() == "exite")
                    break;
                if (input != "circle" && input != "point" && input != "cylinder")
                {
                    Console.WriteLine("incorect input");
                    Menu();
                }
            }
        }
        static void Main(string[] args)
        {
            Menu();
        }

    }
}
