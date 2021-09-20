using System;
namespace ATMProject
{
    public class Client:Account
    {
        public string firstName { get; set; }
        public string lastName { get; set; }



        public void AccessAccount()
        {
            Console.WriteLine("Hello, Welcome to your Personal Banking System...");
            Console.WriteLine("Please enter your pin now!!");
            int pinPressed = Convert.ToInt32(Console.ReadLine());

            if(pinPressed == pinNumber )
            {
                Console.WriteLine("Access Granted, Welcome {0} {1}", firstName, lastName);
                PullUpCheckings();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Access Denied!! Please try again...");
                Console.WriteLine("--------------------------------------");
                Console.ReadKey();
                Console.Clear();
                AccessAccount();
                
            }
            
        }
    }
}
