using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingAppTest
{
	public class Capricorn
	{
		public Customer Customer { get; set; }

		public Capricorn()
		{
			Customer = new Customer();
		}

		/// <summary>
		/// Allows you to create a customer with an opening Balance
		/// </summary>
		/// <param name="customer"></param>
		/// <param name="openingBalance"></param>
		public Customer OpenAccount(Customer customer, decimal openingBalance)
		{
			Customer.Accounts = new List<Account>()
				{
					new Account()
					{
						AccountNumber = Guid.NewGuid().ToString(),
					}
				};

			return Customer;
		}

	}
}
