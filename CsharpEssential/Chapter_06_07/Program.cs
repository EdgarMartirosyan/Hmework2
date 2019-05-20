using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_06_07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("mutqagrel K! (K>1)");
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine("mutqagrel N! (N>K)");
            int n = int.Parse(Console.ReadLine());
            int nMinusK = n - k;
            
            for (int i = n - 1; i > 0; i--)
            {
                n *= i;
            }
            for (int i = k - 1; i > 0; i--)
            {
                k *= i;
            }
            for (int i = nMinusK - 1; i > 0; i--)
            {
                nMinusK *= i;
            }
            Console.WriteLine($"N!*K!/ (N - K)!={n*k/nMinusK}");

            Console.ReadLine();
        }
    }
}
