using System;
using System.Collections;
using System.Collections.Generic;

namespace MatrixAndVector
{
    public class VectorEnum<T> : IEnumerator<T>
    {
        public List<T> _vector;
        int position = -1;
        public VectorEnum(List<T> list)
        {
            _vector = list;
        }
        public bool MoveNext()
        {
            position++;
            return (position < _vector.Count);
        }
        public void Reset()
        {
            position = -1;
        }
        public void Dispose()
        {

        }
        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public T Current
        {
            get
            {
                try
                {
                    return _vector[position];
                }
                catch
                {
                    throw new IndexOutOfRangeException();
                }
            }
        }
    }
}