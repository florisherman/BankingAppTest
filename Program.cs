using System;
using System.Collections.Generic;

namespace BankingAppTest
{
    class Program
    {

     

        //TODO implement the following method
       //implement a menu
       //allow repeatable transactions
  
        static void Main(string[] args)
        {
          

            WorkFlow w = new WorkFlow();
            Console.WriteLine("Welcome to Capricorn Group Test App!");

            Console.Write("Enter Customer Name :");
            var firstName = Console.ReadLine();

            Console.Write("Enter Customer Surname :");
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

            var customer = w.GetCustomer();

            Console.Clear();
            Console.WriteLine($"Welcome to the app {customer.FirstName} {customer.LastName}");

            while (true)
            {
                Console.WriteLine(
                    "Main Menu :" + Environment.NewLine +
                    "Press 1 to Post Transaction" + Environment.NewLine +
                    "Press 2 to view Transactions" + Environment.NewLine +
                    "Press 3 to Check Available Balance" + Environment.NewLine +
                    "Press 4 to Quit"
                );

                Console.WriteLine("Please enter you transaction Details");
                Console.Write("Item Description:");
                var decription = Console.ReadLine();

                var stringAmount = "";
                decimal amount;
                while (!Decimal.TryParse(stringAmount, out amount))
                {
                    Console.Write("Amount :");
                    stringAmount = Console.ReadLine();
                };

                w.AddTransaction(decription, amount);

                Console.Clear();
                Console.WriteLine($"Transaction added: {decription} for N${amount}");

                Console.ReadKey();
            }
        }
    }
}
