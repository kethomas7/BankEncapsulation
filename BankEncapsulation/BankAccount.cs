using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    public class BankAccount
    {
        private double balance = 0;

        public string Type { get; set; } //Type of account Checkings or Savings
        public string FirstName { get; set;}// First Name on the account

        public string LastName { get; set; }//last name on the account


    

        public void Deposit (double moneyAdded){

            Console.WriteLine("How much money do you want to add to the account?");
            moneyAdded = Double.Parse(Console.ReadLine());
         
            balance += moneyAdded ;
            Console.WriteLine($"Remaining Balance: {balance}");
        }

        public double GetBalance()
        {
            
            return balance;
        }
        public void Withdraw (double moneyNeeded)
        {
            Console.WriteLine("How much money do you want to take out the account?");
            moneyNeeded = Double.Parse(Console.ReadLine());

            balance -= moneyNeeded;
            Console.WriteLine($"Remaining Balance: {balance}");
        }


      

        public static string CheckType (string type)
        {
            return type;
        }

        public void RecieptCheck()
        {
            Console.WriteLine("Would you like a reciept?");
            if (Console.ReadLine().ToLower() == "yes")

            {
                Console.WriteLine($"Here is your reciept: \nSummary: Account Name: {FirstName} {LastName}\nAccount Type: {Type}\nBalance: {balance} ");
            }
            else
            {
                Console.WriteLine("Thank you for banking with Regions, Have a nice day.");
            }

        }
    }
}
