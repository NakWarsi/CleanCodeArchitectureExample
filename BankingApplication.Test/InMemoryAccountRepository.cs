using System;
using System.Collections.Generic;
using System.Text;
using BankingDomain;
using BankingUseCaseBoundary;

namespace BankingApplication.Test
{
    class InMemoryAccountRepository : IAccountRepository
    {
        List<Account> customerAccounts = new List<Account>();

        public void AddAccount(Account account)
        {
            customerAccounts.Add(account);
        }

        public Account Get(int id)
        {
            return  customerAccounts.Find(x => x._id == id);           
        }
    }
}
