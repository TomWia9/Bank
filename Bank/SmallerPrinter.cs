using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    class SmallerPrinter : IPrinter
    {
        public void Print(Account account)
        {
            Console.WriteLine("Dane konta: {0}", account.AccountNumber);
            Console.WriteLine("Imię i nazwisko właściciela: {0}", account.GetFullName());
            Console.WriteLine();
        }
    }
}
