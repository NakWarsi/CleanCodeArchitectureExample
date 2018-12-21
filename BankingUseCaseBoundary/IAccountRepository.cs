using System;
using BankingDomain;
namespace BankingUseCaseBoundary
{
    public interface IAccountRepository
    {
        void AddAccount(Account account);
        Account Get(int id);
    }
}
