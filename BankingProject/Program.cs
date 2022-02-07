using Banking; // The namespace of Account is Banking and namespace of Program.cs is Banking Project

using System;

namespace BankingProject {
    class Program {
        static void Main(string[] args) {
            // Adding a Savings Account
            Savings sav1 = new Savings();
            sav1.Deposit(100);
            sav1.CalculateAndPayInterest(1); // Paying 1% per month
            sav1.CalculateAndPayInterest(1);
            sav1.Debug();


            //// New instance of a acocunt
            //Account acct1 = new Account(); // Here, had an error since the namespaces were different
            //acct1.Deposit(500);
            //acct1.Withdraw(200);
            //acct1.Debug();
            ////acct1.Withdraw(600);
            ////acct1.Debug();

            //Account acct2 = new Account();
            //acct2.Description = "My Second Account";
            //acct2.Deposit(1000);
            //acct2.Withdraw(350);
            //acct2.Debug();
            //// Transfer $100 from Account 2 to Account 1
            //acct2.Transfer(100, acct1);
            //acct1.Debug();
            //acct2.Debug();

        }
    }
}
