using ShopClassLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopClassLibrary.Services
{
    public class ConsolePrintServices : IPrint
    {
        public void Print(string text)
        {
            Console.WriteLine($"{text}");
        }
    }
}
