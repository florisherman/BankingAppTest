using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingAppTest
{
    public class WorkFlow
    {
        public Customer Customer { get; set; }

        public WorkFlow()
        {
            Customer = new Customer();
        }

        /// <summary>
        /// Add transactions to account
        /// </summary>
        /// <param name="description"></param>
        /// <param name="amount"></param>
        /// </param name="accountNumber"></param>
        public void AddTransaction(string description, decimal amount, string accountNumber = null)
        {
            var account = Customer.GetDefaultAccount();

            if(!string.IsNullOrWhiteSpace(accountNumber)){
                account = Customer.Accounts.FirstOrDefault(a => a.AccountNumber == accountNumber);
            }
            
            account.Transactions.Add(new Transactions()
            {
                Amount = amount,
                Description = description
            });
            account.UpdateBalance(amount);
        }

        /// <summary>
        /// Show the Customer created within the Workflow
        /// </summary>
        /// <returns></returns>
        public Customer GetCustomer()
        {
            return Customer;
        }

        /// <summary>
        /// Allows you to create a customer with an opening Balance
        /// </summary>
        /// <param name="customer"></param>
        /// <param name="openingBalance"></param>
        public void CreateCustomer(Customer customer, decimal openingBalance)
        {
            Customer = customer;

            Customer.Accounts = new List<Account>()
                {
                    new Account()
                    {
                        AccountNumber = Guid.NewGuid().ToString(),
                        AvailableBalance = openingBalance
                    }
                };
        }
    }
}
