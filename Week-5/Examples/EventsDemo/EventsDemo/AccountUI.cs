using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsDemo
{
    public static class AccountUI
    {
        /// <summary>
        /// Returns a chequing account, or null if the users wishes to Exit
        /// </summary>
        /// <returns></returns>
        public static ChequingAccount GetAccountFromUser()
        {
            Console.Write("Please enter an account number (or \"X\" to exit): ");
            string accountNumber = Console.ReadLine();

            if (accountNumber == "X")
            {
                return null;
            }

            ChequingAccount account = AccountService.GetAccountByNumber(accountNumber);

            Console.WriteLine($"Account {account.AccountNumber} with a balance of {account.Balance:N2} selected.");

            return account;
        }
        /// <summary>
        /// Performs any number of withdraws or deposits until the user wishes to stop
        /// </summary>
        /// <param name="account"></param>
        public static void PerformAccountActions(ChequingAccount account)
        {
            while (true)
            {
                Console.Write("Enter 'D' to deposit; 'W' to withdraw, or 'X' to cancel: ");
                string command = Console.ReadLine();
                decimal amount;
                switch (command)
                {
                    case "D":
                        amount = GetAmountFromUser();
                        if (amount > 0.0m)
                        {
                            account.Deposit(amount);
                            Console.WriteLine($"{amount} deposited. New balance: {account.Balance}");
                        }
                        else
                        {
                            Console.WriteLine("Amount must be greater than zero.");
                        }

                        break;
                    case "W":
                        amount = GetAmountFromUser();
                        if (amount > 0.0m)
                        {
                            account.WithDraw(amount);
                            Console.WriteLine($"{amount} withdrawn. New balance: {account.Balance}");
                        }
                        else
                        {
                            Console.WriteLine("Amount must be greater than zero.");
                        }
                        break;
                    case "X":
                        Console.WriteLine($"Account {account.AccountNumber} final balance: {account.Balance}");
                        return;
                    default:
                        break;
                }
            }
        }
        /// <summary>
        /// Returns the amount entered by the user or 0.0 if the users wishes to exit.
        /// </summary>
        /// <returns></returns>
        public static decimal GetAmountFromUser()
        {
            while (true)
            {
                Console.Write("Enter amount (or \"X\" to cancel): ");
                string amount = Console.ReadLine();
                if (amount == "X")
                {
                    return 0.0m;
                }
                if (decimal.TryParse(amount, out decimal parsedAmount))
                {
                    return parsedAmount;
                }
                else
                {
                    Console.WriteLine("Not a valid amount. Please try again.");
                }
            }
        }
        public static void AccountWasOverDrawn(object sender, EventArgs e)
        {
            ChequingAccount account = (ChequingAccount)sender;
            Console.WriteLine("  ___   ___  _ __  ___ \r\n / _ \\ / _ \\| '_ \\/ __|\r\n| (_) | (_) | |_) \\__ \\\r\n \\___/ \\___/| .__/|___/\r\n            | |        \r\n            |_|       \r\n");
            Console.WriteLine($"Account {account.AccountNumber} is overdrawn! Current balance is {account.Balance}.");
        }
    }
}
