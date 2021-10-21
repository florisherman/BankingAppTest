using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingAppTest
{
   public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Account> Accounts { get; set; } = new List<Account>();

        public Account GetDefaultAccount()
        {
            return Accounts.FirstOrDefault();
        }
    }

    public class Account
    {
        public List<Transactions> Transactions { get; set; } = new List<Transactions>();
        public string AccountNumber { get; set; }
        public decimal AvailableBalance { get; set; }
        public void UpdateBalance(decimal amount)
        {
            AvailableBalance -= amount;
        }
    }

    public class Transactions
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        
        /// <summary>
        /// Add transactions to account
        /// </summary>
        /// <param name="description"></param>
        /// <param name="amount"></param>
        /// </param name="accountNumber"></param>
        public void AddTransaction(string description, decimal amount, string accountNumber = null)
        {
	       /* var account = Customer.GetDefaultAccount();

	        if (!string.IsNullOrWhiteSpace(accountNumber))
	        {
		        account = Customer.Accounts.FirstOrDefault(a => a.AccountNumber == accountNumber);
	        }

	        account.Transactions.Add(new Transactions()
	        {
		        Amount = amount,
		        Description = description
	        });
	        account.UpdateBalance(amount);
            */
        }
    }

}
