using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_158
{
    class Program
    {
        // kaitaryal tver
        static void Main(string[] args)
        {
            int n = 10000;
            int sum = 0;
            
            for (int j = 1; j <= n; j++)
            {
                int i ;
                for ( i = 1; i < j; i++)
                {
                    bool o = false;
                    if (j % i == 0)
                    {
                        o = true;
                    }
                    if (o)
                    {
                        sum += i;
                    }
                }
                if (j == sum)
                {
                    Console.WriteLine(j);
                }
                sum = 0;
            }

           

            Console.ReadKey();
        }
    }
}
