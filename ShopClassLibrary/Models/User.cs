using ShopClassLibrary.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopClassLibrary.Models
{
    public class User 
    {
        public decimal Balance { get; set; }

        public void AddMoney(User user, decimal moneyAmount)
        {
            user.Balance += moneyAmount;           
        }

    }
}
