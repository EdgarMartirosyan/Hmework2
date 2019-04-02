using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_11_06
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 3;
            double b = 4;
            double c = 5;
            double aheight = 4;
            double bcangel = 30;

            double p = (a + b + c) / 2;

            double area1 = Math.Sqrt(p * ((p - a) * (p - b) * (p - c)));
            double area2 = (a * aheight) / 2;
            double area3 = 0.5 * c * b * Math.Sin(Math.PI * bcangel / 180.0);
            double area4 = 0.5 * c * b * Math.Sin(0.6);
            Console.WriteLine(Math.PI * bcangel / 180);
            Console.WriteLine(area1);
            Console.WriteLine(area2);
            Console.WriteLine(area3);
            Console.WriteLine(area4);
            Console.ReadKey();
        }
    }
}
