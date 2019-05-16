using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<string, int> slistA = new SortedList<string, int>();
            slistA.Add("a", 1);
            slistA.Add("o", 2);
            slistA.Add("l", 3);
            slistA.Add("i", 4);
            slistA.Add("z", 5);
            slistA.Add("b", 5);
            slistA.Add("g", 5);
            slistA.Add("d", 5);
            slistA.Add("c", 5);
            slistA.Remove("z");
            Console.WriteLine(slistA.Values[1]);
          

            Console.WriteLine(slistA.Keys);
            Console.WriteLine(slistA["l"]);
            Console.WriteLine(new string('-', 30));

            foreach (string item in slistA.Keys)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(new string('-',30));

            foreach (string item in slistA.Keys)
            {
                Console.WriteLine(slistA[item]);
            }

            Console.WriteLine(new string('-', 30));

            Console.WriteLine(slistA.Count);

            Console.WriteLine(new string('-', 30));

            Console.WriteLine(slistA.Capacity);

            Console.WriteLine(new string('-', 30));
            slistA.TrimExcess();
            Console.WriteLine(slistA.Capacity);
            Console.WriteLine(new string('-', 30));
            Console.WriteLine(slistA.Values);
            foreach (int item in slistA.Values)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(new string('-', 30));
            Console.ReadKey();

        }
    }
}
