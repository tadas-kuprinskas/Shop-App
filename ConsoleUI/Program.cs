using ShopClassLibrary.Models;
using ShopClassLibrary.Helpers;
using System;
using System.Text.RegularExpressions;
using ShopClassLibrary.Interfaces;
using ShopClassLibrary.Services;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var shop = new Shop();
            IPrint cPrint = new ConsolePrintServices();
            IAddMoney addMoney = new AddMoneyService();
            IConsoleRead consoleRead = new ConsoleReadService();
            User user = new User(addMoney);

            var startApp = true;
            cPrint.Print($"{Message.welcomeMessage}{Message.nextCommand}");

            Creation.CreateFirstItems(shop);

            while (startApp)
            {
                try
                {
                    var text = consoleRead.GetConsoleString();

                    string[] textArr = Regex.Split(text, " ");

                    switch (textArr[0].ToLower())
                    {
                        case "balance":

                            cPrint.Print($"{Message.currentBalance}{user.Balance}\n{Message.nextCommand}");
                            break;
                       case "add":
                            var addItem = textArr[1];
                            var addAmount = int.Parse(textArr[2]);

                            cPrint.Print($"{shop.AddItem(addItem, addAmount)}{Message.nextCommand}");
                            break;
                        case "buy":
                            var itemToBuy = textArr[1];
                            var amountToBuy = int.Parse(textArr[2]);

                            cPrint.Print($"{shop.BuyItem(user, itemToBuy, amountToBuy)}{Message.nextCommand}");
                            break;
                        case "list":
                            shop.GetItemList();

                            cPrint.Print($"{Message.nextCommand}");
                            break;
                        case "topup":
                            var amount = decimal.Parse(textArr[1]);
                            user.AddMoney(user, amount);

                            cPrint.Print($"{Message.addedMoney + amount}{Message.nextCommand}");
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
                    cPrint.Print(Message.noSuchCommand); 
                }
                catch (Exception e)
                {
                    startApp = false;

                    cPrint.Print(e.Message);
                }
            }
        }
    }
}
