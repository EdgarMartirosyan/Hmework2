﻿using System;
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
    }
}
