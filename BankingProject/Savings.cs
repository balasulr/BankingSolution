using Banking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingProject {

    public class Savings : Account { // Savings is inheriting Account
        // What makes Saving account different from Account is paying Interest

        // Properties
        public decimal InterestRate { get; set; } = 0.12m;

        // Method to calculate how much Interest & put it into Account
        public void CalculateAndPayInterest(int months) {
            // Calculating how much interest to be paid
            decimal interest = Balance * (InterestRate / 12) * months;
            
            Deposit(interest);
        }
    }
}
