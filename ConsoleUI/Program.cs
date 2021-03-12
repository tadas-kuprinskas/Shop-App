using ShopClassLibrary.Models;
using ShopClassLibrary.Helpers;
using System;
using System.Text.RegularExpressions;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var shop = new Shop();
  
            User user = new User();

            var startApp = true;
            Console.WriteLine($"{Message.welcomeMessage}{Message.nextCommand}");

            Creation.CreateFirstItems(shop);

            while (startApp)
            {
                try
                {
                    var text = Console.ReadLine();
                    string[] textArr = Regex.Split(text, " ");

                    switch (textArr[0].ToLower())
                    {
                        case "balance":
                            Console.WriteLine($"{Message.currentBalance}{user.Balance}\n{Message.nextCommand}");
                            break;
                       case "add":
                            var addItem = textArr[1];
                            var addAmount = int.Parse(textArr[2]);
                            Console.WriteLine($"{shop.AddItem(addItem, addAmount)}{Message.nextCommand}");
                            break;
                        case "buy":
                            var itemToBuy = textArr[1];
                            var amountToBuy = int.Parse(textArr[2]);
                            Console.WriteLine($"{shop.BuyItem(user, itemToBuy, amountToBuy)}{Message.nextCommand}");
                            break;
                        case "list":
                            shop.GetItemList();
                            break;
                        case "topup":
                            var amount = decimal.Parse(textArr[1]);
                            user.AddMoney(user, amount);
                            Console.WriteLine($"{Message.addedMoney + amount}{Message.nextCommand}");
                            break;
                        case "exit":
                            startApp = false;
                            break;
                        default:
                            throw new InvalidOperationException();
                    }
                }
                catch (InvalidOperationException)
                {
                    Console.WriteLine(Message.noSuchCommand); 
                }
                catch (Exception e)
                {
                    startApp = false;
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
