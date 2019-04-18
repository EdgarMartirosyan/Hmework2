using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_161
{
    class Program
    {
        // dzerqov lcvox matrica
        static void Main(string[] args)
        {
            int a=int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            
            int[,] array = new int[a,b];
            for (int i = 0; i < array.GetLength(0) ; i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] =int.Parse(Console.ReadLine());
                }                
            }
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i,j]+", ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
