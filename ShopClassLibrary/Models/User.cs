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
        private IUserBalanceService _userBalanceService;

        public User(IUserBalanceService userBalanceService)
        {
            _userBalanceService = userBalanceService;
        }

        public void AddMoney(decimal moneyAmount)
        {
            var uBalanceService = new UserBalanceService();
            uBalanceService.AddMoney(this, moneyAmount);            
        }

    }
}
