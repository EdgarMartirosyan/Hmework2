using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_11_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rar = new Random();
            int[] array = new int[10];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rar.Next(100, 200);
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]}, ");
            }
            Console.ReadKey();
        }
    }
}
