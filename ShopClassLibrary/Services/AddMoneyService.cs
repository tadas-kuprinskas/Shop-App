using ShopClassLibrary.Interfaces;
using ShopClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopClassLibrary.Services
{
    public class AddMoneyService : IAddMoney
    {
        public void AddMoney(User user, decimal moneyAmount)
        {
            user.Balance += moneyAmount;
        }
    }
}
