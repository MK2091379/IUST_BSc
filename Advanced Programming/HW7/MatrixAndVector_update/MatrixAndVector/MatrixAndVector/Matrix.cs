using System;
using System.Collections;
using System.Collections.Generic;
namespace MatrixAndVector
{
     class Matrix<T>:IEnumerable<Vector<T>>, IEquatable<Matrix<T>>,ICollection<Vector<T>>
     {
        List<Vector<T>> Vectors = new List<Vector<T>>();
        public Vector<T> this[int i] => Vectors[i];
        public T this[int i , int j] => Vectors[i][j];
        public static bool operator ==(Matrix<T> LeftHandSide, Matrix<T> RightHandSide)
        {
            return LeftHandSide.Equals(RightHandSide);
        }
        public static bool operator !=(Matrix<T> LeftHandSide, Matrix<T> RightHandSide)
        {
            return !LeftHandSide.Equals(RightHandSide);
        }
        public Matrix(List<Vector<T>> vectors)
        {
            int defaultLength = vectors[0].Length();
            foreach (Vector<T> element in vectors)
            {
                if (element.Length() == defaultLength)
                {
                        this.Vectors.Add(element);
                }
                else
                {
                    Console.WriteLine("length of rows is diferent");
                    this.Vectors = new List<Vector<T>>();
                    break;
                }
            }
        }
        public Matrix(int row , int column)
        {
            Vectors = new List<Vector<T>>(row);
            foreach(var element in Vectors)
            {
                if (element.Length() != column)
                {
                    Console.WriteLine("length of vectors are difrent");
                    Vectors.Clear();
                }
            }
        }
        public static Matrix<T> operator +(Matrix<T> LeftHandSide, Matrix<T> RightHandSide)
        {
            if ((LeftHandSide.Length() == RightHandSide.Length()) && (LeftHandSide[0].Length() == RightHandSide[0].Length()))
            {
                try
                {
                    List<Vector<T>> LeftHandSideInfo = new List<Vector<T>>();
                    List<Vector<T>> RightHandSideInfo = new List<Vector<T>>();
                    List<Vector<T>> resultList = new List<Vector<T>>();
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
                    return new Matrix<T>(resultList);
                }
                catch
                {
                    Matrix<T> nullMatrix = null;
                    Console.WriteLine("you can not use this operator for this datatype.");
                    return nullMatrix;
                }
            }
            else
            {
                Console.WriteLine("you can not sum these mitrixes");
                Matrix<T> nullMatrix = null;
                return nullMatrix;
            }
        }
        public static Matrix<double?> operator *(Matrix<T> LeftHandSide, Matrix<T> RightHandSide)
        {
            if (LeftHandSide[0].Length() == RightHandSide.Length())
            {
                try
                {
                    List<T> RightHandSideInfo;
                    List<double?> result = new List<double?>();
                    List<Vector<T>> LeftHandSideVector = new List<Vector<T>>();
                    List<Vector<T>> RightHandSidevector = new List<Vector<T>>();
                    List<Vector<double?>> resultVector = new List<Vector<double?>>();
                    foreach (var element in LeftHandSide)
                    {
                        LeftHandSideVector.Add(element);
                    }
                    for (int i = 0; i < RightHandSide[0].Length(); i++)
                    {
                        RightHandSideInfo = new List<T>();
                        for (int j = 0; j < RightHandSide.Length(); j++)
                            RightHandSideInfo.Add(RightHandSide[j][i]);
                        RightHandSidevector.Add(new Vector<T>(RightHandSideInfo));
                    }
                    foreach (var leftVector in LeftHandSideVector)
                    {
                        foreach (var rightVector in RightHandSidevector)
                        {
                            result.Add(leftVector * rightVector);
                        }
                        resultVector.Add(new Vector<double?>(result));
                        result = new List<double?>();
                    }
                    return new Matrix<double?>(resultVector);
                }
                catch
                {
                    Matrix<double?> nullMatrix = null;
                    Console.WriteLine("you can not use this operator for this datatype.");
                    return nullMatrix;
                }
            }
            else
            {
                Console.WriteLine("you can not multiple these mitrixes");
                Matrix<double?> nullMatrix = null;
                return nullMatrix;
            }
        }
        public static implicit operator Matrix<T>(List<Vector<T>> initList)
        {
            return new Matrix<T>(initList);
        }
        public static explicit operator Matrix<T>(Vector<T>[] initArr)
        {
            List<Vector<T>> arrTolist = new List<Vector<T>>(initArr);
            return new Matrix<T>(arrTolist);
        }
        public bool Equals(Matrix<T> other)
        {
            bool output = true;
            List<Vector<T>> info = new List<Vector<T>>();
            foreach (var element in other)
                info.Add(element);
            for (int i = 0, j = 0; i < Vectors.Count && j < info.Count; i++, j++)
            {
                if (Vectors[i].Equals(info[j]))
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
        public IEnumerator<Vector<T>> GetEnumerator()
        {
            foreach (var element in Vectors)
                yield return element;
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public override string ToString()
        {
            try
            {
                string output = "";
                foreach (Vector<T> element in Vectors)
                {
                    output += element.ToString();
                    output += ",";
                    output += "\n";
                }
                output = output.Remove(output.Length - 2);
                return "[" + "\n" + output + "\n" + "]";
            }
            catch
            {
                return null;
            }
        }
        public int Length()
        {
            return Vectors.Count;
        }
        public bool Contains(Vector<T> item)
        {
            bool found = false;

            foreach (var element in Vectors)
            {
                if (element.Equals(item))
                {
                    found = true;
                }
            }

            return found;
        }
        public bool Contains(Vector<T> item, EqualityComparer<Vector<T>> comp)
        {
            bool found = false;

            foreach (var bx in Vectors)
            {
                if (comp.Equals(bx, item))
                {
                    found = true;
                }
            }

            return found;
        }
        public void Add(Vector<T> item)
        {

            if (!Contains(item))
            {
                Vectors.Add(item);
            }
            else
            {
                Console.WriteLine("already exist");
            }
        }

        public void Clear()
        {
            Vectors.Clear();
        }

        public void CopyTo(Vector<T>[] array, int arrayIndex)
        {
            if (array == null)
                throw new ArgumentNullException("The array cannot be null.");
            if (arrayIndex < 0)
                throw new ArgumentOutOfRangeException("The starting array index cannot be negative.");
            if (Count > array.Length - arrayIndex + 1)
                throw new ArgumentException("The destination array has fewer elements than the collection.");

            for (int i = 0; i < Vectors.Count; i++)
            {
                array[i + arrayIndex] = Vectors[i];
            }
        }

        public int Count
        {
            get
            {
                return Vectors.Count;
            }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public bool Remove(Vector<T> item)
        {
            bool result = false;
            for (int i = 0; i < Vectors.Count; i++)
            {

                Vector<T> curBox = (Vector<T>)Vectors[i];

                if (item.Equals(curBox))
                {
                    Vectors.RemoveAt(i);
                    result = true;
                    break;
                }
            }
            return result;
        }
    }
}