using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_07_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[20];
            //Console.WriteLine(array.Length);
            //Console.WriteLine(array.IsFixedSize);
            //Console.WriteLine(array.IsReadOnly);
            //Console.WriteLine(array.IsSynchronized);
            //Console.WriteLine(array.LongLength);
            //Console.WriteLine(array.Rank);
            //Console.WriteLine(array.SyncRoot);

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i * 5;
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]}, ");
            }
            Console.ReadKey();
        }
    }
}
