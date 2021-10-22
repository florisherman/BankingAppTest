using System;
using System.Collections.Generic;

namespace BankingAppTest
{

    /***
     * Test Objectives
     * 
     * Basic C# knowledge
     *
     * 1. Add a Transaction.
     *      => Available balance should be outputed to the screen after a successfull transaction was posted
     *
.     * 2. View A list of Transactions(Transaction History)
     *      => Account Balancs. that occured on the system
     *
     * 3. Check Available Balance 
     * 
     * 4. Prevent the user from entering a negative balance to make the Unit Test pass 
     *
     * 5. Add a Unit Test to make sure your balance cannot go into the Negative
     * 
     * ***/
    class Program
    {
        private enum _menuOptions
        {
            PostTransactions = 1,
            ViewTransactions = 2,
            CheckBalance = 3,
            Quit
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Capricorn Group Test App!");

            Console.Write("Enter Customer Name :");
            var firstName = Console.ReadLine();

            Console.Write("Enter Customer Surname :");
            var lastName = Console.ReadLine();

            var customer = new Customer()
            {
                FirstName = firstName,
                LastName = lastName
            };

            customer.Accounts.Add(new Account());

            Console.Clear();
            Console.WriteLine($"Welcome to the app {customer.FirstName} {customer.LastName}");
            
            while (true)
            {
	            int menuOption = DisplayMenu();
	            var account = customer.GetDefaultAccount();

                switch (menuOption)
                {
                    case (int)_menuOptions.PostTransactions:
                       
                        Console.WriteLine("Please enter you transaction Details");
                        Console.Write("Item Description:");
                        var description = Console.ReadLine();
                        
                        decimal amount = 0;
                        string stringAmount = "";
                        do
                        {
	                        Console.Write("Amount :");
	                        stringAmount = Console.ReadLine();

                        } while (!Decimal.TryParse(stringAmount, out amount));

                        
                        try
                        {
                            /*TODO
                           
                                Post(add) a Transaction
                                account.AddTransaction(description, amount);
                                Console.WriteLine($"Transaction added: {description} for N${amount} new balance {account.AvailableBalance}");

                                TODO
                                Display Transaction Info of new Balance
                              
                           
                             */
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }

                        Console.WriteLine("Press any key to continue ...");
                        Console.ReadKey();

                        break;
                    case (int)_menuOptions.ViewTransactions:



                        /*TODO
                         * Transaction History
                         * 
                         *foreach (var transaction in account.Transactions)
                            {
                                Console.WriteLine($"Transaction Id {transaction.Id}: {transaction.Description} for N${transaction.Amount}");
                            }
                        */

                        break;
                    case (int)_menuOptions.CheckBalance:



                        /*TODO
	                        View Balance
                            Console.WriteLine($"Your available balance is = {account.AvailableBalance} \n Press any key to continue ...");
	                     */

                        break;
                    case (int)_menuOptions.Quit:
                        Environment.Exit(0);
                        break;
                }

            }

        }

        public static int DisplayMenu()
        {
          

	        int menuOption = 0;
	        string stringMenuOption = "";
            do
	        {
                //Console.Clear();
                Console.WriteLine(
			        "Main Menu :" + Environment.NewLine +
			        "Press 1 to Post Transaction" + Environment.NewLine +
			        "Press 2 to View Transactions" + Environment.NewLine +
			        "Press 3 to Check Available Balance" + Environment.NewLine +
			        "Press 4 to Quit"
		        );

		        stringMenuOption = Console.ReadLine();

	        } while (!(int.TryParse(stringMenuOption, out menuOption) && menuOption > 0 && menuOption <= 4));

	        return menuOption;
        }
    }
}
