using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_07_05
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 0, 1, 2, 3, 4, 4, 5, 6, 7, 8, 8, 10, 11, 9, 1, 2, 4, 4, 5 };
            int max = 0;
            int count = 1;
            int toarray = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i + 1] - array[i] == 1)
                {
                    count++;
                }
                else
                {
                    count = 1;
                }

                if (count > max)
                {
                    toarray = array[i + 1];
                    max = count;
                }
            }
            Console.WriteLine(max);
            Console.WriteLine(toarray);
            for (int i = toarray - max + 1; i <= toarray; i++)
            {
                Console.WriteLine(i);
            }
            
            Console.ReadKey();

        }
    }
}
