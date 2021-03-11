using ShopClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopClassLibrary.Helpers
{
    public class Creation
    {
        public static void CreateFirstItems(Shop shop)
        {            
            shop.Items.Add(new Item("Candy", 1.60M, 20));
            shop.Items.Add(new Item("Book", 20.65M, 20));
            shop.Items.Add(new Item("Cup", 5.40M, 20));
        } 
    }
}
