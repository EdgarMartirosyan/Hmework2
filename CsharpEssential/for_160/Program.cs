using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_160
{
    class Program
    {
        // lracnel matrican hertakan tverov ciklov
        static void Main(string[] args)
        {
            int length = 3;
            int count = 0;
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    count++;
                    Console.Write(count+" ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
