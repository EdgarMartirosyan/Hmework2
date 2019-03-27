using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_05_04
{
    class Article
    {
        public string Name { get; set; }
        public string Shope { get; set; }
        public double Cost { get; set; }
        public Article(string name,string shope, double cost)
        {
            Name = name;
            Shope = shope;  
            Cost = cost;
        }
        
        public string Info()
        {
            return string.Format($"{Name} is made in {Shope} and have a  {Cost} millon AMD price");
        }
    }
}
