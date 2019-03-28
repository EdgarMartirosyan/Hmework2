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
        public string ShopCountryName { get; set; }
        public double Cost { get; set; }
        public Article(string name,string shope, double cost)
        {
            Name = name;
            ShopCountryName = shope;  
            Cost = cost;
        }
        
        public string Info()
        {
            return string.Format($"{Name} is made in {ShopCountryName} and have a  {Cost} millon AMD price");
        }
    }
}
