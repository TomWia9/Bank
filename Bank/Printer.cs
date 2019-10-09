using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    class Printer
    {
        public void Print(Account account)
        {
            Console.WriteLine("Typ: {0}", account.TypeName());
            Console.WriteLine("Dane konta: {0}", account.AccountNumber);
            Console.WriteLine("Saldo: {0}zł", account.Balance);
            Console.WriteLine("Imię i nazwisko właściciela: {0}", account.GetFullName());
            Console.WriteLine("PESEL właściciela: {0}", account.Pesel);
            Console.WriteLine();
        }
    }
}
