using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_03_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            //  int b = Convert.ToInt16(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine("Number is even");
            }
            else
            {
                Console.WriteLine("Number is odd");
            }
            Console.ReadKey();
        }
    }
}
