using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Dog
    {
        public Dog()
        {
            Console.WriteLine("Dog()");
        }
        ~Dog()
        {
            Console.WriteLine("~Dog()");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var listA = new List<Dog>(5);

            for (int i = 0; i < 6; i++)
            {
                listA.Add(new Dog());
                GC.Collect();
            }


        }
    }
}
