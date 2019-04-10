using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_148
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 20;
            for (int i = 0; i < n; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write(i + ", ");
                }
            }
            Console.ReadKey();
        }
    }
}
