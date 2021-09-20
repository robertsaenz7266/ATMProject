using System;
namespace ATMProject
{
    public class Account
    {
        public int pinNumber { get; set; }
        
        public Checkings balance = new Checkings();


        public void PullUpCheckings()
        {
            char input = 'a';
            var run = new Checkings();
            while (input != 'e')
            {
                Console.Clear();
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("Press w to Withdraw..");
                Console.WriteLine("Press d to Deposit..");
                Console.WriteLine("Press p to Print Transactions..");
                Console.WriteLine("Press e to exit from ATM.. ");
                input = Convert.ToChar(Console.ReadLine());

                if(input == 'w')
                {
                    Console.Clear();
                    run.Withdraw();
                }
                else if (input == 'd')
                {
                    Console.Clear();
                    run.Deposit();
                }
                else if (input == 'p')
                {
                    Console.Clear();
                    run.PrintTransactions();
                }
            }

        }
    }
}
