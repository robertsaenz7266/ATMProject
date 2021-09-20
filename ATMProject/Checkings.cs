using System;
using System.Collections.Generic;

namespace ATMProject
{
    public class Checkings
    {
        public int checkingNumber { get; set; }
        public double currentBalance {get; set;}
        public List<Transactions> history = new List<Transactions>();

        public void Withdraw()
        {
            Random rng = new Random();
            int transId = rng.Next(0, 100000);
            Console.WriteLine("You have ${0} in your account..", currentBalance);
            Console.WriteLine("Enter amount to Withdraw:");
            double amount = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            double oldBalance = currentBalance;
            currentBalance = currentBalance - amount;
            history.Add(new Transactions(transId, 'W', DateTime.Today, amount, oldBalance, currentBalance ));
            Console.WriteLine("Here is a summary of your Transactions:");
            Console.WriteLine("New Balance is: ${0}", currentBalance);
            Console.WriteLine("Amount Withdrawn: ${0}",amount);
            Console.WriteLine("Transaction Date: {0}", DateTime.Today);
            Console.WriteLine("Press any key to Continue..");
            Console.ReadKey();
            Console.Clear();
        }
        public void Deposit()
        {
            Random rng = new Random();
            int transId = rng.Next(0, 100000);
            Console.WriteLine("You have ${0} in your account..", currentBalance);
            Console.WriteLine("Enter amount to Deposit:");
            double amount = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            double oldBalance = currentBalance;
            currentBalance = currentBalance + amount;
            history.Add(new Transactions(transId, 'D', DateTime.Today, amount, oldBalance, currentBalance));
            Console.WriteLine("Here is a summary of your Transactions:");
            Console.WriteLine("New Balance is: ${0}", currentBalance);
            Console.WriteLine("Amount Deposited: ${0}", amount);
            Console.WriteLine("Transaction Date: {0}", DateTime.Today);
            Console.WriteLine("Press any key to Continue..");
            Console.ReadKey();
            Console.Clear();
        }
        public void PrintTransactions()
        {
            Console.Clear();
            foreach (var transaction in history)
            {
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("Transaction Date: {0}", transaction.transactionDate);
                Console.WriteLine("Transaction Type: {0}", transaction.movementType);
                Console.WriteLine("Previous Balance: ${0}", transaction.oldBalance);
                Console.WriteLine("Transaction Amount: ${0}", transaction.amount);
                Console.WriteLine("Remaining Balance: ${0}", transaction.newBalance);
                Console.WriteLine("-------------------------------------------");

            }
            Console.WriteLine("Press Any key to Continue...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
