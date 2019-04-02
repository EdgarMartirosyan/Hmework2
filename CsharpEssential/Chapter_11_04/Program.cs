using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_11_04
{
    class Program
    {
        static void Main(string[] args)
        {
            //string  environment = Environment
            int info = Environment.TickCount;
            Console.WriteLine(info);

            int[] dateinfo = new int[3];
            dateinfo[0] = info / 1000;
            dateinfo[1] = dateinfo[0] / 60;
            dateinfo[2] = dateinfo[1] / 24;

            foreach (var item in dateinfo)
            {
                Console.Write(" ,{0},", item);
            }
            int minute = info / 1000;
            int hour = minute / 60;
            int day = hour / 24;


            Console.ReadKey();
        }
    }
}
