using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_06_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nermucel tivy");
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 0; i <= n; i++)
            {
                if (i%3!=0 && i%7!=0)
                {
                    Console.Write(i + ", ");
                }
            }

            Console.ReadKey();
        }
    }
}
