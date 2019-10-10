using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    class BillingAccount:Account
    {
        public BillingAccount(int id, string firstName, string lastName, long pesel)
            : base(id, firstName, lastName, pesel)
        {
        }

        public override string TypeName()
        {
            return "Rachunkowe";
        }

    }
}
