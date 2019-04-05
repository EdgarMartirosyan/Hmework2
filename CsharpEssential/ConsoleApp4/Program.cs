using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOne = { 2, 3,5,6,8};
            int a = 0;
            for (int i = 0; i < arrayOne.Length; i++)
            {
                a = arrayOne[i] * (int)Math.Pow(10,arrayOne.Length-i-1) + a;

                Console.WriteLine(arrayOne[i]);
            }
           ///
           
            Console.WriteLine(a);
        }
    }
}
