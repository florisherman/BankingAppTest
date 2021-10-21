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

		/// <summary>
		/// Returns the Default account
		/// </summary>
		/// <returns></returns>
		public Account GetDefaultAccount()
		{
			return Accounts.FirstOrDefault();
		}
	}
}
