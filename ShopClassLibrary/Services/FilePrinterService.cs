using ShopClassLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopClassLibrary.Services
{
    public class FilePrinterService : IPrint
    {       
        public void Print(string text)
        {
            try
            {
                StreamWriter sw = new StreamWriter("C:\\Users\\tadas\\source\\repos\\ConsoleShopApplication\\ShopClassLibrary\\TextFiles\\Output.txt", true);
                sw.WriteLine(text);
                sw.Close();
            }
            catch (Exception e)
            {
                throw new Exception ($"{e}");                
            }
        }
    }
}
