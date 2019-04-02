using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_11_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int year = int.Parse(Console.ReadLine());
            if (DateTime.IsLeapYear(year))
            {
                Console.WriteLine($"{year} is leap year");
            }
            else
            {
                Console.WriteLine($"{year} is not leap year");
            }


            Console.ReadKey();
        }
    }
}
