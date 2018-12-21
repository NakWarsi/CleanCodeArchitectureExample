using BankingDomain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankingUseCases;
using BankingUseCaseBoundary;

namespace BankingApplication.Test
{
    [TestClass]
    public class TransferMoneyTest
    {
        [TestMethod]
        public void GivenEnoughBalanceTransferSucceds()
        {
            // TEST SETUP (SYSTEM UNDER TEST)
            IAccountRepository accountRep = new InMemoryAccountRepository();
            accountRep.AddAccount(new Account(1, "Kapil", 500));
            accountRep.AddAccount(new Account(2, "Sagar", 1000));


            TransferMoney transferMoney = new TransferMoney(accountRep);
            // TEST EXECUTION
            bool result = transferMoney.ExecuteTransaction(1, 2, 50);

            // TEST ASSERTION
            Account senderAccount = accountRep.Get(1);
            Account receiverAccount = accountRep.Get(2);

            Assert.AreEqual(senderAccount.Balance(), 450);
            Assert.AreEqual(receiverAccount.Balance(), 1050);
        }
    }
}
