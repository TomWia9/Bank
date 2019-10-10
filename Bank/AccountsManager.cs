using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bank
{
    class AccountsManager
    {
        private IList<Account> _accounts;

        public AccountsManager()
        {
            _accounts = new List<Account>();
        }

        public IEnumerable<Account> GetAllAccounts()
        {
            return _accounts;
        }

        private int GenerateId()
        {
            int id = 1;

            if (_accounts.Any())
            {
                id = _accounts.Max(x => x.Id) + 1;
            }

            return id;
        }

        public SavingsAccount CreateSavingsAccount(string firstName, string lastName, long pesel)
        {
            int id = GenerateId();

            SavingsAccount account = new SavingsAccount(id, firstName, lastName, pesel);

            _accounts.Add(account);

            return account;
        }
        
        public BillingAccount CreateBillingAccount(string firstName, string lastName, long pesel)
        {
            int id = GenerateId();

            BillingAccount account = new BillingAccount(id, firstName, lastName, pesel);

            _accounts.Add(account);

            return account;
        }
    }
}
