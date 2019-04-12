using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_157_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 2, 4, 5, 5, 7, 8, 9, 10, 10, 10, 6, 2 };
            for (int i = 0; i < array.Length; i++)
            {
                string p = "No";
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        p = "Yes";
                    }
                }
                if (p == "Yes")
                {
                    Console.WriteLine(array[i]);
                }
            }

            Console.ReadKey();
        }
    }
}
