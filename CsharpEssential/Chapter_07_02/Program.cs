using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_07_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nermucel array1 massivi elemntneri qanaky");
            int n1 = int.Parse(Console.ReadLine());
            int[] array1 = new int[n1];

            Console.WriteLine("nermucel array1 massivi elemntnery");

            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("nermucel array2 massivi elemntneri qanaky");
            int n2 = int.Parse(Console.ReadLine());
            int[] array2 = new int[n2];

            Console.WriteLine("nermucel array2 massivi elemntnery");

            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = int.Parse(Console.ReadLine());
            }

            bool check = false;
            if (array1.Length == array2.Length)
            {
                for (int i = 0; i < array1.Length; i++)
                {
                    if (array1[i] != array2[i])
                    {
                        check = true;
                    }

                }
                if (check)
                {
                    Console.WriteLine("zangvacneri elmentnery tarbervum en");
                }
                else
                {
                    Console.WriteLine("zangvacneri havasar en");
                }
            }
            else
            {
                Console.WriteLine("zangvacneri qanaky tarbervum e");
            }
            Console.ReadKey();
        }
    }
}
