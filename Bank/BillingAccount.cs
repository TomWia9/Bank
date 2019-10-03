﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    class BillingAccount
    {
        public string AccountNumber;
        public decimal Balance;
        public string FirstName;
        public string LastName;
        public long Pesel;

        public BillingAccount(string accountNumber, decimal balance, string firstName, string lastName, long pesel)
        {
            AccountNumber = accountNumber;
            Balance = balance;
            FirstName = firstName;
            LastName = lastName;
            Pesel = pesel;
        }

        public string GetFullName()
        {
            return string.Format("{0} {1}", FirstName, LastName);
        }

        public string GetBalance()
        {
            return string.Format("{0}zł", Balance);
        }
    }
}
