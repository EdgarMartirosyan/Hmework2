using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_06_05
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 200;
            int a = 1;


            for (int i = 1; i <= n; i = i + a)
            {
                a = i - a;
                Console.WriteLine(a);
            }

            Console.ReadKey();
        }
    }
}
