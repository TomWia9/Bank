using System;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {

            Account savingsAccount = new SavingsAccount("940000000001", 0.0M, "Tomasz", "Wiatrowski", 92010133333);
            Account savingsAccount1 = new SavingsAccount("940000000002", 0.0M, "Karolina", "Chruścińska", 92010144444);
            Account billingAccount = new BillingAccount("940000000001", 0.0M, "Tomasz", "Wiatrowski", 92010133333);
            Printer printer = new Printer();


            printer.Print(savingsAccount);
            printer.Print(savingsAccount1);
            printer.Print(billingAccount);


            Console.ReadKey();
        }
    }
}
