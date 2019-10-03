using System;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {

            SavingsAccount savingsAccount = new SavingsAccount("940000000001", 0.0M, "Tomasz", "Wiatrowski", 92010133333);
            SavingsAccount savingsAccount1 = new SavingsAccount("940000000002", 0.0M, "Karolina", "Chruścińska", 92010144444);
            BillingAccount billingAccount = new BillingAccount("940000000001", 0.0M, "Tomasz", "Wiatrowski", 92010133333);
            Printer printer = new Printer();

            Console.WriteLine("Pierwsze konto: {0}", savingsAccount.GetFullName());
            printer.Print(savingsAccount);
            printer.Print(savingsAccount1);
            printer.Print(billingAccount);

            Console.ReadKey();
        }
    }
}
