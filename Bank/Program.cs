using System;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {

            Account savingsAccount = new SavingsAccount(0,"Tomasz", "Wiatrowski", 92010133333);
            Account savingsAccount1 = new SavingsAccount(1,"Karolina", "Chruścińska", 92010144444);
            Account billingAccount = new BillingAccount(2,"Tomasz", "Wiatrowski", 92010133333);
            IPrinter printer = new Printer();
            IPrinter smallerPrinter = new SmallerPrinter();
            printer = smallerPrinter;

            printer.Print(savingsAccount);
            printer.Print(savingsAccount1);
            printer.Print(billingAccount);

            Console.ReadKey();
        }
    }
}
