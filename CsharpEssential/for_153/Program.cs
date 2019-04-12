using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_157
{
    class Program
    {
        //2-n tveri mijakayqum gtnvox parz tvery
        static void Main(string[] args)
        {
            for (int i = 2; i < 173; i++)
            {
                string p="Yes";

                for (int j = 2; j < i; j++)
                {
                    if (i%j==0)
                    {
                         p = "No";
                    }
                }
                if (p!="No")
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}
