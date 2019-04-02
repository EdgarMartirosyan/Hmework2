using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_11_07
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat fristcat = new Cat();
            fristcat.Name = "Tony";
            fristcat.SayMiau();
            Cat secondcat = new Cat("Piso", "blue");
            secondcat.SayMiau();
            Console.WriteLine("{0} is {1}", secondcat.Name, secondcat.Color);
            Console.ReadKey();
        }
    }
}
