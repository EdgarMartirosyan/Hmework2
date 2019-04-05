using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topic_02
{
    class Program
    {
        static int Max(int a, int b)
        {
            int c = 0;

            if (a > b)
            {
                c = a;
            }
            else
            {
                c = b;
            }

            return c;
        }

        static int Min(int a, int b)
        {
            int c = 0;

            if (a < b)
            {
                c = a;
            }
            else
            {
                c = b;
            }

            return c;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int a = 0;

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if ((i + j) <= (n + 1))
                    {
                        a = Min(i, j);
                        Console.Write(new string(' ', n / 10 - a / 10));
                        Console.Write(a + ",");
                    }
                    else
                    {
                        a = n - Max(i, j) + 1;
                        Console.Write(new string(' ', n / 10 - a / 10));
                        Console.Write(a + ",");
                    }
                }
                Console.WriteLine();
            }

           
        }
    }
}
