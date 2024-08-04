using System;
using System.Collections;
using System.Collections.Generic;
namespace MatrixAndVector
{
    class squarMatrix<T>:Matrix<T>
    {
        List<Vector<T>> Vectors = new List<Vector<T>>();
        public squarMatrix(List<Vector<T>> vectors) : base(vectors)
        {
            if (vectors.Count != vectors[0].Length())
            {
                Console.WriteLine("in squar matrix number of rows and number of columns are same ");
                Vectors.Clear();
            }
        }
        public squarMatrix(int row, int column):base(row,column)
        {
            if(column != row)
            {
                Console.WriteLine("in squar matrix number of rows and number of columns are same ");
                Vectors.Clear();
            }
        }
        public static implicit operator squarMatrix<T>(List<Vector<T>> initList)
        {
            return new squarMatrix<T>(initList);
        }
        public static explicit operator squarMatrix<T>(Vector<T>[] initArr)
        {
            List<Vector<T>> arrTolist = new List<Vector<T>>(initArr);
            return new squarMatrix<T>(arrTolist);
        }
    }
}