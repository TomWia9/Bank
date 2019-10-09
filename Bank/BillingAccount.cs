using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    class BillingAccount:Account
    {
        public BillingAccount(string accountNumber, decimal balance, string firstName, string lastName, long pesel)
            : base(accountNumber, balance, firstName, lastName, pesel)
        {
        }

        public override string TypeName()
        {
            return "Rachunkowe";
        }

    }
}
