using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_07_07
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 2, 3, 5, 6, 7, 1, 1, 1, 1, 1, 100, };
            Console.WriteLine("mutqagrel k");
            int k = int.Parse(Console.ReadLine());
            if (k > array.Length)
            {
                Console.WriteLine("k n petq e poqr lini zangvaci mecutyunic");
            }
            int max = 0;
            int sum = 0;
            for (int i = 0; i <= array.Length - k; i++)
            {
                for (int j = i; j < k + i; j++)
                {
                    sum += array[j];
                }

                if (sum > max)
                {
                    max = sum;
                }
                sum = 0;

            }
            Console.WriteLine($"{k} hajordakan elemnentneri amneamec gumary {max}");
            Console.ReadLine();
        }
    }
}
