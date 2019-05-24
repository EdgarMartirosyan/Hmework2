using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //int[,] array = new int[n,n];

            //for (int i = 1; i < array.GetLength(0); i++)
            //{
            //    for (int j = 1;  j< array.GetLength(1); j++)
            //    {
            //        array[i, j] = i + j - 1;
            //        Console.Write(array[i,j]);
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine(array.GetLength(0));
            //Console.WriteLine(array.GetLength(1));
            for (int i = 1; i < n; i++)
            {
                for (int j = i; j < n+i; j++)
                {
                    Console.Write(j+new string(' ',));
                }
                Console.WriteLine();
            }

        }
    }
}
