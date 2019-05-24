using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_11_02
{
    class Program
    {
        static void Main(string[] args)
        {

            
            var park = new CarCollection <string> ();

            park.AddCar("jiguli", new DateTime(1985, 12, 5));
            park.AddCar("toyota", new DateTime(2000, 4, 7));
            park.AddCar("ford", new DateTime(2005, 5, 3));
            park.AddCar("mersedec", new DateTime(2003, 11, 3));

            Console.WriteLine(park.ToString());

            Console.WriteLine("vaprkum ka {0} meqena", park.Lenght);

            Console.WriteLine("mutqagrel hetaqrqrox meqenai hamary:");
            string stroka = Console.ReadLine();

            if (string.IsNullOrEmpty(stroka))
                Console.WriteLine("arjeqy mutqagrvac e.");
            else
            {
                int nomer = Convert.ToInt32(stroka);
                Console.WriteLine(park[nomer - 1]);
            }

            // Delay.
            Console.ReadKey();


        }
    }
}
