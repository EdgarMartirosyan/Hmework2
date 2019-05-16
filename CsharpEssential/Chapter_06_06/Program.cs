using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_06_06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nermucel N y");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("nermucel K y");
            int k = int.Parse(Console.ReadLine());

            if (k>=n)
            {
                Console.WriteLine("k>=N, xndrum enq mutaqagrel ...");
            }
            int i = 1; 
            for ( i = n-i; i>0; i--)
            {
                n *= i;
            }
            Console.WriteLine(n);
            for ( i = k-i; i >0; i--)
            {
                k *= i;
            }

            Console.WriteLine(n/k);
            Console.ReadKey();
        }
        
    }
}
