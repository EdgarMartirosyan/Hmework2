using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_05_04
{
    class Store
    {
        Article[] articles;
        
        public Article this[int i]
        {
            get { return articles[0]; }
            set { articles[0] = value; }
        }

    }
}
