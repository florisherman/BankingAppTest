using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingAppTest
{
	public class Transaction
	{
		public int Id { get; set; } = new Random().Next(1000, 999999);
		public string Description { get; set; }
		public decimal Amount { get; set; }
	}
}
