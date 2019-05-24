using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_06_09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("mutqagrel n ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("mutqagrel x ");
            int x = int.Parse(Console.ReadLine());

            int sum = 0;
            int fac = 0;
            int num = 1;

            for (int i = 1; i <= n; i++)
            {
                fac = i;
                for (int j = fac-1; j>0; j--)
                {
                    fac*= j;
                    Console.WriteLine(i);                   
                }
                num *= x;
                Console.WriteLine($"\t{i}");
                Console.WriteLine($"\t\t{fac}");
                Console.WriteLine($"\t\t\t{num}");
                sum += (fac/num);
            }
            sum += 1;
           

            Console.WriteLine(sum);
            Console.ReadKey();
            
        }
    }
}
