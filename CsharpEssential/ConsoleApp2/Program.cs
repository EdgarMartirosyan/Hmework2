using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 4, 3, 4 ,3 };

            int[] newarray = new int[array.Length];
            int n = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if ((i!=j)&&(array[i]==array[j]))
                    {
                        n++;
                    }
                }
            }
            Console.WriteLine(n);
            Console.ReadLine();
        }
    }
}
