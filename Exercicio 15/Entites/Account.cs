using System;
using Exercicio_15.Entites.Exceptions;
using System.Globalization;

namespace Exercicio_15.Entites
{
    class Account
    {
        private int _number { get; set; }
        private string _holder { get; set; }
        private double _balance { get; set; }
        private double _withdrawLimit { get; set; }

        public Account()
        {
        }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            _number = number;
            _holder = holder;
            _balance = balance;
            _withdrawLimit = withdrawLimit;
        }

        public void deposit(double amount)
        {
            if(amount <= 0.0)
            {
                throw new DomainException("This amount cannot be deposited as it is less than and/or equal to zero..");
            }
            _balance += amount;
            
        }
        public void withdraw(double amount)
        {
            if (_balance <= 0.0 || _balance < amount)
            {
                throw new DomainException("Not enough balance");
            }
            if(_withdrawLimit < amount)
            {
                throw new DomainException("The amount exceeds withdraw limit");
            }
            _balance -= amount;
        }

        public override string ToString()
        {
            return " "
                +_balance.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
