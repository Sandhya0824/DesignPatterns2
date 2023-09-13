﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public class RealBankAccount : IBankAccount
    {
        private decimal _balance;

        public RealBankAccount(decimal initialBalance)
        {
            _balance = initialBalance;
        }

        public void Deposit(decimal amount)
        {
            _balance += amount;
            Console.WriteLine($"Deposited ${amount}. New balance: ${_balance}");
        }

        public void Withdraw(decimal amount)
        {
            if (_balance >= amount)
            {
                _balance -= amount;
                Console.WriteLine($"Withdrawn ${amount}. New balance: ${_balance}");
            }
            else
            {
                Console.WriteLine($"Insufficient funds. Balance: ${_balance}");
            }
        }

        public decimal GetBalance()
        {
            return _balance;
        }
    }
}
