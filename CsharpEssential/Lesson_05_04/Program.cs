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
            Store store = new Store(5);

            store.AddArticle(new Article("BMW", "Germany", 20), 0);
            store.AddArticle(new Article("Ford", "Use", 15), 1);
            store.AddArticle(new Article("Nissan", "Japan", 11), 2);
            store.AddArticle(new Article("Toyota", "Japan", 12), 3);
            store.AddArticle(new Article("Honda", "Japan", 13), 4);
         

            Console.WriteLine(store[0]);
            Console.WriteLine(new string('-',30));
            Console.WriteLine(store["BMW"]);
            Console.WriteLine(new string('-', 30));

            store.Show();
            Console.WriteLine(new string('-', 30));

            store.Sort();
            Console.WriteLine(new string('-', 30));

            store.Show();
            Console.WriteLine(new string('-', 30));

            store.Select("s");
            Console.WriteLine(new string('-', 30));

            store.MaxCost();
            Console.WriteLine(new string('-', 30));


            Console.ReadKey();
        }
    }
}
