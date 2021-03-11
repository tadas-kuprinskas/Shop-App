using ShopClassLibrary.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopClassLibrary.Models
{
    public class Shop
    {
        public List<Item> Items { get; set; }
        public Shop()
        {
            Items = new List<Item>();
        }

        public string AddItem(string nameNewItem, int amountToAdd)
        {

            foreach (var item in Items)
            {
                if((item.Name).ToLower() == nameNewItem)
                {
                    item.Quantity += amountToAdd;
                    return Message.itemAdded;
                }
            }   
            return Message.noSuchItem;
        }

        public void GetItemList()
        {
            foreach (var item in Items)
            {
                if (item.Quantity > 0)
                {
                    Console.WriteLine($"{item.Name} {item.Price} {item.Quantity}"); 
                }
            }
        }
    }
}
