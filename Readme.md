# Console Shop App
This is a .NET console application written in C#. The App represents a shop that sells candies, books and cups.

## Task

Create a shop that sells candies, books and cups. 

### Requirements

- All the items need to have names and quantities. 
- The App should run as long as the command is not `exit`.
- Use OOP with minimum 2 classes.
- Create User class that holds money balance.
- Prices of Items should be displayed when a command `list` is typed.
- Create a command `balance` that shows how much money User has.
- `Topup` command to add money to the budget.
- Apply Services principle and separate console printing and shop operations into separate services.
- Add extra service which reads input from a file (like 'list', 'buy', etc) and prints output into separate.
This should be exchangable with ConsolePrinter (use the same interface).
    
### Usage

Run the App and type the commands from the list.

#### Commands of the App:

- `Topup (amount)` - adds money to User's balance.
- `Balance` - displays your current balance;
- `List` - displays all available items;
- `Buy Candy (quantity)` - buys wanted quantity of the item;
- `Add Cup (quantity)` - adds the specified amount of item;
  
