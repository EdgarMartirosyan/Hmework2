using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_07_03
{
    class Program
    {
        static void Main(string[] args)
        {
            bool arrayEqual = true;
            char[] arrA = new char[6] { 'a', 'b', 'c', 'd', 'e', 'e' };
            char[] arrB = new char[5] { 'B', 'b', 'c', 'd', 'e' };


            for (int i = 0; i < Math.Min(arrA.Length, arrB.Length); i++)
            {
                if (arrA[i] < arrB[i])
                {
                    Console.WriteLine("First array is lexicographicaly first.");
                    arrayEqual = false;
                    break;
                }
                if (arrA[i] > arrB[i])
                {
                    Console.WriteLine("Second array is lexicographicaly first.");
                    arrayEqual = false;
                    break;
                }
            }

            if (arrayEqual && arrA.Length != arrB.Length)
            {
                if (arrA.Length > arrB.Length)
                {
                    Console.WriteLine("Second array is lexicographicaly first.");
                }
                else
                {
                    Console.WriteLine("First array is lexicographicaly first.");
                }
            }

            if(arrayEqual)
            {
                Console.WriteLine("Arrays are lexicographicaly equal.");
            }
            Console.ReadKey();
        }
    }
}
