using ShopClassLibrary.Helpers;
using ShopClassLibrary.Interfaces;
using ShopClassLibrary.Services;
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

        private IAddItem _addItem = new AddItemService();

        private IGetItemList _getItemList = new GetItemListService();

        private IBuyItem _buyItem = new BuyItemService();

        public Shop()
        {
            Items = new List<Item>();
        }

        public string AddItem(string nameNewItem, int amountToAdd)
        {
            return _addItem.AddItem(nameNewItem, amountToAdd, Items);
        }

        public void GetItemList()
        {
            _getItemList.GetItemList(Items);
        }
        public string BuyItem(User user, string itemToBuy, int amountToBuy)
        {

            return _buyItem.BuyItem(user, itemToBuy, amountToBuy, Items);
        }
    }
}
