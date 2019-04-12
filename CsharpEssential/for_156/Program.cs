using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_156
{
    class Program
    {
        // fibonachi
        static void Main(string[] args)
        {
            int n = 20;
            int j = 1;
            for (int i = 1; i <= n; i+=j)
            {
                j = i - j;
                Console.WriteLine(j);
            }
            
            Console.ReadKey();
        }
    }
}
