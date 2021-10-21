using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingAppTest
{
	public class Account
	{
		public string AccountNumber { get; set; } = Guid.NewGuid().ToString();

		public decimal AvailableBalance { get; private set; } = 1000;

		public List<Transaction> Transactions { get; set; } = new List<Transaction>();

		/// <summary>
		/// Updates the current Balance of the Account
		/// </summary>
		/// <param name="amount"></param>
		private void UpdateBalance(decimal amount)
		{
			/*Todo add available balance check*/
			if (amount > AvailableBalance)
			{
				throw new Exception("Insufficient funds in this account!");
			}

			AvailableBalance -= amount;
		}

		/// <summary>
		/// Add transactions to account
		/// </summary>
		/// <param name="description"></param>
		/// <param name="amount"></param>
		/// </param name="accountNumber"></param>
		public Transaction AddTransaction(string description, decimal amount)
		{
			/*TODO
			 * Ensure than negative transactions aren't accepted

				if (amount > 0)
				{
				   throw new Exception("Cannot add a negative value"); 
				}
			*/

			var transaction = new Transaction()
			{
				Amount = amount,
				Description = description
			};

			UpdateBalance(amount);

			Transactions.Add(transaction);

			return transaction;
		}
	}
}