using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 7, 3, 3, 16, 2 };
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
            }


            for (int i = 0; i < array.Length; i++)
            {
                for (int q = 0; q < array.Length; q++)
                {
                    if (array[i]<=array[q])
                    {
                        int a=array[i];
                        array[i] = array[q];
                        array[q] = a;
                    }
                }
            }
            Console.WriteLine();

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.ReadKey();
        }
    }
}
