using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsDemo
{
    public class ChequingAccount
    {
        public string AccountNumber { get; private set; }
        public decimal Balance { get; private set; }

        public ChequingAccount(string accountNumber, decimal initialBalance)
        {
            this.AccountNumber = accountNumber;
            this.Balance = initialBalance;
        }

        /// <summary>
        /// Event to be raised if the <see cref="Balance"/> becomes less than zero
        /// </summary>
        public event EventHandler<EventArgs> AccountOverDrawn;

        /// <summary>
        /// Wihtdraw money out of account.
        /// Raises the <see cref="AccountOverDrawn"/> event if this causes the <see cref="Balance"/> property to become less than zero.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">Thrown if amount is less than zero.
        /// Use the <see cref="Deposit"/> method to increase the balance of the account</exception>
        /// <param name="amount"></param>
        public void WithDraw(decimal amount)
        {
            if (amount <= 0m)
            {
                throw new ArgumentOutOfRangeException("Amount", "Amount must be greater than zero");
            }

            Balance -= amount;

            if (Balance < 0.00m)
            {
                if (AccountOverDrawn != null)
                {
                    AccountOverDrawn.Invoke(this, new EventArgs());
                }
            }
        }

        /// <summary>
        /// Deposit money in to an account.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">Thrown if amount is less than zero. 
        /// Use the <see cref="WithDraw"/> method to decrease the balance of the account.</exception>
        /// <param name="amount"></param>
        public void Deposit(decimal amount)
        {
            if (amount <= 0m)
            {
                throw new ArgumentOutOfRangeException("Amount", "Amount must be greater than zero");
            }

            Balance += amount;
        }
    }
}
