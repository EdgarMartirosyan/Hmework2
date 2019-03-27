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

        public string this[int index]
        {
            get
            {
                return articles[index].Info();
            }
        }

        public void AddArticle(Article value, int index)
        {
            articles[index] = value;
        }

    }
}
