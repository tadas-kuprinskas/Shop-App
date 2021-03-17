using ShopClassLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopClassLibrary.Services
{
    public class ConsoleReadService : IConsoleRead
    {
        public string GetConsoleString()
        {
            return Console.ReadLine();
        }
    }
}
