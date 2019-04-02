using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_06_04
{
    static class Extend
    {
        static public void Sort(this int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i] >= array[j])
                    {
                        int n = array[i];
                        array[i] = array[j];
                        array[j] = n;
                    }
                }
            }
        }
        static public void Dublicate(this int[] array)
        {

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[] { 8, 6, 4, 18, 1, 3, 5, 4, 28 };

            array1.Sort();
            foreach (var item in array1)
            {
                Console.WriteLine(item + ", ");
            }

            Console.ReadLine();
        }
    }
}
