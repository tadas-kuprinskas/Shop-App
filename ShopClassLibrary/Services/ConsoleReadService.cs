using ShopClassLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopClassLibrary.Services
{
    public class ConsoleReadService : IReader
    {
        public string GetValue()
        {
            return Console.ReadLine();
        }
    }
}
