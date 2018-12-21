using System;

namespace BankingDomain
{
    public class Account
    {
        public readonly int _id;
        private string _name;
        private double _balance;

        public Account(
            int id,
            string name,
            double balance)
        {
            _id = id;
            _name = name;
            _balance = balance;
        }

        public double Balance()
        {
            return _balance;
        }

        public void AddMoney(double amount)
        {
            _balance = _balance + amount;
        }

        public void WithdrawMoney(double amount)
        {
            _balance = _balance - amount;
        }
    }
}
