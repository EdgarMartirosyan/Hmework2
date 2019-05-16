using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_10_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("mutqagrel zangvaci chapy");
            string str = Console.ReadLine();
            int u = string.IsNullOrEmpty(str) ? 0 : Convert.ToInt32(str);

            var list = new MyList<int>();
            var t = new Random();
            for (int i = 0; i < u; i++)
            {
                list.Add(t.Next(100));
            }

            Console.WriteLine("zangvaci elementnery");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]+"");
            }
            Console.WriteLine();
            Console.WriteLine(new string('-',30));

            Console.WriteLine("mutqagrel pntrvox arjeqy");
            if (list.Contains(Convert.ToInt32(Console.ReadLine())))
            {
                Console.WriteLine("mutqagrvac arjeqy zangvacum arka e");
            }
            else
            {
                Console.WriteLine("arjeqy chi gtnvel");
            }

            Console.ReadLine();
        }
    }
}
