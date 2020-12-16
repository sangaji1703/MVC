﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Peran_Bagian_MVC.Model
{
    public class Item
    {
        public string title { get; set; }
        public double price { get; set; }
        
        public Item(string title, double price)
        {
            this.title = title;
            this.price = price;
        }
    }
}
