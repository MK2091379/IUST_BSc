using System;
using System.Collections;
using System.Collections.Generic;

namespace FinalExam5
{
    class FunnyCol<T> : IEnumerable<T>
    {
        List<T> list = new List<T>();
        public IEnumerator<T> GetEnumerator()
        {
            foreach (var element in list)
                yield return element;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public void InCol(params T [] arr)
        {
            List<T> first = new List<T>();
            List<T> second = new List<T>();
            int lastElement= Array.IndexOf(arr , arr[arr.Length - 1]);
            int otherlastElement = Array.IndexOf(arr, arr[arr.Length - 2]);
            while (lastElement != 0)
            {
                first.Add(arr[lastElement]);
                lastElement = lastElement - 2;
            }
            while (otherlastElement != 0)
            {
                second.Add(arr[otherlastElement]);
                otherlastElement = otherlastElement - 2;
            }
            second.Reverse();
            first.AddRange(second);
            list = new List<T>(first);
        }
        public void OutCol()
        {
            list.Remove(list[0]);
            list.Remove(list[list.Count-1]);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
