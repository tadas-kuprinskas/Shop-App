﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopClassLibrary.Models
{
    public class Item
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public Item(string itemName, decimal itemPrice, int itemQuantity)
        {
            Name = itemName;
            Price = itemPrice;
            Quantity = itemQuantity;
        }
    }

}
