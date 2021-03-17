using ShopClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopClassLibrary.Interfaces
{
    public interface IBuyItem
    {
        string BuyItem(User user, string itemToBuy, int amountToBuy, List<Item> Items);
    }
}
