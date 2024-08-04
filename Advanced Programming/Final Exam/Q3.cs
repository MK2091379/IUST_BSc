using System;

namespace FinalExam4
{
    class Program
    {
        public static int TestDel(int x , int y , Func<int, int, int> fn)
        {
            return fn(x, y);
        }
        public static int add(int x, int y) => x + y;
        static void Main(string[] args)
        {
            Console.WriteLine(TestDel(1, 2, add));
            Console.WriteLine(TestDel(1, 2, (x, y) => x + y));
        }
    }
}
