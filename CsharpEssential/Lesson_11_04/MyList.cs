using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_11_04
{
    public interface IMyList<T>//:ICollection<T>,IEnumerable<T>
    {
        void Add(T a);
        T this[int index] { get; }
        int Count { get; }
        void Clear();
        bool Contians(T item);
    }

    class MyList<T>:IMyList<T>
    {
        private T[] array;

        public MyList()
        {
            array = new T [0];
        }

        public void Add(T a)
        {
            T[] tempArray = new T[array.Length + 1];
            for (int i = 0; i < array.Length; i++)
            {
                tempArray[i] = array[i];
            }
            tempArray[array.Length] = a;
            array = tempArray;
        }

    }
}
