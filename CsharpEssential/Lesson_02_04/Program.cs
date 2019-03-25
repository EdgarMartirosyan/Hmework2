using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_02_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice(147258, "Edgar", "TexShope") { Article = "laptop", Quantity = 2 };

            invoice.CostCalculator(true);
            invoice.CostCalculator(false);

            Console.ReadKey();
        }
    }
}
