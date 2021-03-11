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
    public class UserBalanceService : IUserBalanceService
    {
        public void AddMoney(User user, decimal amount)
        {
            user.Balance += amount;
        }
    }
}
