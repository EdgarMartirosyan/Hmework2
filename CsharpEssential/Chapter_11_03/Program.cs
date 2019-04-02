using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_11_03
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Today;

            var weekday = today.DayOfWeek;

            Console.WriteLine(weekday);
        }
    }
}
