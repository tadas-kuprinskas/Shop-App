using ShopClassLibrary.Interfaces;
using ShopClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopClassLibrary.Services
{
    public class GetItemListService : IGetItemList
    {
        public void GetItemList(List<Item> Items)
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
