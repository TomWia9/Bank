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

            IEnumerable<string> users = manager.ListOfCustomers();

            Printer printer = new Printer();

            foreach (var item in users)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
