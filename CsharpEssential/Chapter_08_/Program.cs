using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_08_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("mutqagrel 1-1024 amboxj tvery");
            int n = int.Parse(Console.ReadLine());
            int mnacord = 0;
            string conmn = "";


            Console.WriteLine(Convert.ToString(n, 2));

            for (int i = 0; i < n;)
            {
                mnacord = n % 2;
                conmn += mnacord.ToString();
                n /= 2;
            }

            string conmn1 = "";

            for (int i = conmn.Length - 1; i >= 0; i--)
            {
                conmn1 = conmn1 + conmn[i];
            }

            long result = long.Parse(conmn1);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
