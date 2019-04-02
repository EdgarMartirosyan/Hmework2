using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_04_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nermucel arajin tivy");
            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("nermucel erkrord tivy");
            int b = Int32.Parse(Console.ReadLine());
            Console.WriteLine("nermucel erord tivy");
            int c = Int32.Parse(Console.ReadLine());
            Console.WriteLine();
            int sum = a + b + c;
            Console.WriteLine($"nermucvac tveri hanragumarn e {sum}");
        }
    }
}
