using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_153
{
    class Program
    {
        static void Main(string[] args)
        {
            //tivy nerkayacnel parz artadrichneri artadryali tesqov
            int x = 3793;
            for (int i = 0; x%2==0; x/=2)
            {
                Console.Write("*"+2);
            }
            for (int i = 3; i <=x; )
            {
                if (x%i==0)
                {
                    Console.Write("*"+i );
                    x /= i;
                }
                else
                {
                    i += 2;
                }
            }

            Console.ReadKey();
        }
    }
}
