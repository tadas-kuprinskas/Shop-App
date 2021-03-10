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
    }
}
