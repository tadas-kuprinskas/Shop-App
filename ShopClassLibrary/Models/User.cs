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
    public class User 
    {
        public decimal Balance { get; set; }
        private IAddMoney _addMoney;

        public User(IAddMoney addMoney)
        {
            _addMoney = addMoney;
        }

        public void AddMoney(User user, decimal moneyAmount)
        {
             _addMoney.AddMoney(user, moneyAmount);           
        }

    }
}
