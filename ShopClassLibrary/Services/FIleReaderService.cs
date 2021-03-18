using ShopClassLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopClassLibrary.Services
{
    public class FIleReaderService : IReader
    {        
        private readonly StreamReader _fileName;

        public FIleReaderService(string fileName)
        {
            _fileName = new StreamReader(fileName);
        }

        public string GetValue()
        {
            try
            {
                StreamReader sr = new StreamReader($"C:\\Users\\tadas\\source\\repos\\ConsoleShopApplication\\ShopClassLibrary\\TextFiles\\{_fileName}", true);
                string line;
                if ((line = _fileName.ReadLine()) != null)
                {
                    return line;
                }

                _fileName.Close();
                return null;
            }
            catch (Exception e)
            {
                throw new Exception($"{e}");
            }
        }
    }
}

