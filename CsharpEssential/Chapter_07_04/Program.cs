using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_07_04
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 1, 2, 3, 2, 2, 2, 1 };
            int count = 0;
            int max = 0;
            for (int i = 0; i < array.Length-1; i++)
            {
                if (array[i]-array[i+1]==0)
                {
                    count++;
                }
                
                if (count>max)
                {
                    max = count;
                }
            }
            Console.WriteLine(max);
            Console.ReadKey();
        }
    }
}
