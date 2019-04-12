using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_159
{
    class Program
    {
        // lracnel matrican mek tvov

        static void Main(string[] args)
        {
            int length = 5;
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    Console.Write(length +" ");
                }   
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
