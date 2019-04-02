using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_10_01
{
    class Program
    {
        //static void Loop(int [] arr,int  j)
        //{

        //}

        static void Main(string[] args)
        {
            int a = 0;
            int n = 3;
            for (int i = 0; i < n; i++)
            {

                for (int j = 0; j < n; j++)
                {

                    for (int k = 0; k < n; k++)
                    {

                        for (int l = 0; l < n; l++)
                        {
                            a++;
                            //Console.Write($"\t{i}a");                          
                            //Console.Write($"\t\t{j}b");                                                
                            //Console.Write($"\t\t\t{k}c");
                            //Console.Write($"\t\t\t\t{l}d");
                            Console.WriteLine($"{i}a {j}b {k}c {l}d");
                        }
                    }
                }
            }
            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}
