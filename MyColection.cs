using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace H_W_Mod3_1
{
    public class MyList<T> : IEnumerable<T>
        where T : IComparable<T>, IComparable
    {
        private T[] _array = Array.Empty<T>();
       
        public T this[int index]
        {
            get { return _array[index]; }
            set { _array[index] = value; }
        }
        public int Count()
        { 
            return _array.Length;
        }
        public void Sort() =>
            _array.Take(Count()).OrderBy(el => el).ToArray().CopyTo(_array, 0);

        public void Add(T value)
        {
            var newArray = new T[_array.Length + 1];
            for (int i = 0;i < _array.Length; i++)
            {
                newArray[i] = _array[i];
            }
            newArray[_array.Length] = value;
            _array = newArray;
     
        }
        public void SetDefaultAt(int index)
        {
            T[] newArray = new T[this._array.Length];
            for (int i = 0; i < this._array.Length; i++)
            {
                if (i == index)
                {
                    newArray[i] = default(T);
                }
                else
                {
                    newArray[i] = this._array[i];
                }
            }

            this._array = newArray;
        }

        public IEnumerator<T> GetEnumerator()
        {
            int index = 0;
            while (index < _array.Length)
            {
                yield return _array[index];
                index++;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}