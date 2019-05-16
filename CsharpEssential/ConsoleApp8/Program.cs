using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Dog:IEnumerable<T>
    {
        public int num;

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var ilA = new List<int>() { 100, 2, 3  };
            var ilB = new List<int>(ilA);
            ilB.Add(6);
            ilB.Add(7);
            ilB.Add(8);
          
            //ilB.Add(8);
            //ilB.Add(9);
            //ilB.Add(10);
            //ilB.Add(11);

            var listA = new List<int>(17);

            

            var listB = new List<int>();
            listB.AddRange(ilA);
            listB.AddRange(ilB);
            listB.AddRange(listA);
            Console.WriteLine(ilA.Capacity);
            Console.WriteLine(ilB.Capacity);
            Console.WriteLine(listA.Capacity);
            Console.WriteLine(listB.Capacity);

            Console.WriteLine(new string('-', 30));

            //listB.Insert(0, 12);
            listB.Add(12);
            for (int i = 0; i < listB.Count; i++)
            {
                Console.WriteLine(listB[i]);
            }
            Console.WriteLine();
            //listB.TrimExcess();
            Console.WriteLine(listB.Capacity);
            listB.TrimExcess();
            Console.WriteLine(listB.Capacity);

            Console.WriteLine(new string('-', 30));
            int[] array = { 5, 6, 7, 8 };
            listB.InsertRange(2, array);
            listB.Reverse();

            var listC=new List<int>(listB.GetRange(2,5).ToArray());
            for (int i = 0; i < listB.Count; i++)
            {
                Console.WriteLine(listB[i]);
            }
            Console.WriteLine();

            for (int i = 0; i < listC.Count; i++)
            {
                Console.WriteLine(listC[i]);
            }
            Console.WriteLine();
            //listB.TrimExcess();
            //Console.WriteLine(listB.Capacity);
            //listB.TrimExcess();
            //Console.WriteLine(listB.Capacity);
            //Console.WriteLine(listB.Contains(66));
            //Console.WriteLine(listB.IndexOf(5));
            Console.ReadKey();

        }
    }
}
