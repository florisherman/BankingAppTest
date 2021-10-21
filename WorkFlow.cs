using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingAppTest
{
    public class WorkFlow
    {
        public List<Transactions> TransactionList { get; set; }
        public Account Account { get; set; }
        public Customer Customer { get; set; }

        public WorkFlow()
        {
            Account = new Account();
            Account.Transactions = TransactionList;

            Customer = new Customer();
            Customer.Accounts = new List<Account>() { Account };
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="description"></param>
        /// <param name="amount"></param>
        public void AddTransaction(string description, decimal amount)
        {
            var account = Customer.GetDefaultAccount();
            account.Transactions.Add(new Transactions()
            {
                Amount = amount,
                Description = description
            });
            account.UpdateBalance(amount);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Customer ShowCustomer()
        {
            return Customer;
        }

        /// <summary>b
        /// 
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
