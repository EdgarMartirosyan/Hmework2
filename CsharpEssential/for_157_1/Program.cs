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
            int[] array = { 2, 2, 3,4,5,5,2,5};
            int count = 0;

            int newlenght = 0;
            Console.Write("{");
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        count++;
                    }
                   
                }
                if (count == 1)
                {
                    if (i==array.Length-1)
                    {
                        Console.Write(array[i] + ",");
                    }
                    else
                    {
                        Console.Write(array[i] );
                    }
                }
                count = 0;
            }
            Console.WriteLine("}");
            //Console.WriteLine(newlenght);
            Console.ReadKey();
        }
    }
}
