using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_05_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("insert a");
            int a = Int32.Parse(Console.ReadLine());

            Console.WriteLine("insert b");
            int b = Int32.Parse(Console.ReadLine());
            if (a > b)
            {
                a = a + b;
                b = a - b;
                a = a - b;
                Console.WriteLine($"a={a},b={b}");
            }
            else
            {
                Console.WriteLine($"a={a},b={b}");
            }
            Console.ReadKey();
        }
    }
}
