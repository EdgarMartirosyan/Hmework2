using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_155
{
    class Program
    {
        // astichan
        static void Main(string[] args)
        {
            int a = 5;
            int b = 3;
            int result=1;

            for (int i = 0; i < b; i++)
            {
                result*=  a;
            }
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
