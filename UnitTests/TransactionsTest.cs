using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankingAppTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UnitTests
{
	
	[TestClass]
	class TransactionsTest
    {
	    [TestMethod]
	    [ExpectedException(typeof(Exception), "Cannot add a negative value")]
	    public void AddingANegativeTransactionShouldDisplayError()
	    {
		    var customer = new Customer() 
		    {
			    FirstName = "Mirano",
			    LastName = "Jansen"
		    };

		    customer.Accounts.Add(new Account());

		    var account = customer.GetDefaultAccount();
		    account.AddTransaction("Pizza", -100m);
	    }

		/*TODO
		 * 
		 * Add a Unit Test to make sure your balance cannot go into the Negative
		 * 
		 */
	}
}
