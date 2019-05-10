using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_06_03
{
    class Program
    {
        static void Main(string[] args)
        {

            int min = 0;
            int max = 0;
            int length = 5;
            for (int i = 0; i < length; i++)
            {
                int a = int.Parse(Console.ReadLine());
                if (i == 0)
                {
                    max = min = a;
                }
                else
                {
                    if (a > max)
                    {
                        max = a;
                    }
                    if (a < min)
                    {
                        min = a;
                    }
                }
            }

            Console.WriteLine($"max={max}, min ={min}");
            Console.ReadKey();
        }
    }
}
