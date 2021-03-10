using ShopClassLibrary.Models;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var shop = new Shop();
            shop.Items.Add(new Item("Candy", 1.60M, 20));
            shop.Items.Add(new Item("Book", 20.65M, 20));
            shop.Items.Add(new Item("Cup", 5.40M, 10));

            
        }
    }
}
