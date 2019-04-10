using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_151
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5623;
            int i;
            for ( i=0 ; i < n; i++)
            {
                n /= 10;
            }
        
            Console.WriteLine(i);
            Console.ReadKey();
        }
    }
}
