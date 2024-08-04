using System;

namespace complexNumber
{
    class Complex
    {
        public int a;
        public int b;
        public int c;
        public int d;
        public void start()
        {
            Console.WriteLine("please enter a and b");
            this.a = int.Parse(Console.ReadLine());
            this.b = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter c and d");
            this.c = int.Parse(Console.ReadLine());
            this.d = int.Parse(Console.ReadLine());
            Console.WriteLine("-----------------------");
        }
        public void add()
        {
            Console.WriteLine($"({a} + {b}i) + ({c} + {d}i) = {a + c} + {b + d}i");
        }
        public void sub()
        {
            Console.WriteLine($"({a} + {b}i) - ({c} + {d}i) = {a - c} + {b - d}i");
            Console.WriteLine($"({c} + {d}i) - ({a} + {b}i) = {c - a} + {d - b}i");
        }
        public void mul()
        {
            Console.WriteLine($"({a} + {b}i) * ({c} + {d}i) = {a * c - b * d} + {a * d + b * c}i");
        }
        public void div()
        {
            double token_1 = (double)(a * c + b * d) / (c * c + d * d);
            double token_2 = (double)(b * c - a * d) / (c * c + d * d);
            double token_3 = (double)(a * c + b * d) / (a * a + b * b);
            double token_4 = (double)(a * d - b * c) / (a * a + b * b);
            if ((c * c + d * d) == 0 || (c * c + d * d) == 0 || (a * a + b * b) == 0 || (a * a + b * b) == 0)
                Console.WriteLine("divide by zero");
            else
            {
                Console.WriteLine($"({a} + {b}i) / ({c} + {d}i) = {token_1} + {token_2}i");
                Console.WriteLine($"({c} + {d}i) / ({a} + {b}i) = {token_3} + {token_4}i");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Complex myComplex = new Complex();
            myComplex.start();
            Console.WriteLine("add : 1 - sub : 2 - mul : 3 - div : 4");
            Console.WriteLine("please choose one of above number");
            Console.WriteLine("-----------------------");
            int inpute = int.Parse(Console.ReadLine());
            if (inpute == 1)
                myComplex.add();
            if (inpute == 2)
                myComplex.sub();
            if (inpute == 3)
                myComplex.mul();
            if (inpute == 4)
                myComplex.div();
        }
    }
}
