using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> il = new List<int>();
            il.Add(59);
            il.Add(9);
            il.Add(69);
            il.Add(49);
            il.Add(39);
            il.Add(19);
            il.Add(29);
            il.Add(29);
            il.Add(29);
            il.Add(29);
            il.Add(29);
            il.Add(29);


            il.Remove(1);
            
            Console.WriteLine("\nList:");
            for (int i = 0; i < il.Count; i++)
            {
                Console.WriteLine(il[i]);
            }
            Console.WriteLine(new string('-',30));
            il.Sort();
            for (int i = 0; i < il.Count; i++)
            {
                Console.WriteLine(il[i]);
            }
            Console.WriteLine(new string('-', 30));
            Console.WriteLine("capacity"+   il.Capacity);
            Console.WriteLine(new string('-', 30));
            //  il.Clear();

            il.TrimExcess();
            il.Clear();
            Console.WriteLine("changed capacity" + il.Capacity);

            for (int i = 0; i < il.Count; i++)
            {
                Console.WriteLine(il[i]);
            }
            il.TrimExcess();
            Console.WriteLine(il.Capacity);
            Console.WriteLine(new string('-', 30));
            Console.ReadKey();

        }
    }
}
