using System;

namespace ATMProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var rSaenz = new Client();
            rSaenz.firstName = "Robert";
            rSaenz.lastName = "Saenz";
            rSaenz.pinNumber = 1234;
            rSaenz.balance.currentBalance = 80;

            rSaenz.AccessAccount();
        }
    }
}
