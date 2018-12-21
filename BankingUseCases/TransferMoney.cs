using System;
using System.Collections.Generic;
using System.Text;
using BankingDomain;
using BankingUseCaseBoundary;
namespace BankingUseCases
{
    public class TransferMoney
    {
        private IAccountRepository _accountRepository;

        public TransferMoney(IAccountRepository accountRep)
        {
            _accountRepository = accountRep;
        }

        public bool ExecuteTransaction(
            int senderAccountID,
            int receiverAccountID,
            double amount)
        {
            Account senderAccount = _accountRepository.Get(senderAccountID);
            Account receiverAccount = _accountRepository.Get(receiverAccountID);

            senderAccount.WithdrawMoney(amount);
            receiverAccount.AddMoney(amount);
            return true;
        }
    }
}

