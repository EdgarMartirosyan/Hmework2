using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_05_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Article article = new Article();

            Console.WriteLine(article[Console.ReadLine()]);
            Console.WriteLine(article[1]);
            Console.ReadKey();
        }
    }
}
