using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopClassLibrary.Helpers
{
    public static class Message
    {
        
        public static string addedMoney = "You have added this amount of money to your balance: ";
        public static string currentBalance = "Your current balance is: ";
        public static string notEnoughMoney = "You have not enough money\n";
        public static string noSuchItem = "There is no such item at the shop!\n";
        public static string requestTooHigh = "There are not enough items. Your request is too high\n";
        public static string boughtItem = "You have successfully bought your item\n";
        public static string itemAdded = "Item has been added successfully!\n";
        public static string allItemsSold = "All items have been sold\n";
        public static string noSuchCommand = "There is no such command\n";
        public static string nextCommand = "\nType your next command\n";
        public static string exit = "Program is closing\n";

        public static string welcomeMessage =
            "List\t\t\t\t\t : Displays available items\nBuy \"Item Name\" \"Amount\"\t\t : Buys wanted amount of the item\nAdd \"Item Name\" \"Amount\"\t\t : Increases amount of items\nBalance\t\t\t\t\t : Shows your current balance\nMoney \"Amount\"\t\t\t\t : Adds money to your balance\nExit\t\t\t\t\t : Exits the program.\n";
    }
}
