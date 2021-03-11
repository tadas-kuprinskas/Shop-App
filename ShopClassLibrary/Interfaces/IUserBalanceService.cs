using ShopClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopClassLibrary.Interfaces
{
    public interface IUserBalanceService
    {
        void AddMoney(User user, decimal amount);
    }
}
