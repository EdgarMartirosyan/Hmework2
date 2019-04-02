using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_01_08

{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime date = new DateTime();
            DateTime dateTime = DateTime.Now;
            var date1 = date.Month;

            Console.WriteLine(date1);

            String[] culturnames = { "en-US", "ru-RU", "fr-Fr", "de-de" };
            foreach (var culturname in culturnames)
            {
                var cultur = new CultureInfo(culturname);
                Console.WriteLine("{0}:{1}", culturname, dateTime);
            }

            Console.ReadKey();
        }
    }
}
