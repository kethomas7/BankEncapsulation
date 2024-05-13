namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            BankAccount Account = new BankAccount();

            Console.WriteLine("Welcome to Regions, What's the first name on the account?");
            Account.FirstName = Console.ReadLine();


            Console.WriteLine("What's the last name on the account?");
            Account.LastName = Console.ReadLine();


            Console.WriteLine($"Hello {Account.FirstName} {Account.LastName}, Is this a checkings or savings account?");
            Account.Type = Console.ReadLine();

            Console.WriteLine($"What would you like to do with this {Account.Type} account: Withdraw, Deposit, Check Balance");
            string usersChoice = Console.ReadLine();


            if (usersChoice == "Withdraw")
            {

                Account.Withdraw(Account.GetBalance());
            }
            else if (usersChoice == "Deposit")
            {

                Account.Deposit(Account.GetBalance());
            }
            else
            {
                Account.GetBalance();
            }

            Account.RecieptCheck();
        }



    }
}
