using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_06_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write($"{i}, ");
            }
            Console.ReadKey();
        }
    }
}
