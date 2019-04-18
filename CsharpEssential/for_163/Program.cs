using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_163
{
    class Program
    {
        static void Main(string[] args)
        {
            int l = 5;
            int h = 5;
            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < l; j++)
                {
                    if (i==0|| j==0||i==(h-1)||j==(l-1))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                   
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
