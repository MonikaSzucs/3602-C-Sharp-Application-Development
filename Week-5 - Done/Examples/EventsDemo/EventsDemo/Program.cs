using System;

namespace EventsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Banking App - Events Demo";

            while (true)
            {
                ChequingAccount account = AccountUI.GetAccountFromUser();
     
                if (account == null)
                {
                    return;
                }
                else
                {
                    account.AccountOverDrawn += AccountUI.AccountWasOverDrawn;
                    AccountUI.PerformAccountActions(account);
                }
            }
        }
    }
}
