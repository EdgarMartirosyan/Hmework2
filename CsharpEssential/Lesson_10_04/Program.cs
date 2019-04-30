using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_10_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            var dictionary = new MyDictionary<string, string>(n);

            for (int i = 0; i < n; i++)
            {
                dictionary.Add(i, "sexan", "table");
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(dictionary[i]);
            }
            Console.WriteLine(dictionary[1]);
            Console.WriteLine(dictionary.Lenght);

            // Delay.
            Console.ReadKey();
        }
    }
}
