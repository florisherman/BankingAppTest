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
			var transaction = new Transaction()
			{
				Amount = amount,
				Description = description
			};

			Transactions.Add(transaction);

			UpdateBalance(amount);

			return transaction;
		}
	}
}