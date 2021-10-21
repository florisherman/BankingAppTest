using System;
using System.Collections.Generic;

namespace BankingAppTest
{
    class Program
    {

        private enum menuOption
        {
            ViewTransactions = 1,
            DoTransaction = 2,
            ShowBalance = 3

        }
        //TODO implement the following method
        //The app needs to be optmized to allow mutiple.
        static void Main(string[] args)
        {

            WorkFlow w = new WorkFlow();
            Console.WriteLine("Wellcome to ...!");

            Console.Write("Enter customer Name :");
            var firstName = Console.ReadLine();

            Console.Write("Enter customer Surname :");
            var lastName = Console.ReadLine();

            var strOpeningBalance = "";
            decimal openingBalance; 
            while (!Decimal.TryParse(strOpeningBalance, out openingBalance))
            {
                Console.Write("Enter opening balance :");
                strOpeningBalance = Console.ReadLine();
            };

            w.CreateCustomer(new Customer()
            {
                FirstName = firstName,
                LastName = lastName
            }, openingBalance);

            var customer = w.ShowCustomer();
            Console.WriteLine("Customer Created: ");
            Console.WriteLine($"Customer details FirstName :{customer.FirstName} LastName :{customer.LastName}");

            Console.Clear();
            Console.WriteLine($"Welcome to the app FirstName :{customer.FirstName} LastName :{customer.LastName}");

            Console.WriteLine(
                "Main Menu :" +Environment.NewLine +
                "Press 1 to Post Transaction :" + Environment.NewLine +
                "Press 2 to view Transactions :" + Environment.NewLine +
                "Press 3 to Check Available Balance :"
            );

            Console.WriteLine("Please enter you transaction Details:");
            Console.Write("Description:");
            var decription = Console.ReadLine();
            Console.Write("Amount:");
            var amt = Console.ReadLine();
            w.AddTransaction("pizza",  2.12m);

            Console.ReadKey();

        }
    }
}
