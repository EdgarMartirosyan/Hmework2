using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_152
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 168965646;
            int a;
                     
            for (int i = 0; i < n; n/=10)
            {
                a = n % 10;
                Console.Write(a+", ");
            }
            Console.ReadKey();
        }
    }
}
