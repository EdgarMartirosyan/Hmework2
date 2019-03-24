using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_01_04
{
    class Program
    {

        static void Main(string[] args)
        {

            Figure figure = new Figure(new Point("A", 2, 3), new Point("B", 3, 4), new Point("C", 4, 5));
            figure.PrimetrCalculator();
            Console.ReadKey();
        }

    }
}
