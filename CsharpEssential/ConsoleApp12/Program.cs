using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> s = new Stack<int>();


            s.Push(1);
            s.Push(2);
            s.Push(4);
            s.Push(5);
            s.Push(3);

            Console.WriteLine(s.Count);
            Console.WriteLine(new string('-',30));
            Console.WriteLine(s.Peek());
            Console.WriteLine(new string('-',30));

            foreach (int item in s)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
