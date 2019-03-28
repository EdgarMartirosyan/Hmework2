using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_05_04
{
    class Store
    {
        private Article[] articles;

        public Store(int size)
        {
            articles = new Article[Math.Abs(size)];
        }

        public void AddArticle(Article value, int index)
        {
            articles[index] = value;
        }

        public string this[int index]
        {
            get
            {
                return articles[index].Info();
            }
            
        }

        public string this[string index]
        {
            get
            {
                for (int i = 0; i < articles.Length; i++)
                {
                    if (articles[i].Name==index)
                    {
                        return articles[i].Info();
                    }
                }
                return "mutqagrvac tvyaly sxal e";
            }
        }

        public void Show()
        {
            for (int i = 0; i < articles.Length; i++)
            {
                Console.WriteLine($"\t {articles[i].Info()}");
            }
        }

        public void Sort()
        {
            for (int i = 0; i < articles.Length; i++)
            {
                for (int q = 0; q < articles.Length; q++)
                {
                    if (articles[i].Cost<=articles[q].Cost)
                    {
                        Article a = articles[i];
                        articles[i] = articles[q];
                        articles[q] = a;
                    }
                }
            }
        }

        public void Select(string text)
        {
            foreach (Article item in articles)
            {
                if (item.ShopCountryName.Contains(text))
                {
                    Console.WriteLine(item.Info());
                }
            }
        }

        public void MaxCost( )
        {
            double max = articles[0].Cost;
            Article temp = articles[0];
            foreach (Article item in articles)
            {
                if (item.Cost>max)
                {
                    max = item.Cost;
                    temp = item;
                }              
            }
            
            Console.WriteLine(temp.Info());
        }
    }
}
