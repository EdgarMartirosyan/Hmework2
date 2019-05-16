using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_07_04
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 4, 2, 3, 4, 4, 4, 4, 4, 4, 5,12, 12, 12, 12, 12, 12, 12, 12 };
            int count = 1;
            int max = 0;
            int j = 0;

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] == array[i + 1])
                {
                    count++;
                }
                else
                {
                    count = 1;
                }

                if (count > max)

                {
                    j = array[i];
                    max = count;
                }
            }
            Console.WriteLine(j);
            Console.WriteLine(max);
            Console.WriteLine();
            int[] arrayNew = new int[max];
            for (int i = 0; i < arrayNew.Length; i++)
            {
                arrayNew[i] = j;
            }
            Console.Write("{");
            for (int i = 0; i < arrayNew.Length; i++)
            {

                Console.Write($"{arrayNew[i]},");

            }
            Console.Write("}");
            Console.ReadKey();
        }
    }
}
