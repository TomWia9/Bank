using System;
using System.Collections.Generic;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            AccountsManager manager = new AccountsManager();

            manager.CreateBillingAccount("Tomasz", "Wiatrowski", 1234567890);
            manager.CreateSavingsAccount("Tomasz", "Wiatrowski", 1234567890);
            manager.CreateSavingsAccount("Karolina", "Chruścińska", 0987654321);

            IList<Account> accounts = (IList<Account>)manager.GetAllAccounts();

            Printer printer = new Printer();

            printer.Print(accounts[0]);
            printer.Print(accounts[2]);

            Console.ReadKey();
        }
    }
}
