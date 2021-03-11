using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopClassLibrary.Helpers
{
    public static class Message
    {
        public static string WelcomeMessage = "Type \"help\" to check the command list or just type the command: ";

        public static string AddedMoney = "You have successfully added money to your balance\n";
        public static string CurrentBalance = "Your current balance is: ";
        public static string NotEnoughMoney = "You have not enough money\n";
        public static string NoSuchItem = "There is no such item at the shop!\n";
        public static string RequestTooHigh = "There are not enough items. Your request is too high\n";
        public static string BoughtItem = "You have successfully bought your item\n";
        public static string ItemAdded = "Item has been added successfully!\n";
        public static string AllItemsSold = "All items have been sold\n";
        public static string NoSuchCommand = "There is no such command\n";
        public static string Exit = "Program is closing\n";

        public static string CommandList =
            "Command List:\nList\t\t\t\t\t : Displays available items\nBuy \"Item Name\" \"Amount\"\t\t : Buys wanted amount of the item\nAdd \"Item Name\" \"Amount\"\t\t : Increases amount of items\nBalance\t\t\t\t\t : Shows your current balance\nAdd money \"Amount\"\t\t\t : Adds money to your balance\nExit\t\t\t\t\t : Exits the program.\n";
    }
}
