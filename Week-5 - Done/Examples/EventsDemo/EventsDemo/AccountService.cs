using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsDemo
{
    public class AccountService
    {
        /// <summary>
        /// Stud method for testing - always returns a balance of 150.55
        /// </summary>
        /// <param name="acountNumber"></param>
        /// <returns></returns>
        public static ChequingAccount GetAccountByNumber(string accountNumber)
        {
            return new ChequingAccount(accountNumber, 150.55m);
        }
    }
}
