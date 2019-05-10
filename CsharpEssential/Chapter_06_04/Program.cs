
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_06_04
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int j = 1; j <= 4; j++)
            {
                for (int i = 1; i <= 13; i++)
                {
                    switch (j)
                    {
                        case 1:
                            Console.Write("Heart");
                            break;
                        case 2:
                            Console.Write("Dimond");
                            break;
                        case 3:
                            Console.Write("Club");
                            break;
                        case 4:
                            Console.Write("Spead");
                            break;
                    }


                    switch (i)
                    {
                        case 1:
                            Console.WriteLine(2);
                            break;
                        case 2:
                            Console.WriteLine(3);
                            break;
                        case 3:
                            Console.WriteLine(4);
                            break;
                        case 4:
                            Console.WriteLine(5);
                            break;
                        case 5:
                            Console.WriteLine(6);
                            break;
                        case 6:
                            Console.WriteLine(7);
                            break;
                        case 7:
                            Console.WriteLine(8);
                            break;
                        case 8:
                            Console.WriteLine(9);
                            break;
                        case 9:
                            Console.WriteLine(10);
                            break;
                        case 10:
                            Console.WriteLine("J");
                            break;
                        case 11:
                            Console.WriteLine("D");
                            break;
                        case 12:
                            Console.WriteLine("K");
                            break;
                        case 13:
                            Console.WriteLine("T");
                            break;

                    }
                }


            }
            Console.ReadKey();
        }
    }
}
