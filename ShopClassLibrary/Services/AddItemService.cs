using ShopClassLibrary.Helpers;
using ShopClassLibrary.Interfaces;
using ShopClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopClassLibrary.Services
{
    public class AddItemService : IAddItem
    {
        public string AddItem(string nameNewItem, int amountToAdd, List<Item> Items)
        {
            foreach (var item in Items)
            {
                if ((item.Name).ToLower() == nameNewItem)
                {
                    item.Quantity += amountToAdd;
                    return Message.itemAdded;
                }
            }
            return Message.noSuchItem;
        }
    }
}
