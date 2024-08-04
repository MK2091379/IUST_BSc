using System;
using System.Collections;
using System.Collections.Generic;
namespace MatrixAndVector
{
    public class Vector<T> : IEnumerable<T>, IEquatable<Vector<T>>,ICollection<T>
    {
        public static bool operator ==(Vector<T> LeftHandSide, Vector<T> RightHandSide)
        {
            return LeftHandSide.Equals(RightHandSide);
        }
        public static bool operator !=(Vector<T> LeftHandSide, Vector<T> RightHandSide)
        {
            return !LeftHandSide.Equals(RightHandSide);
        }
        public static Vector<T> operator +(Vector<T> LeftHandSide, Vector<T> RightHandSide)
        {
            if (LeftHandSide.Length() == RightHandSide.Length())
            {
                try
                {
                    List<T> LeftHandSideInfo = new List<T>();
                    List<T> RightHandSideInfo = new List<T>();
                    List<T> resultList = new List<T>();
                    foreach (var elements in LeftHandSide)
                    {
                        LeftHandSideInfo.Add(elements);
                    }
                    foreach (var elements in RightHandSide)
                    {
                        RightHandSideInfo.Add(elements);
                    }
                    for (int i = 0, j = 0; i < LeftHandSideInfo.Count && j < RightHandSideInfo.Count; i++, j++)
                    {
                        dynamic LeftSideElement = LeftHandSideInfo[i];
                        dynamic RightSideElement = RightHandSideInfo[j];
                        resultList.Add(LeftSideElement + RightSideElement);
                    }
                    return new Vector<T>(resultList);
                }
                catch
                {
                    Vector<T> nullVector = null;
                    Console.WriteLine("you can not use this operator for this datatype.");
                    return nullVector;
                }
            }
            else
            {
                Vector<T> nullVector = null;
                Console.WriteLine("you can not sum these vectors");
                return nullVector;
            }
        }
        public static double? operator *(Vector<T> LeftHandSide, Vector<T> RightHandSide)
        {
            if (LeftHandSide.Length() == RightHandSide.Length())
            {
                try
                {
                    List<T> LeftHandSideInfo = new List<T>();
                    List<T> RightHandSideInfo = new List<T>();
                    List<T> resultList = new List<T>();
                    foreach (var elements in LeftHandSide)
                    {
                        LeftHandSideInfo.Add(elements);
                    }
                    foreach (var elements in RightHandSide)
                    {
                        RightHandSideInfo.Add(elements);
                    }
                    for (int i = 0, j = 0; i < LeftHandSideInfo.Count && j < RightHandSideInfo.Count; i++, j++)
                    {
                        dynamic LeftSideElement = LeftHandSideInfo[i];
                        dynamic RightSideElement = RightHandSideInfo[j];
                        resultList.Add(LeftSideElement * RightSideElement);
                    }
                    double sum = 0;
                    foreach (var element in resultList)
                        sum += Convert.ToDouble(element);
                    return sum;
                }
                catch
                {
                    Console.WriteLine("you can not use this operator for this datatype.");
                    return null;
                }
            }
            else
            {
                Console.WriteLine("you can not multiple these vectors");
                return null;
            }
        }
        public static implicit operator Vector<T>(List<T> initList)
        {
            return new Vector<T>(initList);
        }
        public static explicit operator Vector<T>(T[] initArr)
        {
            List<T> arrTolist = new List<T>(initArr);
            return new Vector<T>(arrTolist);
        }
        private List<T> list = new List<T>();
        public T this[int i] => list[i];
        public Vector(List<T> inputs)
        {
            foreach (T elements in inputs)
                list.Add(elements);
        }
        public Vector(int size)
        {
            list = new List<T>(size);
        }
        public bool Equals(Vector<T> other)
        {
            bool output = true;
            List<T> info = new List<T>();
            foreach (var element in other)
                info.Add(element);
            for (int i = 0, j = 0; i < list.Count && j < info.Count; i++, j++)
            {
                if (list[i].Equals(info[j]))
                {
                    output = true;
                    continue;
                }
                else
                {
                    output = false;
                    break;
                }
            }
            return output;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new VectorEnum<T>(list);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }
        public override string ToString()
        {
            string output = "";
            foreach (var element in list)
            {
                output += element;
                output += ",";
            }
            output = output.Remove(output.Length - 1);
            return "[" + output + "]";
        }
        public int Length()
        {
            return list.Count;
        }
        public bool Contains(T item)
        {
            bool found = false;

            foreach (var element in list)
            {
                if (element.Equals(item))
                {
                    found = true;
                }
            }

            return found;
        }
        public bool Contains(T item, EqualityComparer<T> comp)
        {
            bool found = false;

            foreach (var bx in list)
            {
                if (comp.Equals(bx, item))
                {
                    found = true;
                }
            }

            return found;
        }
        public void Add(T item)
        {

            if (!Contains(item))
            {
                list.Add(item);
            }
            else
            {
                Console.WriteLine("already exist");
            }
        }

        public void Clear()
        {
            list.Clear();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            if (array == null)
                throw new ArgumentNullException("The array cannot be null.");
            if (arrayIndex < 0)
                throw new ArgumentOutOfRangeException("The starting array index cannot be negative.");
            if (Count > array.Length - arrayIndex + 1)
                throw new ArgumentException("The destination array has fewer elements than the collection.");

            for (int i = 0; i < list.Count; i++)
            {
                array[i + arrayIndex] = list[i];
            }
        }

        public int Count
        {
            get
            {
                return list.Count;
            }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public bool Remove(T item)
        {
            bool result = false;
            for (int i = 0; i < list.Count; i++)
            {

                T curBox = (T)list[i];

                if (item.Equals(curBox))
                {
                    list.RemoveAt(i);
                    result = true;
                    break;
                }
            }
            return result;
        }
    }
}