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
            Store store = new Store(3);

            store.AddArticle(new Article("BMW", "Germany", 20), 0);
            store.AddArticle(new Article("Ford", "Use", 15), 1);
            store.AddArticle(new Article("Nissan", "Japn", 11), 2);
            store.AddArticle(new Article("Toyota", "Japn", 12), 2);
            store.AddArticle(new Article("Honda", "Japn", 13), 2);

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


            Console.ReadKey();
        }
    }
}
