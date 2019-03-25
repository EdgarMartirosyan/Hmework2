using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_02_04
{
    class Invoice
    {
        readonly int account;
        readonly string customer;
        readonly string provider;
        public Invoice( int account, string customer,string provider)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
        }

        private string article;
        private int quantity;

        public string Article
        {
            get { return article; }
            set { article=value; }
        }
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public void CostCalculator(bool needVAT)
        {
            double cost;

            switch (Article)
            {
                
                case "laptop": cost = 1000;
                    break;
                case "harddisc": cost = 100;
                    break;
                case "SSD": cost = 150;
                    break;
                default: Console.WriteLine("nshvac apranqy cankum chka");
                    return;
            }
            if (needVAT)
            {

                cost = cost * Quantity * 7 / 6;
                Console.WriteLine($"{Quantity} hat {Article}y arzhe {Math.Round(cost,0)} dollar neraryal NDS y");
            }
            else
            {
                cost = cost * Quantity ;
                Console.WriteLine($"{Quantity} hat {Article}y arzhe {cost} dollar aranc NDS i");
            }
        }
    }
}
