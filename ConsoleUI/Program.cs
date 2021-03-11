using ShopClassLibrary.Models;
using ShopClassLibrary.Helpers;
using ShopClassLibrary.Services;
using System;
using System.Text.RegularExpressions;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var shop = new Shop();
            

            var userBalanceService = new UserBalanceService();
            User user = new User(userBalanceService);

            var startApp = true;
            Console.WriteLine(Message.welcomeMessage);

                    Creation.CreateFirstItems(shop);
            while (startApp)
            {
                try
                {
                    var text = Console.ReadLine();
                    string[] textArr = Regex.Split(text, " ");

                    switch (textArr[0])
                    {
                        case "balance":
                            Console.WriteLine($"{Message.currentBalance}{user.Balance}\n");
                            break;
                       case "add":
                            var addItem = textArr[1];
                            var addAmount = int.Parse(textArr[2]);
                            var addMessage = shop.AddItem(addItem, addAmount);
                            Console.WriteLine(addMessage);
                            break;
                        case "buy":   
                        
                            break;
                        case "list":
                            shop.GetItemList();
                            break;
                        case "money":
                            var amount = decimal.Parse(textArr[1]);
                            user.AddMoney(amount);
                            Console.WriteLine(Message.addedMoney + amount);
                            break;
                        case "exit":
                            startApp = false;
                            break;
                        default:
                            throw new InvalidOperationException();
                    }
                }
                catch (InvalidOperationException e)
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
