using System;
using System.Collections;
using System.Collections.Generic;

namespace SearchingStackByQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int?> Q = new Queue<int?>();
            Stack<int?> S = new Stack<int?>();
            S.Push(0);
            S.Push(1);
            S.Push(2);
            S.Push(3);
            S.Push(4);
            S.Push(5);
            S.Push(6);
            S.Push(7);
            S.Push(8);
            S.Push(9);
            int? x = 20;
            int? y = 1;
            Search(S, Q, x);
            Search(S, Q, y);
        }

        private static void Search(Stack<int?> s, Queue<int?> q, int? x)
        {
            Console.WriteLine($"stack in first : {stringing(s)}" + "\n" + "___________________________");
            bool? found = null; 
            int? sOut = null;
            while (sOut != x && s.Count!=0)
            {
                sOut = s.Pop();
                q.Enqueue(sOut);
                if ((int)sOut==(int)x) found = true;
                else found = false;
            }
            int qCount = q.Count;
            while (q.Count != 0) s.Push(q.Dequeue());
            while (qCount != 0)
            {
                q.Enqueue(s.Pop());
                qCount--;
            }
            while (q.Count != 0) s.Push(q.Dequeue());
            if (found == true) Console.WriteLine("founded" + "\n" +"stack after scanning : " +stringing(s) + "\n" + "___________________________");
            else Console.WriteLine("not founded" + "\n" + "stack after scanning : "+ stringing(s) + "\n" + "___________________________");
        }

        private static string stringing(Stack<int?> s)
        {
            string outPut = "";
            foreach (var x in s)
                outPut += $"{x}  ";
            return outPut;
        }
    }
}
