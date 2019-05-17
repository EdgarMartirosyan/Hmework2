using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> ts = new HashSet<int>();
            ts.Add(5);
            ts.Add(10);
            
            ts.Add(20);
            ts.Add(15);
            foreach (int item in ts)
            {
                Console.WriteLine(item);
            }
            HashSet<int> hs2 = new HashSet<int>();
            hs2.Add(15);
            hs2.Add(20);
            hs2.Add(21);

            HashSet<int> hs3 = new HashSet<int>();
            hs3.IsSubsetOf(hs2);
            Console.WriteLine(new string('-',30));

            Console.WriteLine(hs2.IsSubsetOf(ts));
            Console.WriteLine(new string('-', 30));
            Console.WriteLine(hs2.ToString());
           
            Console.ReadKey();
        }
    }
}
