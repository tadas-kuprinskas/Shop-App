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
    public class BuyItemService : IBuyItem
    {
        public string BuyItem(User user, string itemToBuy, int amountToBuy, List<Item> Items)
        {
            foreach (var item in Items)
            {
                if ((item.Name).ToLower() == itemToBuy)
                {
                    item.Quantity -= amountToBuy;
                    user.Balance -= item.Price * amountToBuy;
                    return Message.boughtItem;
                }
            }

            return Message.noSuchItem;
        }
    }
}
