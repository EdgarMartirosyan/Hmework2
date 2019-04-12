using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_154
{
    class Program
    {
        // factorial
        static void Main(string[] args)
        {
            int n = 5;
            int factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;

            }
            Console.WriteLine(factorial);
            Console.ReadKey();
        }
    }
}
